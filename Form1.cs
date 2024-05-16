namespace lab9
{
    public partial class Form1 : Form
    {
        DatabaseManager baza_danych = new DatabaseManager();
        public Form1()
        {
            InitializeComponent();
            Console.SetOut(new DebugTextWriter());
            //baza_danych.WriteData(12, "ola");
             baza_danych.ReadData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox_numer_albumu_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_nazwisko_i_imie_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_semestr_i_rok_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_kierunek_i_stopien_studiow_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_data1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_nazwa_przedmiotu_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_liczba_punktow_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_prowadzacy_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_uzasadnienie_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_czlonek_komisji1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_czlonek_komisji2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_czlonek_komisji3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_data_i_podpis_studenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_data2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_pieczatka_i_podpis_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_zapisz_wprowadzone_dane_Click(object sender, EventArgs e)
        {
            int userId = int.Parse(textBox_numer_albumu.Text); 
            string userName = textBox_nazwisko_i_imie.Text;
            string semestrIRok = textBox_semestr_i_rok.Text;
            string kierunekIStopienStudiow = textBox_kierunek_i_stopien_studiow.Text;
           // string data1 = textBox_data1.Text;
           // string nazwaPrzedmiotu = textBox5_nazwa_przedmiotu.Text;
           // int liczbaPunktow = int.Parse(textBox_liczba_punktow.Text);
           // string prowadzacy = textBox_prowadzacy.Text;
           // string uzasadnienie = textBox_uzasadnienie.Text;
           // string czlonekKomisji1 = textBox_czlonek_komisji1.Text;
           // string czlonekKomisji2 = textBox_czlonek_komisji2.Text;
           // string czlonekKomisji3 = textBox_czlonek_komisji3.Text;
           // string dataPodpisStudenta = textBox10_data_i_podpis_studenta.Text;
           // string data2 = textBox_data2.Text;
           // string pieczatkaIPodpis = textBox_pieczatka_i_podpis.Text;

            baza_danych.WriteData(userId, userName, semestrIRok, kierunekIStopienStudiow);
        }
    }
}
