namespace PenjualanTiketBioskop
{
    partial class Jadwal_Tayang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_inputJamTayang = new System.Windows.Forms.Button();
            this.dtp_tglTayang = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.tb_jmlKursi = new System.Windows.Forms.TextBox();
            this.cb_judulFilm = new System.Windows.Forms.ComboBox();
            this.cb_jamTayang = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_bioskop = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(12, 275);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(75, 23);
            this.btn_home.TabIndex = 17;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_inputJamTayang
            // 
            this.btn_inputJamTayang.Location = new System.Drawing.Point(381, 233);
            this.btn_inputJamTayang.Name = "btn_inputJamTayang";
            this.btn_inputJamTayang.Size = new System.Drawing.Size(106, 23);
            this.btn_inputJamTayang.TabIndex = 16;
            this.btn_inputJamTayang.Text = "Input Jam Tayang";
            this.btn_inputJamTayang.UseVisualStyleBackColor = true;
            this.btn_inputJamTayang.Click += new System.EventHandler(this.btn_inputJamTayang_Click);
            // 
            // dtp_tglTayang
            // 
            this.dtp_tglTayang.Location = new System.Drawing.Point(183, 138);
            this.dtp_tglTayang.Name = "dtp_tglTayang";
            this.dtp_tglTayang.Size = new System.Drawing.Size(304, 20);
            this.dtp_tglTayang.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tanggal Tayang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Pilih Film";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Input Jam Tayang Film";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(64, 210);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(66, 13);
            this.label33.TabIndex = 18;
            this.label33.Text = "Jumlah Kursi";
            // 
            // tb_jmlKursi
            // 
            this.tb_jmlKursi.Location = new System.Drawing.Point(183, 207);
            this.tb_jmlKursi.Name = "tb_jmlKursi";
            this.tb_jmlKursi.Size = new System.Drawing.Size(304, 20);
            this.tb_jmlKursi.TabIndex = 19;
            // 
            // cb_judulFilm
            // 
            this.cb_judulFilm.FormattingEnabled = true;
            this.cb_judulFilm.Location = new System.Drawing.Point(183, 106);
            this.cb_judulFilm.Name = "cb_judulFilm";
            this.cb_judulFilm.Size = new System.Drawing.Size(304, 21);
            this.cb_judulFilm.TabIndex = 20;
            // 
            // cb_jamTayang
            // 
            this.cb_jamTayang.FormattingEnabled = true;
            this.cb_jamTayang.Items.AddRange(new object[] {
            "11:45",
            "13:15",
            "14:15",
            "15:45",
            "16:45",
            "18:15",
            "19:15",
            "20:45",
            "21:45"});
            this.cb_jamTayang.Location = new System.Drawing.Point(183, 171);
            this.cb_jamTayang.Name = "cb_jamTayang";
            this.cb_jamTayang.Size = new System.Drawing.Size(304, 21);
            this.cb_jamTayang.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Jam Tayang";
            // 
            // cb_bioskop
            // 
            this.cb_bioskop.FormattingEnabled = true;
            this.cb_bioskop.Location = new System.Drawing.Point(183, 70);
            this.cb_bioskop.Name = "cb_bioskop";
            this.cb_bioskop.Size = new System.Drawing.Size(304, 21);
            this.cb_bioskop.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 73);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Pilih Bioskop";
            // 
            // Jadwal_Tayang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 310);
            this.Controls.Add(this.cb_bioskop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_jamTayang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_judulFilm);
            this.Controls.Add(this.tb_jmlKursi);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_inputJamTayang);
            this.Controls.Add(this.dtp_tglTayang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Jadwal_Tayang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jadwal_Tayang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_inputJamTayang;
        private System.Windows.Forms.DateTimePicker dtp_tglTayang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox tb_jmlKursi;
        private System.Windows.Forms.ComboBox cb_judulFilm;
        private System.Windows.Forms.ComboBox cb_jamTayang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_bioskop;
        private System.Windows.Forms.Label label5;
    }
}