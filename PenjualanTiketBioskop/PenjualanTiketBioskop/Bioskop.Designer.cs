namespace PenjualanTiketBioskop
{
    partial class Bioskop
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
            this.btn_inputFilm = new System.Windows.Forms.Button();
            this.tb_namaBioskop = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_alamatBioskop = new System.Windows.Forms.TextBox();
            this.tb_kotaBisokop = new System.Windows.Forms.TextBox();
            this.btn_home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_inputFilm
            // 
            this.btn_inputFilm.Location = new System.Drawing.Point(389, 159);
            this.btn_inputFilm.Name = "btn_inputFilm";
            this.btn_inputFilm.Size = new System.Drawing.Size(85, 23);
            this.btn_inputFilm.TabIndex = 15;
            this.btn_inputFilm.Text = "Input Bioskop";
            this.btn_inputFilm.UseVisualStyleBackColor = true;
            this.btn_inputFilm.Click += new System.EventHandler(this.btn_inputFilm_Click);
            // 
            // tb_namaBioskop
            // 
            this.tb_namaBioskop.Location = new System.Drawing.Point(170, 71);
            this.tb_namaBioskop.Name = "tb_namaBioskop";
            this.tb_namaBioskop.Size = new System.Drawing.Size(304, 20);
            this.tb_namaBioskop.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Kota Bioskop";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Alamat Bioskop";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nama Bioskop";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Input Bioskop";
            // 
            // tb_alamatBioskop
            // 
            this.tb_alamatBioskop.Location = new System.Drawing.Point(170, 101);
            this.tb_alamatBioskop.Name = "tb_alamatBioskop";
            this.tb_alamatBioskop.Size = new System.Drawing.Size(304, 20);
            this.tb_alamatBioskop.TabIndex = 16;
            // 
            // tb_kotaBisokop
            // 
            this.tb_kotaBisokop.Location = new System.Drawing.Point(170, 133);
            this.tb_kotaBisokop.Name = "tb_kotaBisokop";
            this.tb_kotaBisokop.Size = new System.Drawing.Size(304, 20);
            this.tb_kotaBisokop.TabIndex = 17;
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(12, 178);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(75, 23);
            this.btn_home.TabIndex = 18;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // Bioskop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 213);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.tb_kotaBisokop);
            this.Controls.Add(this.tb_alamatBioskop);
            this.Controls.Add(this.btn_inputFilm);
            this.Controls.Add(this.tb_namaBioskop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bioskop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bioskop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_inputFilm;
        private System.Windows.Forms.TextBox tb_namaBioskop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_alamatBioskop;
        private System.Windows.Forms.TextBox tb_kotaBisokop;
        private System.Windows.Forms.Button btn_home;
    }
}