using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace Blogg2
{


    public class DataAccess
    {


        string conString = @"Server=(localdb)\mssqllocaldb;Database=Blogg2";

        internal BlogPost GetBlogPostById(int postId)
        {
            string sql = @"Select Id, Title, Author
                            from BlogPost2
                            where Id=@johan";


            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("johan", postId));
                SqlDataReader reader = command.ExecuteReader();

                reader.Read();

                var bp = new BlogPost();

                int id = reader.GetSqlInt32(0).Value;
                string title = reader.GetSqlString(1).Value;
                string author = reader.GetSqlString(2).Value;

                bp.Id = id;
                bp.Title = title;
                bp.Author = author;

                return bp;
            }

        }

        internal void UpdateBlogPost(BlogPost post)
        {
            string sql = @"update BlogPost
                            set Title=@Title where Id=@Id";


            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("Id", post.Id));
                command.Parameters.Add(new SqlParameter("Title", post.Title));
                command.ExecuteNonQuery();

            }
        }

        internal List<BlogPost> GetAllBlogPosts()
        {
            string sql = @"select Id, Title, Author
                            from BlogPost2";


            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                var result = new List<BlogPost>();

                while (reader.Read())
                {

                    var bp = new BlogPost();

                    int id = reader.GetSqlInt32(0).Value;
                    string title = reader.GetSqlString(1).Value;
                    string author = reader.GetSqlString(2).Value;

                    bp.Id = id;
                    bp.Title = title;
                    bp.Author = author;

                    result.Add(bp);

                }

                return result;
            }


        }
    }
}
