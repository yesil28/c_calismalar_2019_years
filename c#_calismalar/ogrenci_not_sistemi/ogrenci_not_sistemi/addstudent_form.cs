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
    public partial class addstudent_form : ogrenci_not_sistemi.mainform
    {
        
        public addstudent_form()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
        private void addstudent_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            

        }

        private void addstudent_form_Load(object sender, EventArgs e)
        {
            Dictionary<int, string> siniflar = new Dictionary<int, string>();

            string siniflaricek = "select * from sinif";
            SqlCommand komut = new SqlCommand(siniflaricek,baglanti);
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

        private void addstudent_form_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedItem.ToString());
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            string ekle = "insert into ogrenci (ogrenci_no,ogrenci_ad,ogrenci_soyad,sinifid) values (@ogrenci_no,@ogrenci_ad,@ogrenci_soyad,@sinifid)";
            SqlCommand ogrenciekle = new SqlCommand(ekle,baglanti);
            ogrenciekle.Parameters.AddWithValue("@ogrenci_no",Convert.ToInt32( textBox3.Text));
            ogrenciekle.Parameters.AddWithValue("@ogrenci_ad",textBox1.Text);
            ogrenciekle.Parameters.AddWithValue("@ogrenci_soyad",textBox2.Text);
            ogrenciekle.Parameters.AddWithValue("@sinifid",(int) comboBox1.SelectedValue);
            try
            {
                baglanti.Open();
                ogrenciekle.ExecuteNonQuery();
                MessageBox.Show("Öğrenci başarılı bir şekilde eklenmiştir.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata!!!Öğrenci eklenemedi." + hata.Message);

            }
            finally
            {
                baglanti.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ogrencisorgula();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void ogrencisorgula()
        {
            string sorgula = "select * from ogrenci inner join sinif on ogrenci.sinifid=sinif.sinifid where ogrenci_no=@ogrenci_no";
            SqlCommand ogrencisorgula = new SqlCommand(sorgula, baglanti);
            ogrencisorgula.Parameters.AddWithValue("@ogrenci_no", Convert.ToInt32(textBox5.Text));
            try
            {
                baglanti.Open();
                SqlDataReader dr = ogrencisorgula.ExecuteReader();
                listView1.Columns.Add("Öğrenci No",60);
                listView1.Columns.Add("Öğrenci Adı",60);
                listView1.Columns.Add("Öğrenci Soyadı",60);
                listView1.CheckBoxes = true;
                listView1.View = View.Details;
                listView1.GridLines = true;
                ListViewItem item = new ListViewItem();
                while (dr.Read())
                {
                    item = listView1.Items.Add(dr["ogrenci_no"].ToString());
                    item.SubItems.Add(dr["ogrenci_ad"].ToString());
                    item.SubItems.Add(dr["ogrenci_soyad"].ToString());
                  
                }
                //SqlDataAdapter da = new SqlDataAdapter(ogrencisorgula);
                //DataTable dt = new DataTable();

                //da.Fill(dt);
                //dataGridView1.DataSource = dt;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata!!! Öğrenci Sorgulanamadı." + hata.Message);

            }
            finally
            {
                baglanti.Close();
                //dataGridView1.Columns[1].Visible = false;
                //dataGridView1.Columns[5].Visible = false;
                //dataGridView1.Columns[6].Visible = false;
                //dataGridView1.Columns[2].HeaderText = "Öğrenci No";
                //dataGridView1.Columns[3].HeaderText = "Öğrenci Adı";
                //dataGridView1.Columns[4].HeaderText = "Öğrenci Soyadı";
                //dataGridView1.Columns[7].HeaderText = "Sınıf";


            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count>0)
            {
                // textBox1.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                comboBox1.SelectedValue = dataGridView1.SelectedRows[0].Cells[6].Value;
                textBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
          

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int i = 1;
            foreach (DataGridViewRow satir in dataGridView1.Rows)
            {
                satir.Cells[0].Value = i;
                i++;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string ogrenciguncelle = "update ogrenci set ogrenci_ad=@ogrenci_ad,ogrenci_soyad=@ogrenci_soyad,ogrenci_no=@ogrenci_no,sinifid=@sinifid where ogrenciid=@ogrenciid";
            SqlCommand guncelle = new SqlCommand(ogrenciguncelle,baglanti);
            guncelle.Parameters.AddWithValue("@ogrenci_ad",textBox1.Text);
            guncelle.Parameters.AddWithValue("@ogrenci_soyad", textBox2.Text);
            guncelle.Parameters.AddWithValue("@ogrenci_no",Convert.ToInt32( textBox3.Text));
            guncelle.Parameters.AddWithValue("@sinifid",(int) comboBox1.SelectedValue);

            guncelle.Parameters.AddWithValue("@ogrenciid",(int)dataGridView1.CurrentRow.Cells[0].Value);

            try
            {
                baglanti.Open();
                guncelle.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Öğrenci başarıyla güncellenmiştir");
                ogrencisorgula();

            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata!!!Öğrenci Güncellenemedi." + hata.Message);

            }
            
        
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            
            string ogrencisil;
            if (dataGridView1.SelectedRows.Count > 0)
            {

                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    ogrencisil = "delete from ogrenci where ogrenciid=@ogrenciid";
                    SqlCommand ogrencisilme = new SqlCommand(ogrencisil,baglanti);
                    ogrencisilme.Parameters.AddWithValue("@ogrenciid",(int)dataGridView1.SelectedRows[i].Cells[1].Value);
                    try
                    {

                        baglanti.Open();
                        ogrencisilme.ExecuteNonQuery();
                        baglanti.Close();
                        ogrencisorgula();
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show("hata!!! Öğrenciler Silinemedi." + hata.Message);
                    }
                   
                    
                }
            }

            }
    }
}
