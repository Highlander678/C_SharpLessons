using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_1
{
    class Treangle
    {
        double AB { get; set; }
        double BC { get; set; }
        double CA { get; set; }
        public Treangle(double a, double b, double c)
        {
            AB = a;
            BC = b;
            CA = c;
        }
        public double Perimeter()
        {
            return AB + BC + CA;
        }
        public double Area()
        {
            double p = Perimeter() / 2.0;
            return Math.Sqrt((double)p * (p - AB) * (p - BC) * (p - CA));
        }
    }
}
