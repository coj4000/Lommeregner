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
            Skynet net = new Skynet();
            Console.WriteLine("Tast tal");
            string input1 = Console.ReadLine();
            //string input2 = Console.ReadLine();
            //string input3 = Console.ReadLine();
            bool ok = Int32.TryParse("input1", net.tal2);

        }
    }
}
