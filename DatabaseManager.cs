using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;



namespace lab9
{
    public class DatabaseManager
    {
private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Database1.mdf";
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
                        string data1 = reader.IsDBNull(4) ? "" : reader.GetString(4);
                        string nazwaPrzedmiotu = reader.IsDBNull(5) ? "" : reader.GetString(5);
                        int liczbaPunktow = reader.IsDBNull(6) ? 0 : reader.GetInt32(6);
                        string prowadzacy = reader.IsDBNull(7) ? "" : reader.GetString(7);
                        string uzasadnienie = reader.IsDBNull(8) ? "" : reader.GetString(8);
                        string czlonekKomisji1 = reader.IsDBNull(9) ? "" : reader.GetString(9);
                        string czlonekKomisji2 = reader.IsDBNull(10) ? "" : reader.GetString(10);
                        string czlonekKomisji3 = reader.IsDBNull(11) ? "" : reader.GetString(11);
                        string dataPodpisStudenta = reader.IsDBNull(12) ? "" : reader.GetString(12);
                        string data2 = reader.IsDBNull(13) ? "" : reader.GetString(13);
                        string pieczatkaIPodpis = reader.IsDBNull(14) ? "" : reader.GetString(14);

                        Console.WriteLine($"User Id: {userId}, Name: {userName}, Semestr i Rok: {semestrIRok}, Kierunek i Stopień Studiów: {kierunekIStopienStudiow}, Data1: {data1}, Nazwa Przedmiotu: {nazwaPrzedmiotu}, Liczba Punktów: {liczbaPunktow}, Prowadzący: {prowadzacy}, Uzasadnienie: {uzasadnienie}, Członek Komisji 1: {czlonekKomisji1}, Członek Komisji 2: {czlonekKomisji2}, Członek Komisji 3: {czlonekKomisji3}, Data i Podpis Studenta: {dataPodpisStudenta}, Data2: {data2}, Pieczątka i Podpis: {pieczatkaIPodpis}");
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        public void WriteData(int userId, string userName,string semestrIRok, string kierunekIStopienStudiow, string data1, string nazwaPrzedmiotu, int liczbaPunktow, string prowadzacy, string uzasadnienie, string czlonekKomisji1, string czlonekKomisji2, string czlonekKomisji3, string dataPodpisStudenta, string data2, string pieczatkaIPodpis)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Users (Id, Name, SemestrIRok, KierunekIStopienStudiow, Data1, nazwaPrzedmiotu, liczbaPunktow, prowadzacy, uzasadnienie, czlonekKomisji1, czlonekKomisji2, czlonekKomisji3, dataPodpisStudenta, data2, pieczatkaIPodpis) VALUES (@Id, @Name, @SemestrIRok, @KierunekIStopienStudiow, @Data1,  @NazwaPrzedmiotu, @LiczbaPunktow, @Prowadzacy, @Uzasadnienie, @CzlonekKomisji1, @CzlonekKomisji2, @CzlonekKomisji3, @DataPodpisStudenta, @Data2, @PieczatkaIPodpis)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", userId);
                command.Parameters.AddWithValue("@Name", userName);
                command.Parameters.AddWithValue("@SemestrIRok", semestrIRok);
                command.Parameters.AddWithValue("@KierunekIStopienStudiow", kierunekIStopienStudiow);
                command.Parameters.AddWithValue("@Data1", data1);
                command.Parameters.AddWithValue("@NazwaPrzedmiotu", nazwaPrzedmiotu);
                command.Parameters.AddWithValue("@LiczbaPunktow", liczbaPunktow);
                command.Parameters.AddWithValue("@Prowadzacy", prowadzacy);
                command.Parameters.AddWithValue("@Uzasadnienie", uzasadnienie);
                command.Parameters.AddWithValue("@CzlonekKomisji1", czlonekKomisji1);
                command.Parameters.AddWithValue("@CzlonekKomisji2", czlonekKomisji2);
                command.Parameters.AddWithValue("@CzlonekKomisji3", czlonekKomisji3);
                command.Parameters.AddWithValue("@DataPodpisStudenta", dataPodpisStudenta);
                command.Parameters.AddWithValue("@Data2", data2);
                command.Parameters.AddWithValue("@PieczatkaIPodpis", pieczatkaIPodpis);

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
