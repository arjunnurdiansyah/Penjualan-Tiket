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
    public partial class Halaman_Utama : Form
    {
        //Connection DB
        string conn = "SERVER=localhost;" +
                "PORT=3306;" +
                "UID=root;" +
                "PASSWORD=;" +
                "DATABASE=test_excelsoft;" +
                "OLD GUIDS = true;";

        public Halaman_Utama()
        {
            InitializeComponent();
        }

        private void btn_tmbhFilm_Click(object sender, EventArgs e)
        {
            Film f = new Film();
            f.Show();
            this.Hide();
        }

        private void btn_tmbhBioskop_Click(object sender, EventArgs e)
        {
            Bioskop b = new Bioskop();
            b.Show();
            this.Hide();
        }

        private void tmbh_penayangan_Click(object sender, EventArgs e)
        {
            Jadwal_Tayang jt = new Jadwal_Tayang();
            jt.Show();
            this.Hide();
        }

        private void btn_beliTiketFilm_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = conn;
            string query = "SELECT CONCAT_WS(' ', id_tayang, kd_tayang, judul_film, tgldanwaktu_tayang, jml_kursi) as tayang FROM jadwal_tayang";

            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    MessageBox.Show(reader.GetString("tayang"));
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
