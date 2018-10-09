using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_42
{
    class Program
    {
        static void Main(string[] args)
        {
            int k, n, p = 1;
            int dec = 0, i = 1, j, d;
          

            Console.Write("Input a number :");
            n = Convert.ToInt32(Console.ReadLine());
            k = n;
            for (j = n; j > 0; j = j / 10)
            {
                d = j % 10;
                if (i == 1)
                    p *= 1;
                else
                    p *= 2;

                dec = dec + (d * p);
                i++;
            }
            Console.Write("\nThe Binary Number : {0}\nThe equivalent Decimal  Number : {1} \n\n", k, dec);

            Console.ReadKey();
        }
    }
}
