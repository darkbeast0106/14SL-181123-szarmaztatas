using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VektorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Vektor2D v1 = new Vektor2D(1,0);
            Vektor2D v2 = new Vektor2D(0,1);
            Vektor3D v3 = new Vektor3D(1.5, 2.14, 3.0);
            //Console.WriteLine(Vektor2D.KozbezartSzog(v1, v2));
            Vektor2D v4 = new Vektor3D(1, 2, 3);
            

            Console.WriteLine(v3);
            Console.ReadLine();
        }
    }
}
