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
        public  int sayi,sonuc;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            sayi = Convert.ToInt32(textBox1.Text);
            for (int i = 1; i <= sayi; i++)
            {
                if (sayi % i == 0)
                {
                    richTextBox1.AppendText(i + "\n");
                }
            }
        }
    }
}
