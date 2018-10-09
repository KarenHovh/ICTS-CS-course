using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_41
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k, j, binno = 0, sum;
            
            Console.Write("Enter a number to convert : ");
            n = Convert.ToInt32(Console.ReadLine());
            sum = n;
            k = 1;
            for (j = n; j > 0; j = j / 2)
            {
                binno = binno + (n % 2) * k;
                k = k * 10;
                n = n / 2;
            }

            Console.Write("\nThe Binary of {0} is {1}.\n\n", sum, binno);

            Console.ReadKey();
        }
    }
}
