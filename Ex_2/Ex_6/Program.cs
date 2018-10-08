using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 4;
            int num2 = 10;
            int count = 0;

            for (int i = num1; i <= num2; i++)
            {
                Console.WriteLine($"number : {i}");
                count++;
            }
            Console.WriteLine($"quantity : {count}");

            Console.ReadLine();
        }
    }
}
