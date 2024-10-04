using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	internal class Program
	{
		static void Main(string[] args)
		{
			char key;
			char[,] mass = new char[10, 20];
			int x = 0;
			int y = 0;

			for (int i = 0; i < 10; i++)
			{
				for (int j = 0; j < 20; j++)
				{
					mass[i, j] = '-';
				}
			}
			
			mass[y, x] = (char)88; 

			for (int i = 0; i < 10; i++)
			{
				for (int j = 0; j < 20; j++)
				{
					Console.Write(mass[i, j]);
					if(j == 19)Console.Write('\n');
				}
			}			

			do
			{
				key = Console.ReadKey(true).KeyChar;
				//Console.WriteLine($"{(int)key}\t{key}");
				Console.Clear();

				mass[y, x] = '-';

				if (key == 100)
				{					
					x += 1;
					if (x == 20) x = 0;
				}

				if (key == 115)
				{
					y += 1;
					if (y == 9) y = 0;
				}

				if (key == 97)
				{
					x -= 1;
					if (x == -1) x = 19;
				}

				if (key == 119)
				{
					y -= 1;
					if (y == -1) y = 9;
				}

				mass[y, x] = (char)88;

				for (int i = 0; i < 10; i++)
				{
					for (int j = 0; j < 20; j++)
					{
						Console.Write(mass[i, j]);
						if (j == 19) Console.Write('\n');
					}
				}

			} while (true);
		}
	}
}
