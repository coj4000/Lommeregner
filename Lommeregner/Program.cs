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
            int num1 = 0;
            int num2 = 0;
            int funk1 = 0;
            int stop = 1;
            while (stop != 0)
            {


                Console.WriteLine("Tas 1 for + og 2 for - og 3 for at slutte");
                string isit = Console.ReadLine();
                Int32.TryParse(isit, out funk1);
                if (funk1 == 1)
                {
                    Console.WriteLine("Tast tal");
                    string input1 = Console.ReadLine();
                    string input2 = Console.ReadLine();
                    //string input3 = Console.ReadLine();
                    Int32.TryParse(input1, out num1);
                    Int32.TryParse(input2, out num2);
                    int plus = num1 + num2;
                    Console.WriteLine("Svar er " + plus);
                }
                if (funk1 == 2)
                {
                    Console.WriteLine("Tast tal");
                    string input3 = Console.ReadLine();
                    string input4 = Console.ReadLine();
                    //string input3 = Console.ReadLine();
                    Int32.TryParse(input3, out num1);
                    Int32.TryParse(input4, out num2);
                    int minus = num1 - num2;
                    Console.WriteLine("Svar er " + minus);
                }
                if (funk1 == 3)
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
