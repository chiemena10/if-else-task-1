﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;

            Console.WriteLine("enter an integer");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter a second integer");
            num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("[0] is greater than [1]", num1, num2);
                Console.ReadLine();
            }
            else if (num1 < num2)
            {
                Console.WriteLine("[1] is greater than [0]", num1, num2);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("both number are the same");
                Console.ReadLine();
            }
        }
    }
}
