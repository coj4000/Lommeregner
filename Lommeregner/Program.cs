using System;
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


                Console.WriteLine("Tas + for plus, - for minus, * for gange, / for divider og 1 for at slutte");
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
                    string input3 = Console.ReadLine();
                    string input4 = Console.ReadLine();
                    Double.TryParse(input3, out num1);
                    Double.TryParse(input4, out num2);
                    double minus = num1 - num2;
                    Console.WriteLine("Svar er " + minus);
                }
                else if (isit == "*")
                {
                    Console.WriteLine("Tast tal");
                    string input3 = Console.ReadLine();
                    string input4 = Console.ReadLine();
                    Double.TryParse(input3, out num1);
                    Double.TryParse(input4, out num2);
                    double gange = num1 * num2;
                    Console.WriteLine("Svar er " + gange);
                }
                else if (isit == "/")
                {
                    Console.WriteLine("Tast tal");
                    string input3 = Console.ReadLine();
                    string input4 = Console.ReadLine();
                    Double.TryParse(input3, out num1);
                    Double.TryParse(input4, out num2);
                    double divider = num1 / num2;
                    Console.WriteLine("Svar er " + divider);
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
