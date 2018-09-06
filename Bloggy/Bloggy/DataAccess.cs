﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bloggy.Domain;

namespace Bloggy
{
    public class DataAccess
    {

        string conString = @"Server=(localdb)\mssqllocaldb;Database=Blog";

        public List<BlogPost> GetAllBlogPost()

        {

            string sql = @"select Id, Title, Author
                            from BlogPost";


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

        internal BlogPost GetBlogPostById(int postId)
        {
            string sql = @"select Id, Title, Author
                            from BlogPost
                             where Id=@Idk";


            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("Idk", postId));

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

        internal List<Comment> GetComments(int postId)
        {
            string sql = @"Select Id, text, BlogPostId from Comment
                            where BlogPostId=@number  ";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("number", postId));
                SqlDataReader reader = command.ExecuteReader();



                var result = new List<Comment>();

                while (reader.Read())
                {

                    var comment = new Comment();

                    int id = reader.GetSqlInt32(0).Value;
                    string text = reader.GetSqlString(1).Value;
                    int blogpostid = reader.GetSqlInt32(2).Value;

                    comment.Id = id;
                    comment.Text = text;
                    comment.BlogPostId = blogpostid;
                    //bp.Id = id;
                    //bp.Title = title;
                    //bp.Author = author;

                    result.Add(comment);

                }

                return result;
            }
        }

        public void UpdateBlogPost(BlogPost post)
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



    }
}