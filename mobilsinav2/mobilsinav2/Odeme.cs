using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mobilsinav2
{
    public partial class Odeme : Form
    {
        public Odeme()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            label2.Text = Form1.toplam.ToString();
            listBox2.Items.Add($"Masa 1 ücreti : {Form1.masa1}");
            listBox2.Items.Add($"Masa 2 ücreti : {Form1.masa2}");
            listBox2.Items.Add($"Masa 3 ücreti : {Form1.masa3}");
            listBox2.Items.Add($"Masa 4 ücreti : {Form1.masa4}");
            listBox2.Items.Add($"Masa 5 ücreti : {Form1.masa5}");
            DateTime suankiZaman = DateTime.Now;
            string tarih = suankiZaman.ToShortDateString();
            string saat = suankiZaman.ToShortTimeString();

            label3.Text = "Odeme alinan tarih" + tarih + " - " + saat;


        }

        public Odeme(List<string> veriler)
        {
            InitializeComponent();
            foreach (string veri in veriler)
            {
                listBox1.Items.Add(veri);
            }
        }
        public void button1_Click(object sender, EventArgs e)
        {

        }
        
    }
}
