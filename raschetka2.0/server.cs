using Npgsql;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace raschetka2._0
{
    public class open_connection_atd
    {
        public List<string> combobox_items = new List<string>();
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
        public System.Data.DataTable цех = new System.Data.DataTable();
        public System.Data.DataTable сотрудники = new System.Data.DataTable();
    }
    public class data_цех
    {
        public string ceh_name;
        public string ceh_admin;
        public string production;
        public string phone_number;
        public string adres;
    }
    public class data_сотрудник
    {
        public string ceh_name;
        public string name;
        public string surname;
        public string father_name;
        public string dolznost;
        public string oklad;
        public string phone_number;
        public string adres;
    }
    public static class server
    {

        public static async Task<open_connection_atd> connect_or_create(string what_should_i_do)
        {
            var to = new open_connection_atd();
            using (NpgsqlConnection connection_to_db = new NpgsqlConnection($"Host={data_for_connection.host};" +
                $"Port={data_for_connection.port};" +
                $"Username={data_for_connection.username};" +
                $"Password={data_for_connection.password};" +
                $"Database=postgres"))
            {
                await connection_to_db.OpenAsync();
                switch (what_should_i_do)
                {
                    case "view":
                        using (NpgsqlCommand get_db_name = new NpgsqlCommand("SELECT datname FROM pg_database WHERE datistemplate = false AND datname != 'postgres' ORDER BY datname", connection_to_db))
                        {
                            using (NpgsqlDataReader reader = await get_db_name.ExecuteReaderAsync())
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
                            await command.ExecuteNonQueryAsync();
                        }
                        break;
                }
                return to;
            }
        }
        public static async Task<data_for_dgv> open_db(string what_a_dgv)
        {
            var enter_data = new data_for_dgv();
            data_for_connection.connection = $"Host={data_for_connection.host};" +
                $"Port={data_for_connection.port};" +
                $"Username={data_for_connection.username};" +
                $"Password={data_for_connection.password};" +
                $"Database={data_for_connection.database}";
            using (NpgsqlConnection connection = new NpgsqlConnection(data_for_connection.connection))
            {
                await connection.OpenAsync();
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
                            await command.ExecuteNonQueryAsync();
                        using (NpgsqlCommand selet_цех = new NpgsqlCommand($"SELECT * FROM Цех", connection))
                        using (var read_цех = await selet_цех.ExecuteReaderAsync())
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
                            await command.ExecuteNonQueryAsync();
                            using (NpgsqlCommand selet_сотрудники = new NpgsqlCommand($"SELECT * FROM Сотрудники", connection))
                            using (var read_сотрудники = await selet_сотрудники.ExecuteReaderAsync())
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
        public static async void add_цех(string ceh_name,
        string ceh_admin,
        string production,
        string phone_number,
        string adres)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(data_for_connection.connection))
            {
                await connection.OpenAsync();
                using (NpgsqlCommand command = new NpgsqlCommand("INSERT INTO Цех " +
                        "(Название_цеха," +
                        "Начальник_цеха," +
                        "Продукция," +
                        "Телефон," +
                        "Адрес)" +
                        "Values (@1,@2,@3,@4,@5)", connection))
                {
                    command.Parameters.AddWithValue("@1", ceh_name);
                    command.Parameters.AddWithValue("@2", ceh_admin);
                    command.Parameters.AddWithValue("@3", production);
                    command.Parameters.AddWithValue("@4", phone_number);
                    command.Parameters.AddWithValue("@5", adres);
                    await command.ExecuteNonQueryAsync();
                }
            }
        }
        public static async void add_сотрудник(string ceh_name,
        string name,
        string surname,
        string father_name,
        string dolznost,
        string oklad,
        string phone_number,
        string adres)
        {
            using (var connection = new NpgsqlConnection(data_for_connection.connection))
            {
                await connection.OpenAsync();
                using (var command = new NpgsqlCommand("INSERT INTO Сотрудники " +
                        "(Название_цеха," +
                        "Фамилия," +
                        "Имя," +
                        "Отчество," +
                        "Должность, " +
                        "Оклад, " +
                        "Телефон, " +
                        "Адрес )" +
                        "Values (@1,@3,@2,@4,@5, @6, @7, @8)", connection))
                {
                    command.Parameters.AddWithValue("@2", name);
                    command.Parameters.AddWithValue("@3", surname);
                    command.Parameters.AddWithValue("@4", father_name);
                    command.Parameters.AddWithValue("@5", dolznost);
                    command.Parameters.AddWithValue("@1", ceh_name);
                    command.Parameters.AddWithValue("@6", oklad);
                    command.Parameters.AddWithValue("@7", phone_number);
                    command.Parameters.AddWithValue("@8", adres);
                    await command.ExecuteNonQueryAsync();
                }
            }
        }
        public static async void delete_zap(string delete_id, string table)
        {
            using (var connection = new NpgsqlConnection(data_for_connection.connection))
            {
                await connection.OpenAsync();
                switch (table)
                {
                    case "цех":
                        using (var command = new NpgsqlCommand($"DELETE FROM Цех WHERE Счётчик_цеха = {delete_id}",connection))
                            await command.ExecuteNonQueryAsync();
                        break;
                    case "сотрудник":
                        using (var command = new NpgsqlCommand($"DELETE FROM Сотрудники WHERE Счётчик_сотрудника = {delete_id}", connection))
                            await command.ExecuteNonQueryAsync();
                        break;
                }
            }
        }
        public static async Task<data_for_dgv> change_table(string id, string table, data_цех data, data_сотрудник data2)
        {
            using (var connection = new NpgsqlConnection(data_for_connection.connection))
            {
                await connection.OpenAsync();
                switch (table)
                {
                    case "цех":
                        using (var command = new NpgsqlCommand("UPDATE Цех SET " +
                    "Название_цеха = @2," +
                    "Начальник_цеха = @3," +
                    "Продукция = @4," +
                    "Телефон = @5," +
                    "Адрес = @6 " +
                    $" WHERE Счётчик_цеха = @1 ", connection))
                        {
                            command.Parameters.AddWithValue("@1", int.Parse(id));
                            command.Parameters.AddWithValue("@2", data.ceh_name);
                            command.Parameters.AddWithValue("@3", data.ceh_admin);
                            command.Parameters.AddWithValue("@4", data.production);
                            command.Parameters.AddWithValue("@5", data.phone_number);
                            command.Parameters.AddWithValue("@6", data.adres);
                            await command.ExecuteNonQueryAsync();
                        }
                        break;
                    case "сотрудники":
                        using (var command = new NpgsqlCommand("UPDATE Сотрудники SET " +
                        "Название_цеха = @1," +
                        "Фамилия=@3," +
                        "Имя=@2," +
                        "Отчество=@4," +
                        "Должность=@5, " +
                        "Оклад=@6, " +
                        "Телефон=@7, " +
                        "Адрес=@8 " +
                        " WHERE Счётчик_сотрудника = @9", connection))
                        {
                            command.Parameters.AddWithValue("@9", int.Parse(id));
                            command.Parameters.AddWithValue("@2", data2.name);
                            command.Parameters.AddWithValue("@3", data2.surname);
                            command.Parameters.AddWithValue("@4", data2.father_name);
                            command.Parameters.AddWithValue("@5", data2.dolznost);
                            command.Parameters.AddWithValue("@1", data2.ceh_name);
                            command.Parameters.AddWithValue("@6", data2.oklad);
                            command.Parameters.AddWithValue("@7", data2.phone_number);
                            command.Parameters.AddWithValue("@8", data2.adres);
                            await command.ExecuteNonQueryAsync();
                        }
                        break;
                }
            }
            return await open_db(table);
        }

    }
}
