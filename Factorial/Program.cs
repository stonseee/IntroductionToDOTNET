using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
	internal class Program
	{
		static void Main(string[] args)
		{
			decimal num = 0;
			decimal result = 1;
			string buffer = Console.ReadLine();
			num = Convert.ToDecimal(buffer);

			for(int i = 0; i < num; i++)
			{		
				result *= i + 1;
			}

			Console.WriteLine("result " + result);	
			
		}
	}
}
