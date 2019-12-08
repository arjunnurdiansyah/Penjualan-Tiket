namespace PenjualanTiketBioskop
{
    partial class Film
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_judulFilm = new System.Windows.Forms.TextBox();
            this.rtb_synopsis = new System.Windows.Forms.RichTextBox();
            this.dtp_tglLaunch = new System.Windows.Forms.DateTimePicker();
            this.btn_inputFilm = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Film";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Judul FIlm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tanggal Launch";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Synopsis";
            // 
            // tb_judulFilm
            // 
            this.tb_judulFilm.Location = new System.Drawing.Point(165, 66);
            this.tb_judulFilm.Name = "tb_judulFilm";
            this.tb_judulFilm.Size = new System.Drawing.Size(304, 20);
            this.tb_judulFilm.TabIndex = 4;
            // 
            // rtb_synopsis
            // 
            this.rtb_synopsis.Location = new System.Drawing.Point(165, 131);
            this.rtb_synopsis.Name = "rtb_synopsis";
            this.rtb_synopsis.Size = new System.Drawing.Size(304, 124);
            this.rtb_synopsis.TabIndex = 5;
            this.rtb_synopsis.Text = "";
            // 
            // dtp_tglLaunch
            // 
            this.dtp_tglLaunch.Location = new System.Drawing.Point(165, 98);
            this.dtp_tglLaunch.Name = "dtp_tglLaunch";
            this.dtp_tglLaunch.Size = new System.Drawing.Size(304, 20);
            this.dtp_tglLaunch.TabIndex = 6;
            // 
            // btn_inputFilm
            // 
            this.btn_inputFilm.Location = new System.Drawing.Point(393, 262);
            this.btn_inputFilm.Name = "btn_inputFilm";
            this.btn_inputFilm.Size = new System.Drawing.Size(75, 23);
            this.btn_inputFilm.TabIndex = 7;
            this.btn_inputFilm.Text = "Input Film";
            this.btn_inputFilm.UseVisualStyleBackColor = true;
            this.btn_inputFilm.Click += new System.EventHandler(this.btn_inputFilm_Click);
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(12, 276);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(75, 23);
            this.btn_home.TabIndex = 8;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // Film
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 311);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_inputFilm);
            this.Controls.Add(this.dtp_tglLaunch);
            this.Controls.Add(this.rtb_synopsis);
            this.Controls.Add(this.tb_judulFilm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Film";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input Film";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_judulFilm;
        private System.Windows.Forms.RichTextBox rtb_synopsis;
        private System.Windows.Forms.DateTimePicker dtp_tglLaunch;
        private System.Windows.Forms.Button btn_inputFilm;
        private System.Windows.Forms.Button btn_home;
    }
}

