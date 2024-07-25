using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    internal class Retangulo : Figura
    {
        private double baset;
        private double height;

        public Retangulo(double baset, double height)
        {
            this.baset = baset;
            this.height = height;
        }

        public double Baset { get => baset; set => baset = value; }
        public double Height { get => height; set => height = value; }

        public override double calcArea()
        {
            return baset * height;
        }

        public override double calcPerimetro()
        {
            return baset*2 + height*2;
        }
    }
}
