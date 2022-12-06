using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MySql.Data.MySqlClient;

namespace Server
{
    internal class Database
    {
        private List<string> quizzes = new List<string>();
        public void readAllQuizzes ()
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
                    string quiz = rdr[1].ToString() + "~" + rdr[2].ToString() + "~" + rdr[3].ToString() + "~" + rdr[4].ToString() + "~" + rdr[5].ToString();
                    quizzes.Add(quiz);
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
        public List<string> getAllQuizzes()
        {
            foreach(string quiz in quizzes)
            {
                Console.WriteLine(quiz);
            }
            return quizzes;
        }
        public List<string> getRandomQuizzes(int amount)
        {  
            Random rnd = new Random();
            List<string> subQuizzes = quizzes.OrderBy(x => rnd.Next()).Take(amount).ToList();
            foreach (string quiz in subQuizzes)
            {
                Console.WriteLine(quiz);
            }
            return subQuizzes;
        }
    }
}
