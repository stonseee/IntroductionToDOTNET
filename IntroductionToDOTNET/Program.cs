//#define CONSOLE_CLASS
//#define STRING_OPERATIONS
//#define HARD_CHESS
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToDOTNET
{
    internal class Program
    {
        static readonly string delimiter = "\n-------------------------------------------\n";
        static void Main(string[] args)
        {
#if CONSOLE_CLASS
			Console.Title = "Introduction to .NET";
            Console.WriteLine("\t\t\tHello .NET");
            //Console.CursorLeft = 25;
            //Console.CursorTop = 8;
            Console.SetCursorPosition(21, 5);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Привет .NET");
            Console.ResetColor();

            Console.WriteLine(delimiter);

			#region ConsoleWindowParameters
            Console.WriteLine("Позиция окна консоли: " + Console.WindowLeft + " знакопозиций");
            Console.WriteLine("Позиция окна консоли: " + Console.WindowTop + " знакопозиций");

            Console.SetWindowSize(91, 22);
            Console.WriteLine("Ширина окна консоли: " + Console.WindowWidth + " знакопозиций");
            Console.WriteLine("Высота окна консоли: " + Console.WindowHeight + " знакопозиций");

            Console.SetBufferSize(91, 22);
            Console.WriteLine("Ширина буфера консоли: " + Console.BufferWidth + " знакопозиций");
            Console.WriteLine("Высота буфера консоли: " + Console.BufferHeight + " знакопозиций");

			#endregion
#endif
#if STRING_OPERATIONS
            Console.Write("Введите ваше имя: ");
            string first_name = Console.ReadLine();

            Console.Write("Введите вашу фамилию: ");
            string last_name = Console.ReadLine();

            Console.Write("Введите ваш возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(first_name + " " + last_name + " " + age);                  //конкатенация строк
            Console.WriteLine(String.Format("{0} {1} {2}", first_name, last_name, age));  //форматирование строк
            Console.WriteLine($"{first_name} {last_name} {age}");                         //интерполяция строк
#endif

#if HARD_CHESS
            int scale = 4;
            int size = 3;
            char a = '*';
            char b = '-';

            for (int m = 0; m < scale * 2; m++)
            {
                for (int n = 0; n < size; ++n)
                {
                    for (int i = 0; i < scale; i++)
                    {
                        for (int j = 0; j < size; j++)
                            Console.Write(a + " ");

                        for (int j = 0; j < size; j++)
                            Console.Write(b + " ");

                        if (i == scale - 1)
                            Console.WriteLine("");
                    }
                }
                if (m % 2 == 0)
                {
                    a = '-';
                    b = '*';
                }
                else
                {
                    a = '*';
                    b = '-';
                }
            }       
#endif

			int scale = 5;
            char sym = '*';
            char fym = '*';

            for(int i = 0; i < scale; ++i)
            {
                for(int j = 0; j < scale; ++j)
                {
                    if (j < scale - 1)
                        Console.Write("* ");
                    else
                        Console.WriteLine("* ");
                }
            }

			Console.WriteLine("");
			Console.WriteLine("");

			for (int i = 0; i < scale; ++i)
			{
				for (int j = 0; j < scale; ++j)
				{
                    if (i >= j)
                        sym = '*';
                    else
                        sym = ' ';

					if (j < scale - 1)
						Console.Write(sym + " ");
					else
						Console.WriteLine(sym + " ");
				}
			}

			Console.WriteLine("");
			Console.WriteLine("");

			for (int i = 0; i < scale; ++i)
			{
				for (int j = 0; j < scale; ++j)
				{
					if (j < scale - i)
						sym = '*';
					else
						sym = ' ';

					if (j < scale - 1)
						Console.Write(sym + " ");
					else
						Console.WriteLine(sym + " ");
				}
			}

			Console.WriteLine("");
			Console.WriteLine("");

			for (int i = 0; i < scale; ++i)
			{
				for (int j = 0; j < scale; ++j)
				{
					if (i <= j)
						sym = '*';
					else
						sym = ' ';

					if (j < scale - 1)
						Console.Write(sym + " ");
					else
						Console.WriteLine(sym + " ");
				}
			}

			Console.WriteLine("");
			Console.WriteLine("");

			for (int i = 0; i < scale; ++i)
			{
				for (int j = 0; j < scale; ++j)
				{
					if (j >= scale - i - 1)
						sym = '*';
					else
						sym = ' ';

					if (j < scale - 1)
						Console.Write(sym + " ");
					else
						Console.WriteLine(sym + " ");
				}
			}

			Console.WriteLine("");
			Console.WriteLine("");

			scale *= 2;

			for (int i = 0; i < scale; ++i)
			{
				for (int j = 0; j < scale; ++j)
				{					
					if (j == scale - (i - scale / 2) - 1 || i == scale / 2 - j - 1)						
						sym = '/';
					else if (j == scale / 2 + i || i == scale / 2 + j)
						sym = '\\';					
					else
						sym = ' ';

					if (j < scale - 1)
						Console.Write(sym);
					else
						Console.WriteLine(sym);
				}
			}

			Console.WriteLine("");
			Console.WriteLine("");
		}
	}
}
