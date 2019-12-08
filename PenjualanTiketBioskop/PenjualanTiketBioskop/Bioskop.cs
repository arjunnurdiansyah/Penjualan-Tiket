using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PenjualanTiketBioskop
{
    public partial class Bioskop : Form
    {
        //Connection DB
        string conn = "SERVER=localhost;" +
                "PORT=3306;" +
                "UID=root;" +
                "PASSWORD=;" +
                "DATABASE=test_excelsoft;" +
                "OLD GUIDS = true;";

        public Bioskop()
        {
            InitializeComponent();
        }

        string seleksiHurufVokal(string[] kata, int indeks)
        {
            string hasil = kata[indeks].ToLower().Replace('a', '|').Replace('i', '|').Replace('u', '|').Replace('e', '|').Replace('o', '|');
            return hasil;
        }

        string kodeBioskop(string kota, string nama, string alamat)
        {
            kota = tb_kotaBisokop.Text;
            nama = tb_namaBioskop.Text;
            alamat = tb_alamatBioskop.Text;
            string kode1 = "";
            string kode2 = "";
            string kode3 = "";
            
            string[] n = nama.Split(' ');
            kode1 = seleksiHurufVokal(n, 0);
            string[] a = alamat.Split(' ');
            kode2 = seleksiHurufVokal(a, 1);
            string[] k = kota.Split(' ');
            kode3 = seleksiHurufVokal(k, 0);

            string[] huruf1 = kode1.Split('|');
            string[] huruf2 = kode2.Split('|');
            string[] huruf3 = kode3.Split('|');

            for (int i = 0; i < huruf1.Length; i++)
            {
                if (huruf1[i] != "")
                {
                    kode1 = huruf1[i];
                    kode1 = kode1.Substring(0, 1);
                    break;
                }
            }
            for (int i = 0; i < huruf2.Length; i++)
            {
                if (huruf2[i] != "")
                {
                    kode2 = huruf2[i];
                    kode2 = kode2.Substring(0, 1);
                    break;
                }
            }
            for (int i = 0; i < huruf3.Length; i++)
            {
                if (huruf3[i] != "")
                {
                    kode3 = huruf3[i];
                    kode3 = kode3.Substring(0, 1);
                    break;
                }
            }
            return kode1 + kode2 + kode3;
        }

        private void btn_inputFilm_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = conn;

            string namaBioskop = tb_namaBioskop.Text;
            string alamatBioskop = tb_alamatBioskop.Text;
            string kotaBioskop = tb_kotaBisokop.Text;
            string kdBioskop = kodeBioskop(namaBioskop, alamatBioskop, kotaBioskop).ToUpper();

            string query = "INSERT INTO bioskop (kd_bioskop, nama_bioskop, alamat_bioskop, kota) VALUES " +
                "(@kdBioskop, @namaBioskop, @alamatBioskop, @kotaBioskop)";

            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@kdBioskop", kdBioskop);
                command.Parameters.AddWithValue("@namaBioskop", namaBioskop);
                command.Parameters.AddWithValue("@alamatBioskop", alamatBioskop);
                command.Parameters.AddWithValue("@kotaBioskop", kotaBioskop);

                MySqlDataReader reader = command.ExecuteReader();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Halaman_Utama hu = new Halaman_Utama();
            hu.Show();
            this.Hide();
        }
    }
}
