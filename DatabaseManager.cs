using Microsoft.Data.SqlClient;



namespace lab9
{
    public class DatabaseManager
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ola\source\repos\lab9\Database1.mdf";

        public void ReadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Users";
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int userId = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                        string userName = reader.IsDBNull(1) ? "" : reader.GetString(1);
                        string semestrIRok = reader.IsDBNull(2) ? "" : reader.GetString(2);
                        string kierunekIStopienStudiow = reader.IsDBNull(3) ? "" : reader.GetString(3);

                        Console.WriteLine($"User Id: {userId}, Name: {userName},Semestr i rok: {semestrIRok}, Kierunek i stopien:{kierunekIStopienStudiow}");
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        public void WriteData(int userId, string userName,string semestrIRok, string kierunekIStopienStudiow)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Users (Id, Name, SemestrIRok, KierunekIStopienStudiow) VALUES (@Id, @Name, @SemestrIRok, @KierunekIStopienStudiow)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", userId);
                command.Parameters.AddWithValue("@Name", userName);
                command.Parameters.AddWithValue("@SemestrIRok", semestrIRok);
                command.Parameters.AddWithValue("@KierunekIStopienStudiow", kierunekIStopienStudiow);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine($"{rowsAffected} row(s) inserted.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

    }
}
