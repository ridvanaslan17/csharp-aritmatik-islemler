using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, toplama, cikartma, carpma, bolme, kalan, us, ort;
            
            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);



            toplama = sayi1 + sayi2;
            cikartma = sayi1 - sayi2;
            carpma = sayi1 * sayi2;
            bolme = sayi1 / sayi2;
            kalan = sayi1 % sayi2;
            us = Math.Pow(sayi1, sayi2);
            ort = (sayi1 + sayi2) / 2;
                
                
            textBoxTopla.Text = Convert.ToString(toplama);
            textBoxCikar.Text = Convert.ToString(cikartma);
            textBoxCarp.Text = Convert.ToString(carpma);
            textBoxBol.Text = Convert.ToString(bolme);
            textBoxKalan.Text = Convert.ToString(kalan);
            textBoxUs.Text = Convert.ToString(us);
            textBoxOrt.Text = Convert.ToString(ort);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
