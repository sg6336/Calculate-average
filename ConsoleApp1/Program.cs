using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[] { 17, 16, 16, 16, 16, 15, 17, 17, 15, 5, 17, 17, 16 };
            AverageSolution.FindAverage(array);

            // Should return 0 on empty array
            AverageSolution.FindAverage(new double[] { });
        }
    }

    public class AverageSolution
    {
        public static double FindAverage(double[] array)
        {
            if (array.Length == 0)
            {
                return 0;
            }
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            double result = sum / array.Length;
            return result;
        }
    }
}
