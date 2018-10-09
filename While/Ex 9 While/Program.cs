using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_9_While
{
	class Program
	{
		static void Main(string[] args)
		{
			int N = 0;
			N = Convert.ToInt32(Console.ReadLine());
			float sum = 0f;
			int i = 2;
			while (i <= N)
			{
				sum += 1.0f / i;
				i++;
			}
			Console.WriteLine("N = {0} \n1 + 1/2 + 1/3 + … + 1/N = {1}", N, sum);
			Console.ReadKey();
		}
	}
}
