using System;
using System.Collections.Generic;
using System.Text;

using MySql.Data.MySqlClient;

namespace Server
{
    internal class Database
    {
        public void getAllQuizzes()
        {
            string connetionString = null;
            MySqlConnection conn;
            connetionString = "server=localhost;database=game;uid=root;pwd=123456";
            conn = new MySqlConnection(connetionString);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();

                string sql = "SELECT * FROM quizzes";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Console.WriteLine(rdr[0] + " -- " + rdr[1] + " -- " + rdr[2] + " -- " + rdr[3] + " -- " + rdr[4]);
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            conn.Close();
            Console.WriteLine("Done.");
        }
    }
}
