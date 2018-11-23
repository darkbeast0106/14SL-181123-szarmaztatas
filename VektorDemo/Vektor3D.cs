using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VektorDemo
{
    class Vektor3D : Vektor2D
    {
        private double z;

        public Vektor3D(double x, double y, double z) : base(x,y)
        {
            this.z = z;
        }
        public override string ToString()
        {
            return String.Format("{0},{1})",
                base.ToString().Remove(base.ToString().Length-1),this.z);
        }
        public override double Hossz()
        {
            return Math.Sqrt(Math.Pow(base.Hossz(), 2) + Math.Pow(this.z, 2));
        }
        public static Vektor3D operator +(Vektor3D v1, Vektor3D v2)
        {
            return new Vektor3D(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
        }
    }
}
