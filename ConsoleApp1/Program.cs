﻿using System;
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
            int[] array = { 1, 2, 3, 4 };
            Console.WriteLine(averageFromArray(array));
            Console.WriteLine(max(array));
        }
        static double averageFromArray(int[] array)
        {
            double total = 0;
            for (int i = 0; i < array.Length; i++)
            {
                total += array[i];
                //additional comment
            }
            total = total / array.Length;
            return total;
        }
        static int max(int[] array)
        {
            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }
    }
}
