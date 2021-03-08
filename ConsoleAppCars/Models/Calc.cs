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

        /// <summary>
        /// Using the param (a.k.a. Varargs) is nice but do know it is slower/lower preformace.  
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns>total sum of array</returns>
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
