using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace dbconnexample
{
    internal class db
    {
        private string conn = "Server=localhost;Database=mysql_dbname;User Id=mysql_username;Password=mysql_password";


        public int Update(int id, string name, string email, int age)
        {
            int row = 0;

            using (MySqlConnection connection = new MySqlConnection(conn)) 
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE users SET name=@name, email=@email, age=@age WHERE id=@ID";

                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@age", age);
                    cmd.Parameters.AddWithValue("@ID", id);

                    row = cmd.ExecuteNonQuery();
                }
                catch (Exception ex) 
                {
                    Console.WriteLine(ex.ToString());
                }
            }


            return row;
        }


        public string[] select_one(int id) 
        {
            string[] datas = null;

            string query = "SELECT * FROM users WHERE id=@ID";

            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ID", id);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) 
                            {
                                int columnCount = reader.FieldCount;
                                datas = new string[columnCount];

                                for (int i = 0; i < columnCount; i++) 
                                {
                                    datas[i] = reader[i].ToString();
                                }
                            }
                        }
                    }
                }
                catch (Exception ex) 
                {
                    Console.WriteLine(ex.Message);    
                }
            }
            return datas;
        }


        public int delete(int id)
        {
            int row = 0;

            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                try
                {
                    connection.Open();

                    string query = "DELETE FROM users WHERE id=@ID";

                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@ID", id);
                    

                    row = cmd.ExecuteNonQuery();
                    return row;
                }
                catch (Exception ex) 
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return row;
        }


        public int insert(string name, string email, int age)
        {
            int row = 0;
            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO users(name,email,age) VALUES(@name,@email,@age)";

                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@age", age);

                    row = cmd.ExecuteNonQuery();
                    return row;
                }
                catch (Exception ex) 
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return row;
        }

        public DataTable Load()
        {
            DataTable table = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM users";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);

                    adapter.Fill(table);
                    
                }
                catch (Exception ex) 
                { 
                    Console.WriteLine(ex.Message);
                }
            }

            return table;
        }
    }
}
