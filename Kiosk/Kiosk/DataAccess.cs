using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kiosk.Domain;

namespace Kiosk
{
    public class DataAccess
    {

        string conString = @"Server=(localdb)\mssqllocaldb;Database=Kiosk";

        internal List<Product> GetAllProducts()
        {
            string sql = @"Select Id, Produkter, Antal 
                            from Lager";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                var result = new List<Product>();

                while (reader.Read())
                {

                    var bp = new Product();

                    int antal = reader.GetSqlInt32(2).Value;
                    string name = reader.GetSqlString(1).Value;
                    int id = reader.GetSqlInt32(0).Value;



                    //string author = reader.GetSqlString(2).Value;

                    bp.Antal = antal;
                    bp.Name = name;
                    bp.Id = id;
                   // bp.Author = author;

                    result.Add(bp);

                }

                return result;
            }
        }

        internal Product GetProductById(int productId)
        {
            string sql = @"Select id, Produkter, Antal 
                                from Lager
                             where id=@kalle";


            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("kalle", productId));

                SqlDataReader reader = command.ExecuteReader();
                reader.Read();

                var product = new Product();

                int id = reader.GetSqlInt32(0).Value;
                string name = reader.GetSqlString(1).Value;
                int antal = reader.GetSqlInt32(0).Value;

                product.Id = id;
                product.Name = name;
                product.Antal = antal;


                //bp.Id = id;
                //bp.Title = title;
                //bp.Author = author;
                return product;
            }
        }

        internal void UpdateLayer(Product product)
        {
            string sql = @"Update Lager
                        set Antal =@johan where	Id=@number";


            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("number", product.Id));
                command.Parameters.Add(new SqlParameter("johan", product.Antal));
                command.ExecuteNonQuery();

            }
        }
    }
}
