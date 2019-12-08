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
    public partial class Jadwal_Tayang : Form
    {
        //Connection DB
        string conn = "SERVER=localhost;" +
                "PORT=3306;" +
                "UID=root;" +
                "PASSWORD=;" +
                "DATABASE=test_excelsoft;" +
                "OLD GUIDS = true;";

        public Jadwal_Tayang()
        {
            InitializeComponent();
            namaBioskop();
            judulFilm();
        }

        void judulFilm()
        {
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = conn;

            string query = "SELECT judul_film FROM film";

            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cb_judulFilm.Items.Add(reader.GetString("judul_film"));
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        string kodeFilm(string judulFilm)
        {
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = conn;

            string kdFilm = "";
            string query = "SELECT kd_film FROM film WHERE judul_film = '"+ judulFilm+ "'";

            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    kdFilm = reader.GetString("kd_film");
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return kdFilm;
        }

        void namaBioskop()
        {
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = conn;

            string query = "SELECT CONCAT_WS(' ', nama_bioskop, kota) as bioskop FROM bioskop";

            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cb_bioskop.Items.Add(reader.GetString("bioskop"));
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        string kodeBioskop(string namaBioskop, string kota)
        {
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = conn;

            string kdBioskop = "";
            string query = "SELECT kd_bioskop FROM bioskop WHERE nama_bioskop LIKE '%"+ namaBioskop +"%' AND kota ='"+ kota +"'";

            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    kdBioskop = reader.GetString("kd_bioskop");
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return kdBioskop;
        }

        string urutanTayang(string kode)
        {
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = conn;

            string urutan = "";
            string query = "SELECT COUNT(kd_tayang)+1 as urutan_tayang FROM jadwal_tayang WHERE kd_tayang LIKE '" + kode + "%'";

            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    urutan = reader.GetString("urutan_tayang");
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            int urutanTyg = Int32.Parse(urutan);
            if (urutanTyg < 10)
            {
                urutan = "0000" + urutan;
            }
            else if (urutanTyg < 100)
            {
                urutan = "000" + urutan;
            }
            else if (urutanTyg < 1000)
            {
                urutan = "00" + urutan;
            }
            else if (urutanTyg < 10000)
            {
                urutan = "0" + urutan;
            }
            return urutan;
        }

        string kodeTayang()
        {
            string[] nb = cb_bioskop.Text.Split(' ');
            string namaBioskop = "";
            for (int i = 0; i < nb.Length-1; i++)
            {
                namaBioskop += nb[i];
                if (i < nb.Length - 2)
                {
                    namaBioskop += " ";
                }
            }
            string kdBioskop = kodeBioskop(namaBioskop, nb[nb.Length-1]);

            string kdt = dtp_tglTayang.Value.Day.ToString();
            kdt += dtp_tglTayang.Value.Month.ToString();
            kdt += dtp_tglTayang.Value.Year.ToString();

            string[] kj = cb_jamTayang.Text.Split(':');
            string kodeJam = kj[0] + kj[1];

            string kdFilm = kodeFilm(cb_judulFilm.Text);

            string kode = kdBioskop + kdt + kodeJam + kdFilm;
            string urutan = kode + urutanTayang(kode);
            kode = urutan;
            return kode;
        }

        private void btn_inputJamTayang_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = conn;

            string kdTayang = kodeTayang();
            string judulFilm = cb_judulFilm.Text;
            string tglDanWaktu = dtp_tglTayang.Value.Day.ToString()+"/";
            tglDanWaktu += dtp_tglTayang.Value.Month.ToString() + "/";
            tglDanWaktu += dtp_tglTayang.Value.Year.ToString()+" ";
            tglDanWaktu += cb_jamTayang.Text;
            string jmlKursi = tb_jmlKursi.Text;

            string query = "INSERT INTO jadwal_tayang (kd_tayang, judul_film, tgldanwaktu_tayang, jml_kursi) VALUES " +
                "(@kdTayang, @judulFilm, @tglDanWaktu, @jmlKursi)";

            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@kdTayang", kdTayang);
                command.Parameters.AddWithValue("@judulFilm", judulFilm);
                command.Parameters.AddWithValue("@tglDanWaktu", tglDanWaktu);
                command.Parameters.AddWithValue("@jmlKursi", jmlKursi);

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
            Halaman_Utama hl = new Halaman_Utama();
            hl.Show();
            this.Hide();
        }
    }
}
