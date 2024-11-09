namespace KimlikKaydi
{
    partial class Form1
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
            this.tb_ad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_soyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_dogumyeri = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_cinsiyet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_kangrubu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_liste = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_tc = new System.Windows.Forms.MaskedTextBox();
            this.tb_dogumtarihi = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // tb_ad
            // 
            this.tb_ad.Location = new System.Drawing.Point(110, 32);
            this.tb_ad.Name = "tb_ad";
            this.tb_ad.Size = new System.Drawing.Size(100, 20);
            this.tb_ad.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad";
            // 
            // tb_soyad
            // 
            this.tb_soyad.Location = new System.Drawing.Point(110, 58);
            this.tb_soyad.Name = "tb_soyad";
            this.tb_soyad.Size = new System.Drawing.Size(100, 20);
            this.tb_soyad.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Doğum Tarihi";
            // 
            // tb_dogumyeri
            // 
            this.tb_dogumyeri.Location = new System.Drawing.Point(110, 136);
            this.tb_dogumyeri.Name = "tb_dogumyeri";
            this.tb_dogumyeri.Size = new System.Drawing.Size(100, 20);
            this.tb_dogumyeri.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Doğum Yeri";
            // 
            // tb_cinsiyet
            // 
            this.tb_cinsiyet.Location = new System.Drawing.Point(110, 162);
            this.tb_cinsiyet.Name = "tb_cinsiyet";
            this.tb_cinsiyet.Size = new System.Drawing.Size(100, 20);
            this.tb_cinsiyet.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Cinsiyet";
            // 
            // tb_kangrubu
            // 
            this.tb_kangrubu.Location = new System.Drawing.Point(110, 188);
            this.tb_kangrubu.Name = "tb_kangrubu";
            this.tb_kangrubu.Size = new System.Drawing.Size(100, 20);
            this.tb_kangrubu.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Kan Grubu";
            // 
            // lbl_liste
            // 
            this.lbl_liste.AutoSize = true;
            this.lbl_liste.Location = new System.Drawing.Point(375, 34);
            this.lbl_liste.Name = "lbl_liste";
            this.lbl_liste.Size = new System.Drawing.Size(0, 13);
            this.lbl_liste.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_tc
            // 
            this.tb_tc.Location = new System.Drawing.Point(110, 84);
            this.tb_tc.Mask = "00000000000";
            this.tb_tc.Name = "tb_tc";
            this.tb_tc.Size = new System.Drawing.Size(100, 20);
            this.tb_tc.TabIndex = 4;
            this.tb_tc.ValidatingType = typeof(int);
            // 
            // tb_dogumtarihi
            // 
            this.tb_dogumtarihi.Location = new System.Drawing.Point(112, 110);
            this.tb_dogumtarihi.Mask = "00/00/0000";
            this.tb_dogumtarihi.Name = "tb_dogumtarihi";
            this.tb_dogumtarihi.Size = new System.Drawing.Size(100, 20);
            this.tb_dogumtarihi.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_dogumtarihi);
            this.Controls.Add(this.tb_tc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_liste);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_kangrubu);
            this.Controls.Add(this.tb_cinsiyet);
            this.Controls.Add(this.tb_dogumyeri);
            this.Controls.Add(this.tb_soyad);
            this.Controls.Add(this.tb_ad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_ad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_soyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_dogumyeri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_cinsiyet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_kangrubu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_liste;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox tb_tc;
        private System.Windows.Forms.MaskedTextBox tb_dogumtarihi;
    }
}

