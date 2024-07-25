using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Carro
    {
        private int velocidade = 0;
        private bool ligado = false;
        private int marcha = 1;
        private readonly int aceleracao = 3;

        public Carro(int velocidade, bool ligado, int marcha)
        {
            this.velocidade = velocidade;
            this.ligado = ligado;
            this.marcha = marcha;
        }

        public int Velocidade
        {
            get { return velocidade; }
            set { velocidade = value; 
            }
        }

        public bool Ligado {
            get { return ligado; } 
            set { ligado = value; } 
        }
        public int Marcha {
            get {  return marcha; } 
            set {  marcha = value; } 
        }

        public void ligar()
        {
            ligado = true;
        }

        public void acelerar()
        {
            if(ligado) velocidade += aceleracao;
        }

        public void freiar()
        {
            if(velocidade != 0) velocidade -= aceleracao;
        }

        public void mudaMarcha()
        {
            if (marcha < 6) marcha++;
            else marcha = 0;
        }
    }
}
