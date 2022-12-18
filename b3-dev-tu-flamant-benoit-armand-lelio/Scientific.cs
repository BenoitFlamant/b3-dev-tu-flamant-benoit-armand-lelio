using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b3_dev_tu_flamant_benoit_armand_lelio
{
    public class Scientific
    {
        //Arithmetic functions for a calculator
        public static double Square(double a)
        {
            //Return the square of a
            return a * a;
        }
        public static double SquareRoot(double a)
        {
            //Return the squareroot of a
            return Math.Sqrt(a);
        }
        public static double Power(double a, double b)
        {
            //Return the square of a
            return Math.Pow(a, b);
        }
    }
}
