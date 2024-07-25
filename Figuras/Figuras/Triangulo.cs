using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    internal class Triangulo : Figura
    {
        private double baset;
        private double height;

        public Triangulo(double baset, double height)
        {
            this.baset = baset;
            this.height = height;
        }

        public double Baset { get => baset; set => baset = value; }
        public double Height { get => height; set => height = value; }

        public override double calcArea()
        {
            return baset * height / 2;
        }

        public override double calcPerimetro()
        {
            return baset*3;
        }
    }
}
