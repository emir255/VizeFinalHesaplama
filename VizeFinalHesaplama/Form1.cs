using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VizeFinalHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("LÜTFEN VİZE NOTUNUZU GİRİNİZ!!!", "UYARI");
                textBox1.Focus();
                return;

            }
            //else if (Convert.ToInt32(textBox1.Text) < 0 || Convert.ToInt32(textBox1.Text) > 100)
            //{
            //  MessageBox.Show("lütfen 1 ile 100 arasında değer giriniz!!!", "UYARI");
            //label1.Text = "SONUÇ";
            //}
            else if (textBox2.Text == "" & textBox3.Text == "")
            {
                MessageBox.Show("LÜTFEN FİNAL NOTUNUZU GİRİNİZ!!!", "UYARI");
            }

            //else if (Convert.ToInt32(textBox2.Text) < 0 || Convert.ToInt32(textBox2.Text) > 100)
            //{
            //  MessageBox.Show("lütfen 1 ile 100 arasında değer giriniz!!!", "UYARI");
            //label1.Text = "SONUÇ";
            //}



            else if (textBox3.Text == "")
            {
                int kort = (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text)) / 2;
                if (Convert.ToInt32(textBox2.Text) >= 50 & kort >= 50)
                {
                    label1.Text = "ORTALAMANIZ : " + kort + " GEÇTİNİZ...";
                }
                else if (Convert.ToInt32(textBox2.Text) >= 50 & kort < 50)
                {
                    label1.Text = "ORTALAMANIZ : " + kort + " BÜTE KALDINIZ!!!";
                }
                else if (Convert.ToInt32(textBox2.Text) < 50 & kort >= 50)
                {
                    label1.Text = "ORTALAMANIZ : " + kort + " BÜTE KALDINIZ!!!";
                }
                else if (Convert.ToInt32(textBox2.Text) < 50 & kort < 50)
                {
                    label1.Text = "ORTALAMANIZ : " + kort + " BÜTE KALDINIZ!!!";
                }
            }


            if (textBox3.Text != "")
            {
                int bort = (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox3.Text)) / 2;
                if (Convert.ToInt32(textBox3.Text) >= 50 & bort >= 50)
                {
                    label1.Text = "ORTALAMANIZ : " + bort + " GEÇTİNİZ...";
                }
                else if (Convert.ToInt32(textBox3.Text) >= 50 & bort < 50)
                {
                    label1.Text = "ORTALAMANIZ : " + bort + " DERSTEN KALDINIZ!!!";
                }
                else if (Convert.ToInt32(textBox3.Text) < 50 & bort >= 50)
                {
                    label1.Text = "ORTALAMANIZ : " + bort + " DERSTEN KALDINIZ!!!";
                }
                else if (Convert.ToInt32(textBox3.Text) < 50 & bort < 50)
                {
                    label1.Text = "ORTALAMANIZ : " + bort + " DERSTEN KALDINIZ!!!";
                }
                if (Convert.ToInt32(textBox3.Text) < 0 || Convert.ToInt32(textBox3.Text) > 100)
                {
                    MessageBox.Show("lütfen 1 ile 100 arasında değer giriniz!!!", "UYARI");
                    label1.Text = "SONUÇ";
                    textBox3.Text = "";
                    textBox3.Focus();
                }
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

            try
            {
                if (textBox1.Text == "")
                {
                    return;
                }
                else if (Convert.ToInt32(textBox1.Text) < 0 || Convert.ToInt32(textBox1.Text) > 100)
                {
                    MessageBox.Show("Değer 0-100 arasında olmalı");
                    textBox1.Text = "";
                    textBox1.Focus();
                }
            }
            catch
            {
                if (textBox1.Text == "")
                {
                    return;
                }
                else
                {
                    MessageBox.Show("Sayısal bir değer girin");
                    textBox1.Text = "";
                    textBox1.Focus();
                }
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == "")
                {
                    return;
                }
                else if (Convert.ToInt32(textBox2.Text) < 0 || Convert.ToInt32(textBox2.Text) > 100)
                {
                    MessageBox.Show("Değer 0-100 arasında olmalı");
                    textBox2.Text = "";
                    textBox2.Focus();
                }
            }
            catch
            {
                if (textBox2.Text == "")
                {
                    return;
                }
                else
                {
                    MessageBox.Show("Sayısal bir değer girin");
                    textBox2.Text = "";
                    textBox2.Focus();
                }

            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            try
            {
                if (textBox3.Text == "")
                {
                    return;
                }
                else if (Convert.ToInt32(textBox3.Text) < 0 || Convert.ToInt32(textBox3.Text) > 100)
                {
                    MessageBox.Show("Değer 0-100 arasında olmalı");
                    textBox3.Text = "";
                    textBox3.Focus();
                }
            }
            catch
            {
                if (textBox3.Text == "")
                {
                    return;
                }
                else
                {
                    MessageBox.Show("Sayısal bir değer girin");
                    textBox3.Text = "";
                    textBox3.Focus();
                }
            }
        }
    }
}
