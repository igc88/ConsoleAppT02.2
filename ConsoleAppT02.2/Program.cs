﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppT02._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 6;

            double num3 = 2.57;
            double suma;
            suma = num1 + num3;

            Console.WriteLine(suma);
            string valor1 = Console.ReadLine();
            Console.WriteLine("El número introducido es: " + valor1);
            int valorint = Convert.ToInt32(valor1);

            Console.ReadKey();
        }
    }
}
