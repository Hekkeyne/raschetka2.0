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
        public static string connection;
    }
    public class data_for_dgv
    {
        public System.Data.DataTable цех { get; set; } = new System.Data.DataTable();
        public System.Data.DataTable сотрудники { get; set; } = new System.Data.DataTable();

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
        public static data_for_dgv open_db(string what_a_dgv)
        {
            var enter_data = new data_for_dgv();
            data_for_connection.connection = $"Host={data_for_connection.host};" +
                $"Port={data_for_connection.port};" +
                $"Username={data_for_connection.username};" +
                $"Password={data_for_connection.password};" +
                $"Database={data_for_connection.database}";
            using (NpgsqlConnection connection = new NpgsqlConnection(data_for_connection.connection))
            {
                connection.Open();
                switch (what_a_dgv)
                {
                    case "цех":
                        using (NpgsqlCommand command = new NpgsqlCommand(
                    $@"CREATE TABLE IF NOT EXISTS Цех (Счётчик_цеха SERIAL PRIMARY KEY," +
                    $"Название_цеха TEXT NOT NULL," +
                    $"Начальник_цеха TEXT NOT NULL," +
                    $"Продукция TEXT NOT NULL," +
                    $"Телефон TEXT NOT NULL," +
                    $"Адрес TEXT NOT NULL)", connection))
                            command.ExecuteNonQuery();
                        using (NpgsqlCommand selet_цех = new NpgsqlCommand($"SELECT * FROM Цех", connection))
                        using (var read_цех = selet_цех.ExecuteReader())
                        {
                            var table_цех = new System.Data.DataTable();
                            table_цех.Load(read_цех);
                            enter_data.цех = table_цех;
                        }

                        break;

                    case "сотрудники":
                        using (NpgsqlCommand command = new NpgsqlCommand(
                    $@"CREATE TABLE IF NOT EXISTS Сотрудники (Счётчик_сотрудника SERIAL PRIMARY KEY," +
                    $"Название_цеха TEXT NOT NULL," +
                    $"Фамилия TEXT NOT NULL," +
                    $"Имя TEXT NOT NULL," +
                    $"Отчество TEXT," +
                    $"Должность TEXT NOT NULL," +
                    $"Оклад TEXT NOT NULL," +
                    $"Телефон TEXT NOT NULL," +
                    $"Адрес TEXT NOT NULL)", connection))
                        {
                            command.ExecuteNonQuery();
                            using (NpgsqlCommand selet_сотрудники = new NpgsqlCommand($"SELECT * FROM Сотрудники", connection))
                            using (var read_сотрудники = selet_сотрудники.ExecuteReader())
                            {
                                var table_сотрудники = new System.Data.DataTable();
                                table_сотрудники.Load(read_сотрудники);
                                enter_data.сотрудники = table_сотрудники;
                            }
                            break;
                        }
                }
            }
            return enter_data;
        }
    }
}
