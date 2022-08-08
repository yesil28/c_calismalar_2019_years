using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Configuration;

namespace ogrenci_not_sistemi
{
    public partial class querystudent_form : ogrenci_not_sistemi.mainform
    {
        public querystudent_form()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
        private void btnguncelle_Click(object sender, EventArgs e)
        {
            string guncellesorgusu = "update ogrenci set ogrenci_no=@ogrencino,ogrenci_ad=@ogrenciad,ogrenci_soyad=@ogrencisoyad,sinifid=@sinifid where ogrenci_ad LIKE @mevcutogrenciad";
            SqlCommand guncelle_komutu = new SqlCommand(guncellesorgusu,baglanti);

            guncelle_komutu.Parameters.AddWithValue("@ogrencino",Convert.ToInt32( textBox3.Text));
            guncelle_komutu.Parameters.AddWithValue("@ogrenciad",textBox4.Text);
            guncelle_komutu.Parameters.AddWithValue("@ogrencisoyad",textBox2.Text);
            guncelle_komutu.Parameters.AddWithValue("@sinifid",(int)comboBox1.SelectedValue);

            guncelle_komutu.Parameters.AddWithValue("@mevcutogrenciad",textBox1.Text);

            try
            {
                baglanti.Open();
                guncelle_komutu.ExecuteNonQuery();
                MessageBox.Show("Öğrenci bilgileri başarıyla güncellendi.");
            }
            catch (Exception hata)
            {

                MessageBox.Show("Öğrenci bilgileri güncellenemedi." + hata.Message);
            }
            finally 
            {
                baglanti.Close();
            }
        }

        private void btnogrencisorgula_Click(object sender, EventArgs e)
        {
            string ogrencicek = "select * from ogrenci where ogrenci_ad LIKE @ogrenciad";
            SqlCommand ogrencicek_komutu = new SqlCommand(ogrencicek,baglanti);
            ogrencicek_komutu.Parameters.AddWithValue("@ogrenciad", textBox1.Text);
            try
            {
                baglanti.Open();
                SqlDataReader cek = ogrencicek_komutu.ExecuteReader();

                if (cek.Read())
                {
                    MessageBox.Show("Öğrenci bulunmuştur.");
                    textBox4.Text = cek[2].ToString();
                    textBox2.Text = cek[3].ToString();
                    textBox3.Text = cek[1].ToString();

                   
                    comboBox1.SelectedValue = cek[4];

                }

            }
            catch (Exception hata)
            {

                MessageBox.Show("Öğrenci bulunamadı. " + hata.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void querystudent_form_Load(object sender, EventArgs e)
        {
            Dictionary<int, string> siniflar = new Dictionary<int, string>();

            string siniflaricek = "select * from sinif";
            SqlCommand komut = new SqlCommand(siniflaricek, baglanti);
            baglanti.Open();
            SqlDataReader reader = komut.ExecuteReader();

            while (reader.Read())
            {
                //comboBox1.Items.Add(reader.GetValue(1).ToString());
                siniflar.Add(reader.GetInt32(0), reader.GetValue(1).ToString());

            }
            baglanti.Close();

            comboBox1.DataSource = new BindingSource(siniflar, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // MessageBox.Show(comboBox1.SelectedValue.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedValue = 2;
        }
    }
}
