using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_3_While
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write(" enter number  ");
			int N = int.Parse(Console.ReadLine());

			int i = 1;
			while (i <= 9)
			{
				Console.WriteLine($"{N}^{i} = {Math.Pow(N, i)} ");
				i++;
			}
			Console.ReadKey();
		}
	}
}
