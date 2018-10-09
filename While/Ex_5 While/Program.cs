using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_5_While
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("enter num A ");
			int A = int.Parse(Console.ReadLine());
			Console.Write("enter num B ");
			int B = int.Parse(Console.ReadLine());
			int i = A;
			if (A < B)
				while (i <= B)
				{
					Console.WriteLine($"{i}");
					i++;
				}
			else Console.WriteLine(" B < A ");
			int C = (B + A) + 1;
			Console.WriteLine($"sum will be {C}");
			Console.ReadKey();

		}
	}
}
