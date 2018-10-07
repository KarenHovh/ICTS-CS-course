using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;
            int res = 0;

            for (int i =x; i <=y; i++)
            {
                res += i;
            }

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
