namespace takimayirma
{
    partial class Form1
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
            this.txttakim = new System.Windows.Forms.TextBox();
            this.lsttakimlar = new System.Windows.Forms.ListBox();
            this.btntakim_ekle = new System.Windows.Forms.Button();
            this.lbltakim = new System.Windows.Forms.Label();
            this.lstgrup1 = new System.Windows.Forms.ListBox();
            this.lstgrup2 = new System.Windows.Forms.ListBox();
            this.btntakim_ayir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txttakim
            // 
            this.txttakim.Location = new System.Drawing.Point(75, 54);
            this.txttakim.Name = "txttakim";
            this.txttakim.Size = new System.Drawing.Size(100, 20);
            this.txttakim.TabIndex = 0;
            // 
            // lsttakimlar
            // 
            this.lsttakimlar.FormattingEnabled = true;
            this.lsttakimlar.Location = new System.Drawing.Point(181, 54);
            this.lsttakimlar.Name = "lsttakimlar";
            this.lsttakimlar.Size = new System.Drawing.Size(120, 95);
            this.lsttakimlar.TabIndex = 1;
            // 
            // btntakim_ekle
            // 
            this.btntakim_ekle.Location = new System.Drawing.Point(226, 155);
            this.btntakim_ekle.Name = "btntakim_ekle";
            this.btntakim_ekle.Size = new System.Drawing.Size(75, 23);
            this.btntakim_ekle.TabIndex = 2;
            this.btntakim_ekle.Text = "Ekle";
            this.btntakim_ekle.UseVisualStyleBackColor = true;
            this.btntakim_ekle.Click += new System.EventHandler(this.Btntakim_ekle_Click);
            // 
            // lbltakim
            // 
            this.lbltakim.AutoSize = true;
            this.lbltakim.Location = new System.Drawing.Point(12, 61);
            this.lbltakim.Name = "lbltakim";
            this.lbltakim.Size = new System.Drawing.Size(57, 13);
            this.lbltakim.TabIndex = 3;
            this.lbltakim.Text = "Takım İsmi";
            // 
            // lstgrup1
            // 
            this.lstgrup1.FormattingEnabled = true;
            this.lstgrup1.Location = new System.Drawing.Point(376, 83);
            this.lstgrup1.Name = "lstgrup1";
            this.lstgrup1.Size = new System.Drawing.Size(120, 95);
            this.lstgrup1.TabIndex = 4;
            // 
            // lstgrup2
            // 
            this.lstgrup2.FormattingEnabled = true;
            this.lstgrup2.Location = new System.Drawing.Point(502, 83);
            this.lstgrup2.Name = "lstgrup2";
            this.lstgrup2.Size = new System.Drawing.Size(120, 95);
            this.lstgrup2.TabIndex = 5;
            // 
            // btntakim_ayir
            // 
            this.btntakim_ayir.Location = new System.Drawing.Point(376, 54);
            this.btntakim_ayir.Name = "btntakim_ayir";
            this.btntakim_ayir.Size = new System.Drawing.Size(246, 23);
            this.btntakim_ayir.TabIndex = 6;
            this.btntakim_ayir.Text = "Takımları Dağıt";
            this.btntakim_ayir.UseVisualStyleBackColor = true;
            this.btntakim_ayir.Click += new System.EventHandler(this.Btntakim_ayir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 202);
            this.Controls.Add(this.btntakim_ayir);
            this.Controls.Add(this.lstgrup2);
            this.Controls.Add(this.lstgrup1);
            this.Controls.Add(this.lbltakim);
            this.Controls.Add(this.btntakim_ekle);
            this.Controls.Add(this.lsttakimlar);
            this.Controls.Add(this.txttakim);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttakim;
        private System.Windows.Forms.ListBox lsttakimlar;
        private System.Windows.Forms.Button btntakim_ekle;
        private System.Windows.Forms.Label lbltakim;
        private System.Windows.Forms.ListBox lstgrup1;
        private System.Windows.Forms.ListBox lstgrup2;
        private System.Windows.Forms.Button btntakim_ayir;
    }
}

