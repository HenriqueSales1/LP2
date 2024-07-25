using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    internal class Circulo : Figura
    {
        private double raio;

        public Circulo(double raio)
        {
            this.raio = raio;
        }
        public double Raio { get => raio; set => raio = value; }

        public override double calcArea()
        {
            return Math.PI * Math.Pow(raio, 2);
        }

        public override double calcPerimetro()
        {
            return 2 * Math.PI * raio;
        }
    }
}
