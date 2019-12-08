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
    public partial class Film : Form
    {
        //Connection DB
        string conn = "SERVER=localhost;" +
                "PORT=3306;" +
                "UID=root;" +
                "PASSWORD=;" +
                "DATABASE=test_excelsoft;" +
                "OLD GUIDS = true;";

        public Film()
        {
            InitializeComponent();
        }

        string seleksiHurufVokal(string[] kata, int indeks)
        {
            string hasil = kata[indeks].ToLower().Replace('a','|').Replace('i','|').Replace('u','|').Replace('e', '|').Replace('o', '|');
            return hasil;
        }

        string kodeFilm(string judulFilm)
        {
            judulFilm = tb_judulFilm.Text;

            string[] kalimat = judulFilm.Split(' ');

            string kode1 = "";
            string kode2 = "";

            if (kalimat.Length == 1)
            {
                string kata1 = seleksiHurufVokal(kalimat, 0);
                string[] huruf1 = kata1.Split('|');
                string konsonan = "";
                int jmlKonsonan = 0;
                int stop = 0;

                for (int i = 0; i < huruf1.Length; i++)
                {
                    if (huruf1[i] != "")
                    {
                        jmlKonsonan += 1;
                        string temp = huruf1[i];
                        konsonan = huruf1[i];
                    }
                }

                if (jmlKonsonan == 1)
                {
                    kode1 = konsonan.Substring(0,1);
                    string gantiKonsonan = kalimat[0].Replace(konsonan,"|");
                    string[] vokal = gantiKonsonan.Split('|');
                    for (int i = 0; i < vokal.Length; i++)
                    {
                        if (vokal[i] != "")
                        {
                            kode2 = vokal[i];
                            kode2 = kode2.Substring(0,1);
                            break;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < huruf1.Length; i++)
                    {
                        if (huruf1[i] != "" && stop == 0)
                        {
                            kode1 = huruf1[i];
                            kode1 = kode1.Substring(0, 1);
                            stop = 1;
                        }
                        else if (huruf1[i] != "" && stop == 1)
                        {
                            kode2 = huruf1[i];
                            kode2 = kode2.Substring(0, 1);
                        }
                    }
                }
            }
            else if (kalimat.Length == 2)
            {
                string kata1 = seleksiHurufVokal(kalimat, 0);
                string kata2 = seleksiHurufVokal(kalimat, 1);
                string[] huruf1 = kata1.Split('|');
                string[] huruf2 = kata2.Split('|');
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
            }
            else if (kalimat.Length > 2)
            {
                string kata1 = seleksiHurufVokal(kalimat, 0);
                string kata2 = seleksiHurufVokal(kalimat, kalimat.Length-1);
                string[] huruf1 = kata1.Split('|');
                string[] huruf2 = kata2.Split('|');
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
            } 
            return kode1+kode2;
        }

        string urutanFilm(string kode)
        {
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = conn;

            string urutan = "";
            string query1 = "SELECT COUNT(kd_film)+1 as urutan_film FROM film WHERE kd_film LIKE '" + kode + "%'";

            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query1, connection);

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    urutan = reader.GetString("urutan_film");
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            int urutanFilm = Int32.Parse(urutan);
            if (urutanFilm < 10)
            {
                urutan = "00" + urutan;
            }
            else if (urutanFilm < 100)
            {
                urutan = "0" + urutan;
            }
            return urutan;
        }

        private void btn_inputFilm_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = conn;

            string kdFilm = tb_judulFilm.Text;
            string judulFilm = tb_judulFilm.Text;
            DateTime tglLaunch = dtp_tglLaunch.Value.ToLocalTime();
            string sinopsis = rtb_synopsis.Text;

            string kode = kodeFilm(kdFilm).ToUpper();
            kode += urutanFilm(kode);

            string query = "INSERT INTO film (kd_film, judul_film, tgl_launch, synopsis) VALUES " +
                "(@kode, @judulFilm, @tglLaunch, @sinopsis)";

            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@kode", kode);
                command.Parameters.AddWithValue("@judulFilm", judulFilm);
                command.Parameters.AddWithValue("@tglLaunch", tglLaunch);
                command.Parameters.AddWithValue("@sinopsis", sinopsis);

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
