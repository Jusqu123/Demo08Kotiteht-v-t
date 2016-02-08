using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo08Teht5
{
  
        public class ArrayCalcs
        {


            public static double Sum(double[] array)
            {
                Console.WriteLine("sum = {0:F2} ", array.Sum());
                return array.Sum();
            }



            public static double Average(double[] array)
            {
                Console.WriteLine("ave = {0} ", array.Average());
                return array.Average();
            }



            public static double Min(double[] array)
            {
                Console.WriteLine("min = {0:F2} ", array.Min());
                return array.Min();
            }



            public static double Max(double[] array)
            {
                Console.WriteLine("max = {0:F2} ", array.Max());
                return array.Max();
            }
            }
            }