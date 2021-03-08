using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppCars
{
    public class Calc
    {

        //public static double Add(double numA, double numB)
        //{
        //    return numA + numB;
        //}

        //public static double Add(double[] numbers)
        //{

        //    double sum = 0;

        //    foreach (double num in numbers)
        //    {
        //        sum = num + sum;
        //    }

        //    return sum;
        //}

        public static double Add(params double[] numbers)//varargs
        {

            double sum = 0;

            foreach (double num in numbers)
            {
                sum = num + sum;
            }

            return sum;
        }
    }
}
