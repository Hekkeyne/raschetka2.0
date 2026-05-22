using Npgsql;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace raschetka2._0
{
    public class open_connection_atd
    {
        public List<string> combobox_items { get; set; }= new List<string>();
    }
    public static class data_for_connection
    {
        public static string host;
        public static string port;
        public static string username;
        public static string password;
        public static string database;
    }
    public static class server
    {
        
        public static open_connection_atd conny(string host, int port, string user, string pass)
        {
            var to = new open_connection_atd();
            using (NpgsqlConnection connection_to_db = new NpgsqlConnection($"Host={host};" +
                $"Port={port};" +
                $"Username={user};" +
                $"Password={pass};" +
                $"Database=postgres"))
            {
                connection_to_db.Open();
                using (NpgsqlCommand get_db_name = new NpgsqlCommand("SELECT datname FROM pg_database WHERE datistemplate = false AND datname != 'postgres' ORDER BY datname", connection_to_db))
                {
                    using (NpgsqlDataReader reader = get_db_name.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            to.combobox_items.Add(reader.GetString(0));
                        }
                    }
                }
                
            }
            return to;
        }
    }
}
