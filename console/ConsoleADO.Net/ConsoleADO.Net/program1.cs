using System;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;

namespace ConsoleADO.Net
{
    internal class Program1
    {
        //static void Main(string[] args)
        //{
        //    try
        //    {


        //        SqlConnection con = new SqlConnection("Data Source=GIRIBABU;Initial Catalog=LTIDB;Integrated Security=True");

        //        SqlCommand com = new SqlCommand();
        //        com.Connection = con;

        //        com.CommandText="insert into Student(name,marks)values(@name,@marks)";
        //        SqlParameter p1=new SqlParameter("@name",SqlDbType.VarChar);

        //        Console.WriteLine("enter  name of student");
        //        String name= Console.ReadLine();//// this is in c
        //        p1.Value = name;
        //        com.Parameters.Add(p1);

        //        //======= 
        //        SqlParameter p2 = new SqlParameter("@marks", SqlDbType.Int);
        //        Console.WriteLine("enter  marks of student");
        //        int marks = Convert.ToInt32(Console.ReadLine());//// this is in c
        //        p2.Value = marks;
        //        com.Parameters.Add(p2);
        //        con.Open();
        //        com.ExecuteNonQuery();

        //        Console.WriteLine("record inserted succuss fully");

        //    }
        //    catch (SqlException ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}
    }
}