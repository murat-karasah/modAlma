using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modAlma
{
    public partial class Form1 : Form
    {
        public int sayi = 0, sonuc;
        public Form1()
        {
            InitializeComponent();

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int y = 0;
            sayi = Convert.ToInt32(textBox1.Text);

            richTextBox1.Clear();
            if (sayi==0)
            {
                MessageBox.Show("Lütfen Bir Sayı Giriniz!");
            }
            else
            {



                for (int i = 1; i <= sayi; i++)
            {
                if (sayi % i == 0)
                {
                        y++;

                        richTextBox1.AppendText(y+"." +i + "\n");
                }
                    textBox1.Text = "0";
            }
            }
        }
    }
}
