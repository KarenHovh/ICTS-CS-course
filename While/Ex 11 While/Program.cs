using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_11_While
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter number: ");
			int number = Convert.ToInt32(Console.ReadLine());

			int i = 1;
			double result = 1;

			while (i <= number)
			{
				result *= Convert.ToDouble($"1.{i}");
				i++;
			}


			Console.WriteLine($"The result is {result}");
			Console.WriteLine("Press any key to continue or press Esc to exit  ");

			Console.ReadKey();
		}
	}
}
