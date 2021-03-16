using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej8_Media
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double c1, c2, c3, c4, p;
            string condicion;
            c1 = double.Parse(textBox1.Text);
            c2 = double.Parse(textBox2.Text);
            c3 = double.Parse(textBox3.Text);
            c4 = double.Parse(textBox4.Text);

            p = (c1 + c2 + c3 + c4) / 4;

            if (p <= 59 && p >= 0)
            {
                condicion = "E";
                textBox5.Text = p.ToString();
                textBox6.Text = condicion;
            }
            else if (p >= 60 && p <= 69)
            {
                condicion = "D";
                textBox5.Text = p.ToString();
                textBox6.Text = condicion;
            }
            else if (p >= 70 && p <= 79)
            {
                condicion = "C";
                textBox5.Text = p.ToString();
                textBox6.Text = condicion;
            }
            else if (p >= 80 && p <= 89)
            {
                condicion = "B";
                textBox5.Text = p.ToString();
                textBox6.Text = condicion;
            }
            else if (p >= 90 && p <= 100)
            {
                condicion = "A";
                textBox5.Text = p.ToString();
                textBox6.Text = condicion;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
            textBox2.Clear();
            textBox2.Focus();
            textBox3.Clear();
            textBox3.Focus();
            textBox4.Clear();
            textBox4.Focus();
            textBox5.Clear();
            textBox6.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult salir;
            salir = MessageBox.Show("Deseas salir de la aplicacion?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (salir == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
