using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b3_dev_tu_flamant_benoit_armand_lelio
{
    public class Arithmetic
    {
        //Arithmetic functions for a calculator
        public static double Addition(double a, double b)
        {
            //Do an addition
            return a + b;
        }

        public static double Substraction(double a, double b)
        {
            //Do a substraction
            return a - b;
        }

        public static double Multiplication(double a, double b)
        {
            //Do a multiplication
            return a * b;
        }

        public static double Division(double a, double b)
        {
            //Do a division
            return a / b;
        }

        public static double Percentage(double a, double b)
        {
            //b% of a
            return Multiplication(a, b) / 100;
        }
    }
}
