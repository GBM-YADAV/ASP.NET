//using System;
//using System.Collections.Generic;
//using System.Data.SqlClient;
//using System.Data;
//using System.Text;

//namespace ConsoleADO.Net
//{
//    internal class program2
//    {
//        public static object ReadOnly { get; private set; }

//        static void Main(string[] args)
//        {
//            try
//            {


//                SqlConnection con = new SqlConnection("Data Source=GIRIBABU;Initial Catalog=LTIDB;Integrated Security=True");

//                SqlCommand com = new SqlCommand();
//                com.Connection = con;

//                com.CommandText = "update Student set name=@name,marks=@marks where id=@id";
//                SqlParameter p1 = new SqlParameter("@name", SqlDbType.VarChar);

//                SqlParameter p= new SqlParameter("@id", SqlDbType.Int);
//                Console.WriteLine("enter id of student");
//                int id = Convert.ToInt32(Console.ReadLine());//// this is in c
//                p.Value = id;
//                com.Parameters.Add(p);

//                Console.WriteLine("enter  name of student");
//                String name = Console.ReadLine();//// this is in c
//                p1.Value = name;
//                com.Parameters.Add(p1);

//                //======= 
//                SqlParameter p2 = new SqlParameter("@marks", SqlDbType.Int);
//                Console.WriteLine("enter  marks of student");
//                int marks = Convert.ToInt32(Console.ReadLine());//// this is in c
//                p2.Value = marks;
//                com.Parameters.Add(p2);
//                con.Open();
//                com.ExecuteNonQuery();

//                Console.WriteLine("record inserted succuss fully");

//            }
//            catch (SqlException ex)
//            {
//                Console.WriteLine(ex.Message);
//            }

//             const int Acc= 1;

//            public readonly int a = 20;
//            int[] ar = { 1, 2, 3, 4, 5, };

//             Array.Sort(ar);

        
//        }


//    }
//}
