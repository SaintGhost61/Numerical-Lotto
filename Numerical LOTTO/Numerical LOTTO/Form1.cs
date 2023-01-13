using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numerical_LOTTO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] sayi = new int[50];
        int[] rastgele = new int[6];
        private void sira()
        {
            Random rnd = new Random();
            for (int i = 0; i < sayi.Length; i++)
            {
                int sayi2;
                do
                {
                    sayi2 = rnd.Next(1, 100);
                } while (sayi.Contains(sayi2) == true);
                sayi[i] = sayi2;
            }
            for (int i = 1; i < 50; i++)
            {
                Controls["label" + (i)].Text = sayi[i].ToString();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Her şeyden önce girişe sayıları giriniz.");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < rastgele.Length; i++)
            {
                int sayi;
                do
                {
                    sayi = rnd.Next(0, 50);
                } while (rastgele.Contains(sayi)==true);
                rastgele[i] = sayi;
            }
            int a = 50;
            for (int i = 0; i < rastgele.Length; i++)
            {
                Controls["label" + (a)].Text = sayi[rastgele[i]].ToString();
                a++;
            }
            if (textBox1.Text== label50.Text
                && textBox2.Text == label51.Text
                && textBox3.Text == label52.Text 
                && textBox4.Text == label53.Text 
                && textBox5.Text == label54.Text 
                && textBox6.Text == label55.Text)
            {
                MessageBox.Show("Tebrikler ödülü kazandınız");
            }
            else
            {
                MessageBox.Show("Malesef ki kazanamıdınız");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sira();
        }

        private void label40_Click(object sender, EventArgs e)
        {

        }
    }
}
