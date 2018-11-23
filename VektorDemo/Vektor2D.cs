using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VektorDemo
{
    class Vektor2D
    {
        private int x;
        private int y;

        public Vektor2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return String.Format("({0},{1})", this.x, this.y);
        }

        public Vektor2D HozzaAd(Vektor2D v)
        {
            return new Vektor2D(this.x + v.x, this.y + v.y);
        }
        public static Vektor2D OsszeAd(Vektor2D v1, Vektor2D v2)
        {
            return new Vektor2D(v1.x + v2.x, v1.y + v2.y);
        }
        public static Vektor2D operator +(Vektor2D v1, Vektor2D v2)
        {
            return new Vektor2D(v1.x + v2.x, v1.y + v2.y);
        }
        public static Vektor2D operator -(Vektor2D v1, Vektor2D v2)
        {
            return new Vektor2D(v1.x - v2.x, v1.y - v2.y);
        }
        public static double operator *(Vektor2D v1, Vektor2D v2)
        {
            return v1.x * v2.x + v1.y * v2.y;
        }
        public double Hossz()
        {
            return Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y, 2));
        }

        public static double KozbezartSzog(Vektor2D v1, Vektor2D v2)
        {
            return 180 * Math.Acos(v1 * v2 / (v1.Hossz() * v2.Hossz())) / Math.PI;
        }
    }
}
