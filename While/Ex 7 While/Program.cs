using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_7_While
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("enter A ");
			int A = int.Parse(Console.ReadLine());
			Console.Write("enter B ");
			int B = int.Parse(Console.ReadLine());
			int Sum = 0;
			int i = A;
			if (A < B)
				while (i <= B)
				{
					Sum += i;
					i++;
				}
			else Console.WriteLine("B > A");
			Console.WriteLine($"sum of numbers {Sum}");
			Console.ReadKey();
		}
	}
}
