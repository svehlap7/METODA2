using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace METODA2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool Prvocislo(int x)
        {
            if (x < 2)
            {
                return false;
            }
            if (x == 2)
            {
                return true;
            }
            if (x % 2 == 0)
            {
                return false;
            }

            for (int del = 3; del <= Math.Sqrt(x); del += 2)
            {
                if (x % del == 0)
                {
                    return false;
                }
                return true;
            }
            return true;
        }

        private void prepsani(TextBox xb, ListBox yb)
        {
            yb.Items.Clear();
            foreach (string cisla in xb.Lines)
            {
                if (Prvocislo(Convert.ToInt32(cisla)))
                {
                    yb.Items.Add(cisla);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Random rn = new Random();
            int n = Convert.ToInt32(textBox2.Text);

            for (int i = 0; i < n; i++)
            {
                textBox1.Text += rn.Next(2, 16).ToString();
                if (n - i != 1)
                {
                    textBox1.Text += Environment.NewLine;
                }
                prepsani(textBox1, listBox1);
            }
        }
    }
}
