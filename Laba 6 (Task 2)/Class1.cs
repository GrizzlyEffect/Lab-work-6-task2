using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_6__Task_2_
{
    internal class Class1
    {
        interface IShape
        {
            double GetArea();
        }

        public class Parallelogram : IShape
        {
            double A;
            double H;

            public Parallelogram(double a, double h)
            {
                A = a;
                H = h;
            }

            public double GetArea()
            {
                return A * H;
            }
        }

        public class Trapezium : IShape
        {
            public double C;
            public double D;
            public double H;

            public Trapezium(double c, double d, double h)
            {
                C = c;
                D = d;
                H = h;
            }

            public  double GetArea()
            {
                return 0.5 * (C + D) * H;
            }
        }

    }
}
