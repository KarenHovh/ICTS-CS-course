using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int A =6;
            int B = 24;

            for (int i = A; i <= B; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                    break;
                }
            }

            Console.ReadLine();
        }
    }
}
