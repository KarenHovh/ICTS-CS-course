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
			Console.Write("enter number ");
			int N = int.Parse(Console.ReadLine());
			int Sum = 0;
			int i = 2;
			while (i < N)
			{
				Sum += i;
				i += 2;
			}
			Console.WriteLine($"  sum of pair of natural numbers  = {Sum}");
			Console.ReadKey();
		}
	}
}
