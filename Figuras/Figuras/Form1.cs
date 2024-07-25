using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;

            label8.Text = "Selecionado: -";
        }

        private Figura figura;
        private int selecionado = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            selecionado = 1;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = false;

            label6.Text = "-";
            label7.Text = "-";
            label8.Text = "Selecionado: Retângulo";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selecionado = 2;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = true;

            label6.Text = "-";
            label7.Text = "-";
            label8.Text = "Selecionado: Círculo";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selecionado = 3;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = false;

            label6.Text = "-";
            label7.Text = "-";
            label8.Text = "Selecionado: Triângulo";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(selecionado == 1) figura = new Retangulo(double.Parse(textBox1.Text), double.Parse(textBox2.Text));
            if(selecionado == 2) figura = new Circulo(double.Parse(textBox3.Text));
            if(selecionado == 3) figura = new Triangulo(double.Parse(textBox1.Text), double.Parse(textBox2.Text));

            label7.Text = figura.calcPerimetro().ToString() + " cm";
            label6.Text = figura.calcArea().ToString() + " cm";

            textBox1.Text = string.Empty; textBox2.Text = string.Empty; textBox3.Text = string.Empty;
        }
    }
}
