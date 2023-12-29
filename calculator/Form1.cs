using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class calculatorform : Form
    {
        double ilksayi, ikincisayi, sonuc;
        private char islem;
        private bool ekrantemizlenecek_mi;
        private bool noktalivirgul;
        public calculatorform()
        {
            InitializeComponent();
        }

        private void calculatorform_Load(object sender, EventArgs e)
        {

            textBox1.Text = "0";
            noktalivirgul = true;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (ekrantemizlenecek_mi == true)
            {
                ekrantemizlenecek_mi = false;
                textBox1.Text = "";
            }

            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "1";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ekrantemizlenecek_mi == true)
            {
                ekrantemizlenecek_mi = false;
                textBox1.Text = "";
            }

            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "2";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ekrantemizlenecek_mi == true)
            {
                ekrantemizlenecek_mi = false;
                textBox1.Text = "3";
            }

            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "3";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ekrantemizlenecek_mi == true)
            {
                ekrantemizlenecek_mi = false;
                textBox1.Text = "";
            }

            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "4";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ekrantemizlenecek_mi == true)
            {
                ekrantemizlenecek_mi = false;
                textBox1.Text = "";
            }

            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "5";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ekrantemizlenecek_mi == true)
            {
                ekrantemizlenecek_mi = false;
                textBox1.Text = "";
            }

            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "6";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (ekrantemizlenecek_mi == true)
            {
                ekrantemizlenecek_mi = false;
                textBox1.Text = "";
            }

            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "7";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (ekrantemizlenecek_mi == true)
            {
                ekrantemizlenecek_mi = false;
                textBox1.Text = "";
            }

            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (ekrantemizlenecek_mi == true)
            {
                ekrantemizlenecek_mi = false;
                textBox1.Text = "";
            }

            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "9";

        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (ekrantemizlenecek_mi == true)
            {
                ekrantemizlenecek_mi = false;
                textBox1.Text = "";
            }

            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "0";

        }
        private void buttonclear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            noktalivirgul = true;
        }
    private void ondalik_Click(object sender, EventArgs e)
        {
            if(ekrantemizlenecek_mi == true)
            {
                textBox1.Text = "";
            }
            if (noktalivirgul == true)
            {
                textBox1.Text += ",";
                noktalivirgul = false;
            }
        }
        private void buttonesittir_Click(object sender, EventArgs e)
        {
            ikincisayi = Convert.ToDouble(textBox1.Text);
            switch (islem)
            {
                case '+': sonuc = ilksayi + ikincisayi; textBox1.Text = Convert.ToString(sonuc); break;
                case '-': sonuc = ilksayi - ikincisayi; textBox1.Text = Convert.ToString(sonuc); break;
                case '*': sonuc = ilksayi * ikincisayi; textBox1.Text = Convert.ToString(sonuc); break;
                case '/':
                    if (ikincisayi == 0)
                    {
                        textBox1.Text = "0'a bölünemez";
                        break;
                    }
                    sonuc = ilksayi / ikincisayi; textBox1.Text = Convert.ToString(sonuc); break;
                default: textBox1.Text = "Hata"; break;
            }

            ekrantemizlenecek_mi = true;

        }

        private void buttontopla_Click(object sender, EventArgs e)
        {
            ilksayi = Convert.ToDouble(textBox1.Text);
            islem = '+';
            ekrantemizlenecek_mi = true;
            noktalivirgul = true;
        }

        private void buttoncikar_Click(object sender, EventArgs e)
        {
            ilksayi = Convert.ToDouble(textBox1.Text);
            islem = '-';
            ekrantemizlenecek_mi = true;
            noktalivirgul = true;
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, (textBox1.TextLength - 1));
            }
            if (textBox1.TextLength == 0)
            {
                textBox1.Text = "0";
            }
        }

     

        private void buttoncarpim_Click(object sender, EventArgs e)
        {
            ilksayi = Convert.ToDouble(textBox1.Text);
            islem = '*';
            ekrantemizlenecek_mi = true;
            noktalivirgul = true;

        }

        private void buttonbolme_Click(object sender, EventArgs e)
        {
            ilksayi = Convert.ToDouble(textBox1.Text);
            islem = '/';
            ekrantemizlenecek_mi = true;
            noktalivirgul = true;
        }


    }
}
