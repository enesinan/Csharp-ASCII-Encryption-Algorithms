using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sifreleme_algoritmaları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;
            byte[] veridizi = ASCIIEncoding.ASCII.GetBytes(metin);
            string sifrelimetin = Convert.ToBase64String(veridizi);
            textBox2.Text = sifrelimetin;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            string metincoz = textBox2.Text;
            byte[] veridizimcozulen = Convert.FromBase64String(metincoz);
            string anametin = ASCIIEncoding.ASCII.GetString(veridizimcozulen);
            textBox1.Text = anametin;


        }
    }
}
