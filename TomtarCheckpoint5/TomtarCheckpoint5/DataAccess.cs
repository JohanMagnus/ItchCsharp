using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomtarCheckpoint5
{
    public class DataAccess
    {
        string conString = @"Server=(localdb)\mssqllocaldb;Database=GnomeDb";



        internal List<string> GetGnomesFromDatabase()
        {
            string sql = @"Select Name from Gnome";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                var result = new List<string>();

                while (reader.Read())
                {

                    string name = reader.GetSqlString(0).Value;
                   
                    result.Add(name);

                }

                return result;
            }
        }

        internal List<Gnome> GetGnomesListFromDatabase()
        {
            string sql = @"Select Name, Beard, Evil, Temper, Rase from Gnome";


            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                var result = new List<Gnome>();

                while (reader.Read())
                {

                    var gnomes = new Gnome();
                    //string sql = @"Select Name, Beard, Evil, Temper, Rase from Gnome";
                    string name = reader.GetSqlString(0).Value;
                    string beard = reader.GetSqlString(1).Value;
                    string evil = reader.GetSqlString(2).Value;
                    int temper = reader.GetSqlInt32(3).Value;
                    string rase = reader.GetSqlString(4).Value;

                    gnomes.Name = name;
                    gnomes.Beard = beard;
                    gnomes.Evil = evil;
                    gnomes.Temper = temper;
                    gnomes.Rase = rase;


                    result.Add(gnomes);

                }

                return result;
            }
        }
    }
}
