using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valutaappen_2._0.Domain;

namespace Valutaappen_2._0
{

    public class GetDataAccess
    {
        string conString = @"Server=(localdb)\mssqllocaldb;Database=Valuta";

        public void InsertIntoSQL(GetAPI api)
        {
            string sql = @"Insert into ExchangeRate ( Code, Rate, Date) 
                            Values (@Code, @Rate, @Date)";
                                //where Code=@Code";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("Code", api.Base));
                command.Parameters.Add(new SqlParameter("Rate", api.Rates));
                command.Parameters.Add(new SqlParameter("Date", api.Date));


                command.ExecuteNonQuery();
               
            }
           // DateTime date = reader.GetSqlDateTime(0).Value;
            //    string code = reader.GetSqlString(1).Value;
            //    decimal rate = reader.GetSqlDecimal(2).Value;
            //    string name = reader.GetSqlString(3).Value;
            //using (SqlConnection connection = new SqlConnection(conString))
            //using (SqlCommand command = new SqlCommand(sql, connection))
            //{
            //    connection.Open();
            //    SqlDataReader reader = command.ExecuteReader();


            //var result = new List<Currency>();

            //while (reader.Read())
            //{

            //    var c = new Currency();

            //    DateTime date = reader.GetSqlDateTime(0).Value;
            //    string code = reader.GetSqlString(1).Value;
            //    decimal rate = reader.GetSqlDecimal(2).Value;
            //    string name = reader.GetSqlString(3).Value;

            //    c.TimeStamp = date;
            //    c.Code = code;
            //    c.Rate = rate;
            //    c.Name = name;

            //    result.Add(c);

            //}

            //return result;
            // }


        }
    }
}

