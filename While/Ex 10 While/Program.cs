using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_10_While
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("enter number ");
			int N = int.Parse(Console.ReadLine());
			Double Sum = 0;
			int i = 0;
			while (i <= N)
			{
				Sum += Math.Pow(N + i, 2);
				i++;
			}
			Console.WriteLine($"answer, {Sum}");
			Console.ReadKey();
		}
		}
	}
