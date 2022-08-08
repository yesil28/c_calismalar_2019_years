namespace ogrenci_not_sistemi
{
    partial class querystudent_form
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnguncelle = new System.Windows.Forms.Button();
            this.lblogrencino = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnogrencisorgula = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblsinif = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblno = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblsoyad = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblad = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(311, 152);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(75, 23);
            this.btnguncelle.TabIndex = 1;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // lblogrencino
            // 
            this.lblogrencino.AutoSize = true;
            this.lblogrencino.Location = new System.Drawing.Point(36, 64);
            this.lblogrencino.Name = "lblogrencino";
            this.lblogrencino.Size = new System.Drawing.Size(60, 13);
            this.lblogrencino.TabIndex = 2;
            this.lblogrencino.Text = "Öğrenci Ad";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // btnogrencisorgula
            // 
            this.btnogrencisorgula.Location = new System.Drawing.Point(98, 83);
            this.btnogrencisorgula.Name = "btnogrencisorgula";
            this.btnogrencisorgula.Size = new System.Drawing.Size(100, 23);
            this.btnogrencisorgula.TabIndex = 4;
            this.btnogrencisorgula.Text = "Öğrenci Sorgula";
            this.btnogrencisorgula.UseVisualStyleBackColor = true;
            this.btnogrencisorgula.Click += new System.EventHandler(this.btnogrencisorgula_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(265, 125);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblsinif
            // 
            this.lblsinif.AutoSize = true;
            this.lblsinif.Location = new System.Drawing.Point(224, 128);
            this.lblsinif.Name = "lblsinif";
            this.lblsinif.Size = new System.Drawing.Size(27, 13);
            this.lblsinif.TabIndex = 16;
            this.lblsinif.Text = "Sınıf";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(265, 96);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 15;
            // 
            // lblno
            // 
            this.lblno.AutoSize = true;
            this.lblno.Location = new System.Drawing.Point(224, 103);
            this.lblno.Name = "lblno";
            this.lblno.Size = new System.Drawing.Size(21, 13);
            this.lblno.TabIndex = 14;
            this.lblno.Text = "No";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(265, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 13;
            // 
            // lblsoyad
            // 
            this.lblsoyad.AutoSize = true;
            this.lblsoyad.Location = new System.Drawing.Point(224, 77);
            this.lblsoyad.Name = "lblsoyad";
            this.lblsoyad.Size = new System.Drawing.Size(39, 13);
            this.lblsoyad.TabIndex = 12;
            this.lblsoyad.Text = "Soyadı";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(265, 44);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 20);
            this.textBox4.TabIndex = 11;
            // 
            // lblad
            // 
            this.lblad.AutoSize = true;
            this.lblad.Location = new System.Drawing.Point(224, 51);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(22, 13);
            this.lblad.TabIndex = 10;
            this.lblad.Text = "Adı";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // querystudent_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(416, 207);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblsinif);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblno);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblsoyad);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lblad);
            this.Controls.Add(this.btnogrencisorgula);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblogrencino);
            this.Controls.Add(this.btnguncelle);
            this.Name = "querystudent_form";
            this.Text = "Öğrenci Sorgulama";
            this.Load += new System.EventHandler(this.querystudent_form_Load);
            this.Controls.SetChildIndex(this.btnguncelle, 0);
            this.Controls.SetChildIndex(this.lblogrencino, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.btnogrencisorgula, 0);
            this.Controls.SetChildIndex(this.lblad, 0);
            this.Controls.SetChildIndex(this.textBox4, 0);
            this.Controls.SetChildIndex(this.lblsoyad, 0);
            this.Controls.SetChildIndex(this.textBox2, 0);
            this.Controls.SetChildIndex(this.lblno, 0);
            this.Controls.SetChildIndex(this.textBox3, 0);
            this.Controls.SetChildIndex(this.lblsinif, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Label lblogrencino;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnogrencisorgula;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblsinif;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblno;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblsoyad;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblad;
        private System.Windows.Forms.Button button1;
    }
}
