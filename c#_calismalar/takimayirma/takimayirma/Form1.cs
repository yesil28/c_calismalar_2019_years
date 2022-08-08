using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace takimayirma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> takimlar = new List<string>();    
        private void Btntakim_ekle_Click(object sender, EventArgs e)
        {
            //takimlar.Add(txttakim.Text);
            lsttakimlar.Items.Add(txttakim.Text);
        }

        private void Btntakim_ayir_Click(object sender, EventArgs e)
        {
            takimlar.Clear();
            for (int i = 0; i < lsttakimlar.Items.Count; i++)
            {
                takimlar.Add(lsttakimlar.Items[i].ToString());
            }
            lstgrup1.Items.Clear();
            lstgrup2.Items.Clear();

            Random r = new Random();
            int index;
            for (int i = 0; i < 4; i++)
            {
                index=r.Next(0,takimlar.Count);
                lstgrup1.Items.Add(takimlar[index]);
                takimlar.RemoveAt(index);
            }
            foreach (var item in takimlar)//kalan 4ü
            {
                lstgrup2.Items.Add(item);
            }
        }
    }
}
