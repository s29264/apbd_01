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
            //Modyfikacja 1
            //Modyfikacja 2
            //Modyfikacja 3
        }
        static double average(int[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            sum = sum / array.Length;
            return sum;
        }
    }
}
