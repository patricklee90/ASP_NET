using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Week3_6_Control_Database_with_C
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a string to connect database
            string connectString =
                "Server = 14.0.1000;" +
                "Database = Teaching;"; // connection string
            //create the connection object
            SqlConnection conn = new SqlConnection(connectString);

            //input the data
            Console.WriteLine("insert data");
            //Student Structure
            //sclass,snumb,sname,sgender,sbirthday,sage,province
            string sql = "INSERT into student" +
                "values('Environment','h002','wang hai ying','Male','1996-1-1',20,'Pahang')";

            //Open Connection String
            conn.Open();

            //Create SQL command object
            SqlCommand comm = new SqlCommand();
            comm.Connection = conn; // lock the object connection
            // lock the SQL term
            comm.CommandText = sql;

            // control sql word
            try
            {
                int count = comm.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("insert data failed");
            }
            conn.Close();

            //use data read dataset
            // using System.Data

            Console.WriteLine("Use data read dataset");

            // Check Dataset
            Console.WriteLine("Check Dataset");
            sql = "SELECT * FROM Student" +
                "WHERE sclass = 'Environment'";

            comm.CommandText = sql;
            // operate sql command
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                Console.Write(reader[0]+ " " +
                    reader[1] + " " +
                    reader[2] + " " +
                    reader[3] + " " +
                    reader[4] + "\n");
            }

            reader.Close();
            conn.Close();

            // operation another query
            Console.WriteLine("Operate another query");
            sql = "SELECT * FROM Student" +
                "WHERE sclass='Electric61'";

            conn.Open();
            comm.CommandText = sql;
            reader = comm.ExecuteReader();
            while (reader.Read())
            {
                Console.Write(reader["sclass"] + " " +
                    reader["snumb"] + " " +
                    reader["sname"] + " " +
                    reader["sgender"] + " " +
                    reader["sage"] + "\n");
            }
            reader.Close();
            conn.Close();
        }
    }
}
