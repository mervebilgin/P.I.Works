using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 13;
            int num2 = 49;

            Console.WriteLine("Values before displacement ");
            Console.WriteLine("Number 1={0}", num1);
            Console.WriteLine("Number 2={0}", num2);

            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;
            Console.WriteLine("********");
            Console.WriteLine("Values after displacement ");
            Console.WriteLine("Number 1={0}", num1);
            Console.WriteLine("Number 2={0}", num2);

            Console.ReadKey();


        }
    }
}
