using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 8;
            int sum = 0;
            for (int i = 4; i < a; i += 2)
            {
                sum += i;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
