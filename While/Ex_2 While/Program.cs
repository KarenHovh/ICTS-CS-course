using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_2_While
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write(" enter number  ");
			int N = int.Parse(Console.ReadLine());
			int i = 10;
			if (N > 0 || N < 10)

				while (i < N)
				{
					Console.WriteLine(i);
					i++;
				}
			else Console.WriteLine(" enter number ");
			Console.ReadKey();
		}
	}
}
