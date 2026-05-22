using Npgsql;

namespace raschetka2._0
{
    public class open_connection_atd
    {
        public List<string> combobox_items { get; set; } = new List<string>();
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

        public static open_connection_atd connect_or_create(string what_should_i_do)
        {
            var to = new open_connection_atd();
            using (NpgsqlConnection connection_to_db = new NpgsqlConnection($"Host={data_for_connection.host};" +
                $"Port={data_for_connection.port};" +
                $"Username={data_for_connection.username};" +
                $"Password={data_for_connection.password};" +
                $"Database=postgres"))
            {
                connection_to_db.Open();
                switch (what_should_i_do)
                {
                    case "view":
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
                        break;
                    case "create":
                        using (NpgsqlCommand command = new NpgsqlCommand($"CREATE DATABASE \"{data_for_connection.database}\"", connection_to_db))
                        {
                            command.ExecuteNonQuery();
                        }
                        break;
                }
                return to;
            }
        }

    }
}
