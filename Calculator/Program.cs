using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			char[] delimiters = { '+', '-', '*', '/'};
			char operation = ' ';
			double result = 0;
			
			string input = Console.ReadLine();			

			for(int i = 0; i < input.Length; i++)
			{				
				if (input[i] == '+' || input[i] == '-' || input[i] == '*' || input[i] == '/')
				{
					operation = input[i];
				}
			}

			string[] buffer = input.Split(delimiters);

			if(operation == '+')
			result = Convert.ToDouble(buffer[0]) + Convert.ToDouble(buffer[1]);
			if (operation == '-')
				result = Convert.ToDouble(buffer[0]) - Convert.ToDouble(buffer[1]);
			if (operation == '*')
				result = Convert.ToDouble(buffer[0]) * Convert.ToDouble(buffer[1]);
			if (operation == '/')
				result = Convert.ToDouble(buffer[0]) / Convert.ToDouble(buffer[1]);

			Console.WriteLine("=" + result);
		}
	}
}
