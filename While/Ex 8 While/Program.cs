using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_8_While
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("enter num A ");
			int A = int.Parse(Console.ReadLine());
			Console.Write("enter num B ");
			int B = int.Parse(Console.ReadLine());
			if (A >= B)
				Console.WriteLine("B>A ");
		
			int i = A;
			while (i <= B)
			{
				if
				 (i % 3 == 0)
				{
					
					break;
				}
				i++;
			}
			
			Console.ReadKey();
		}
	}
}
