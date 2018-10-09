using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write(" N  ");
			int N = int.Parse(Console.ReadLine());
			Console.Write("K   ");

			int K = int.Parse(Console.ReadLine());
			int i = 0;
			while (i < N)
			{

				Console.WriteLine(K);
				i++;
			}
			Console.ReadKey();
		}
	}
}
