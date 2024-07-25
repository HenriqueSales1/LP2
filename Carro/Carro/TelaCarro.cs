using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TelaCarro : Form
    {
        private Carro carro;
        public TelaCarro()
        {
            InitializeComponent();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            carro = new Carro(0, false, 0);
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;

            if (carro.Ligado) label2.Text = "Ligado";
            else label2.Text = "Desligado";

            label5.Text = Convert.ToString(carro.Velocidade);
            marcha();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            carro.ligar();

            if (carro.Ligado) label2.Text = "Ligado";
            else label2.Text = "Desligado";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            carro.acelerar();

            label5.Text = Convert.ToString(carro.Velocidade);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            carro.freiar();

            label5.Text = Convert.ToString(carro.Velocidade);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            carro.mudaMarcha();
            marcha();
        }

        private void marcha()
        {
            
            if (carro.Marcha == 0) label6.Text = "Ré";
            else label6.Text = Convert.ToString(carro.Marcha);
        }
    }
}
