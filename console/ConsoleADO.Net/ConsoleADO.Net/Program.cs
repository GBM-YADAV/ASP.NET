using System;
using System.Data;
using System.Data.SqlClient;
namespace ConsoleADO.Net
{
    internal class Program
    {
        static void main(string[] args)
        {
            try
            {


                SqlConnection con = new SqlConnection("data source=giribabu;initial catalog=ltidb;integrated security=true");

                SqlCommand com = new SqlCommand();
                com.Connection = con;

                com.CommandText = "select id,name,marks from student";
                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                
                foreach(SqlDataReader s in dr)// dr.read()  
                {
                    Console.WriteLine(s[0] + " " + s[1] + " " + s[2]);
                }

                con.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
