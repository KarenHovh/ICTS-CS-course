using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_4
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = Convert.ToByte(Console.ReadLine());
            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine(Math.Pow(n, i));
            }
            Console.ReadKey();
        }
    }
}
