﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lommeregner
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
            int stop = 1;
            while (stop != 0)
            {


                Console.WriteLine("Tast + for plus, - for minus, * for gange, / for divider, 2 for i anden, s for kvadratrod og 1 for at slutte");
                string isit = Console.ReadLine();
                if (isit == "+")
                {
                    Console.WriteLine("Tast tal");
                    string input1 = Console.ReadLine();
                    string input2 = Console.ReadLine();
                    Double.TryParse(input1, out num1);
                    Double.TryParse(input2, out num2);
                    double plus = num1 + num2;
                    Console.WriteLine("Svar er " + plus);
                }
                else if (isit == "-")
                {
                    Console.WriteLine("Tast tal");
                    string input1 = Console.ReadLine();
                    string input2 = Console.ReadLine();
                    Double.TryParse(input1, out num1);
                    Double.TryParse(input2, out num2);
                    double minus = num1 - num2;
                    Console.WriteLine("Svar er " + minus);
                }
                else if (isit == "*")
                {
                    Console.WriteLine("Tast tal");
                    string input1 = Console.ReadLine();
                    string input2 = Console.ReadLine();
                    Double.TryParse(input1, out num1);
                    Double.TryParse(input2, out num2);
                    double gange = num1 * num2;
                    Console.WriteLine("Svar er " + gange);
                }
                else if (isit == "/")
                {
                    Console.WriteLine("Tast tal");
                    string input1 = Console.ReadLine();
                    string input2 = Console.ReadLine();
                    Double.TryParse(input1, out num1);
                    Double.TryParse(input2, out num2);
                    double divider = num1 / num2;
                    Console.WriteLine("Svar er " + divider);
                }
                else if (isit == "2")
                {
                    Console.WriteLine("Tast tal");
                    string input1 = Console.ReadLine();
                    Double.TryParse(input1, out num1);
                    double ianden = num1 * num1;
                    Console.WriteLine("Svar er " + ianden);
                }
                else if (isit == "s")
                {
                    Console.WriteLine("Tast tal");
                    string input1 = Console.ReadLine();
                    Double.TryParse(input1, out num1);
                    double ianden = Math.Sqrt(num1);
                    Console.WriteLine("Svar er " + ianden);
                }
                else if (isit == "1")
                {
                    stop = 0;
                    Console.WriteLine("Program slutter");
                }
                else
                {
                    Console.WriteLine("You can't do that, Bitch");
                }
            }

        }
        
    }
}
