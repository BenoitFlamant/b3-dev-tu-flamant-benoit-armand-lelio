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
        public static float Addition(float a, float b)
        {
            //Do an addition
            return a + b;
        }

        public static float Substraction(float a, float b)
        {
            //Do a substraction
            return a - b;
        }

        public static float Multiplication(float a, float b)
        {
            //Do a multiplication
            return a * b;
        }

        public static float Division(float a, float b)
        {
            //Do a division
            return a / b;
        }

        public static float Percentage(float a, float b)
        {
            //b% of a
            return Multiplication(a, b) / 100;
        }
    }
}
