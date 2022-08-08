using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> sorular = new List<string>();
        List<string> secenekler = new List<string>();
        List<string> dogrucevaplar = new List<string>();
        int sorunumarasi = 0;
        int index;
        int puan=0;
        private void Form1_Load(object sender, EventArgs e)
        {
           
            sorular.Add("Başkent neresi");
            sorular.Add("Üçgenin iç açıları?");
            sorular.Add("2*2?");
            

            
            secenekler.Add("Ankara-Rize-İstanbul");
            secenekler.Add("180-360-40");
            secenekler.Add("5-10-4");

            
            dogrucevaplar.Add("Ankara");
            dogrucevaplar.Add("180");
            dogrucevaplar.Add("4");


            Random r = new Random();

            index = r.Next(0,3);
            label1.Text = sorular[index].ToString();
            string[] dizi = secenekler[index].Split('-');
            radioButton1.Text = dizi[0];
            radioButton2.Text = dizi[1];
            radioButton3.Text = dizi[2];
            sorunumarasi++;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                if (radioButton1.Text == dogrucevaplar[index])
                {
                    puan += 10;
                }
            }
            else if (radioButton2.Checked == true)
            {
                if (radioButton2.Text == dogrucevaplar[index])
                {
                    puan += 10;
                }
            }
            else if (radioButton3.Checked == true)
            {
                if (radioButton3.Text == dogrucevaplar[index])
                {
                    puan += 10;
                }
            }
            label2.Text = puan.ToString();
        }
    }
}
