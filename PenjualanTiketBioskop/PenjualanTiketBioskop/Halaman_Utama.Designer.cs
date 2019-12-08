namespace PenjualanTiketBioskop
{
    partial class Halaman_Utama
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_tmbhFilm = new System.Windows.Forms.Button();
            this.btn_tmbhBioskop = new System.Windows.Forms.Button();
            this.tmbh_penayangan = new System.Windows.Forms.Button();
            this.btn_beliTiketFilm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bioskop Kop Kop";
            // 
            // btn_tmbhFilm
            // 
            this.btn_tmbhFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tmbhFilm.Location = new System.Drawing.Point(88, 106);
            this.btn_tmbhFilm.Name = "btn_tmbhFilm";
            this.btn_tmbhFilm.Size = new System.Drawing.Size(103, 42);
            this.btn_tmbhFilm.TabIndex = 1;
            this.btn_tmbhFilm.Text = "Tambah Film";
            this.btn_tmbhFilm.UseVisualStyleBackColor = true;
            this.btn_tmbhFilm.Click += new System.EventHandler(this.btn_tmbhFilm_Click);
            // 
            // btn_tmbhBioskop
            // 
            this.btn_tmbhBioskop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tmbhBioskop.Location = new System.Drawing.Point(219, 106);
            this.btn_tmbhBioskop.Name = "btn_tmbhBioskop";
            this.btn_tmbhBioskop.Size = new System.Drawing.Size(103, 42);
            this.btn_tmbhBioskop.TabIndex = 2;
            this.btn_tmbhBioskop.Text = "Tambah Bioskop";
            this.btn_tmbhBioskop.UseVisualStyleBackColor = true;
            this.btn_tmbhBioskop.Click += new System.EventHandler(this.btn_tmbhBioskop_Click);
            // 
            // tmbh_penayangan
            // 
            this.tmbh_penayangan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tmbh_penayangan.Location = new System.Drawing.Point(351, 106);
            this.tmbh_penayangan.Name = "tmbh_penayangan";
            this.tmbh_penayangan.Size = new System.Drawing.Size(103, 42);
            this.tmbh_penayangan.TabIndex = 3;
            this.tmbh_penayangan.Text = "Tambah Penayangan";
            this.tmbh_penayangan.UseVisualStyleBackColor = true;
            this.tmbh_penayangan.Click += new System.EventHandler(this.tmbh_penayangan_Click);
            // 
            // btn_beliTiketFilm
            // 
            this.btn_beliTiketFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_beliTiketFilm.Location = new System.Drawing.Point(88, 171);
            this.btn_beliTiketFilm.Name = "btn_beliTiketFilm";
            this.btn_beliTiketFilm.Size = new System.Drawing.Size(366, 42);
            this.btn_beliTiketFilm.TabIndex = 4;
            this.btn_beliTiketFilm.Text = "Lihat Jadwal Penayangan FIlm";
            this.btn_beliTiketFilm.UseVisualStyleBackColor = true;
            this.btn_beliTiketFilm.Click += new System.EventHandler(this.btn_beliTiketFilm_Click);
            // 
            // Halaman_Utama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 258);
            this.Controls.Add(this.btn_beliTiketFilm);
            this.Controls.Add(this.tmbh_penayangan);
            this.Controls.Add(this.btn_tmbhBioskop);
            this.Controls.Add(this.btn_tmbhFilm);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Halaman_Utama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Halaman Utama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_tmbhFilm;
        private System.Windows.Forms.Button btn_tmbhBioskop;
        private System.Windows.Forms.Button tmbh_penayangan;
        private System.Windows.Forms.Button btn_beliTiketFilm;
    }
}