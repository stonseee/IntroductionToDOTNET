//#define ARRAYS_1
//#define ARRAYS_2
#define JAGGED_ARRAY
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
	internal class Program
	{
		static void Main(string[] args)
		{
#if ARRAYS_1
			//Console.Write("Введите размер массива: ");
			//int n = Convert.ToInt32(Console.ReadLine());
			//int[] arr = new[] { 3, 5, 8, 13, 21};
			//int[] arr = new[] { 3, 1, 0, 4, 2};
			//int[] arr = { 3, 5, 8, 13, 21};int[]
			int n = 7;
			int buffer;
			int max = Int32.MinValue;
			int min = Int32.MaxValue;
			double amount = 0;
			double middleLocatedArithmeticalResult = 0;
			int[] arr = new int[n];
			Random rand = new Random(0);
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = rand.Next(10);				
			}
			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i] + "\t");
			}
			Console.WriteLine();

			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] > max) max = arr[i];				
				if (arr[i] < min) min = arr[i];
				amount += arr[i];				
			}
			middleLocatedArithmeticalResult = amount / arr.Length;

			for (int i = 0; i < arr.Length; i++)
			{
				for (int j = 0; j < arr.Length - i - 1; j++)
				{
					if (arr[j] > arr[j + 1])
					{
						buffer = arr[j + 1];
						arr[j + 1] = arr[j];
						arr[j] = buffer;
					}
				}
			}

			Console.WriteLine($"maxilum = {max}\t minilum = {min}");
			Console.WriteLine($"amount = {amount}");
			Console.WriteLine($"middleLocatedArithmeticalResult = {middleLocatedArithmeticalResult}");

			foreach (int i in arr)
			{
				Console.Write(i + "\t");
			}
			Console.WriteLine(); 				
#endif

#if ARRAYS_2
			//Console.Write("Введите количество строк: ");
			//int rows = Convert.ToInt32(Console.ReadLine());

			//Console.Write("Введите количество элементов строки: ");
			//int cols = Convert.ToInt32(Console.ReadLine());

			//int[,] i_arr_2 = new int[rows, cols];
			int[,] i_arr_2 = new int[3, 7];
			int[] arr = new int[i_arr_2.GetLength(0) * i_arr_2.GetLength(1)];
			int buffer;
			int max = Int32.MinValue;
			int min = Int32.MaxValue;			
			double amount = 0;
			double middleLocatedArithmeticalResult = 0;
			int ctr = 0;

			//Console.WriteLine(i_arr_2.Rank);	

			Random rand = new Random(0);
			for (int i = 0; i < i_arr_2.GetLength(0); i++)
			{
				for (int j = 0; j < i_arr_2.GetLength(1); j++)
				{
					//i_arr_2[i, j] = rand.Next(100);
					i_arr_2[i, j] = rand.Next(20);
				}
			}

			for (int i = 0; i < i_arr_2.GetLength(0); i++)
			{
				for (int j = 0; j < i_arr_2.GetLength(1); j++)
				{
					Console.Write(i_arr_2[i, j] + "\t");
				}
				Console.WriteLine();
			}

			for (int i = 0; i < i_arr_2.GetLength(0); i++)
			{
				for (int j = 0; j < i_arr_2.GetLength(1); j++)
				{
					if (i_arr_2[i, j] > max) max = i_arr_2[i, j];
					if (i_arr_2[i, j] < min) min = i_arr_2[i, j];
					amount += i_arr_2[i, j];
				}
			}
			middleLocatedArithmeticalResult = amount / i_arr_2.Length;

			foreach (int i in i_arr_2)
			{
				arr[ctr] = i;
				++ctr;
			}
			for (int i = 0; i < arr.Length; i++)
			{
				for (int j = 0; j < arr.Length - i - 1; j++)
				{
					if (arr[j] > arr[j + 1])
					{
						buffer = arr[j + 1];
						arr[j + 1] = arr[j];
						arr[j] = buffer;
					}
				}
			}
			//for (int i = 0; i < arr.Length; i++)
			//{
			//	Console.Write(arr[i] + "\t");
			//}
			//Console.WriteLine();	

			ctr = 0;
			for (int i = 0; i < i_arr_2.GetLength(0); i++)
			{
				for (int j = 0; j < i_arr_2.GetLength(1); j++)
				{
					i_arr_2[i, j] = arr[ctr];
					++ctr;
				}				
			}

			Console.WriteLine($"maxilum = {max}\t minilum = {min}");
			Console.WriteLine($"amount = {amount}");
			Console.WriteLine($"middleLocatedArithmeticalResult = {middleLocatedArithmeticalResult}");

			for (int i = 0; i < i_arr_2.GetLength(0); i++)
			{
				for (int j = 0; j < i_arr_2.GetLength(1); j++)
				{
					Console.Write(i_arr_2[i, j] + "\t");
				}
				Console.WriteLine();
			}

			//foreach (int i in i_arr_2)
			//{
			//	Console.Write(i + "\t");				
			//}
			//Console.WriteLine();
#endif
#if JAGGED_ARRAY
			//for(int a = 0, b = 1, c = a + b; a < 1000; a = b, b = c, c = a + b)
			//{
			//	Console.Write(a + "\t");
			//}
			//Console.WriteLine();

			int[][] arr_jagged = new int[][]
			{
				new int[]{ 0, 1, 1, 2 },
				new int[]{ 3, 5, 8, 13, 21 },
				new int[]{ 34, 55, 89 },
				new int[]{ 144, 233, 377, 610, 987 }
			};

			
			int buffer;
			int max = Int32.MinValue;
			int min = Int32.MaxValue;
			double amount = 0;
			double middleLocatedArithmeticalResult = 0;
			int ctr = 0;
			Random rand = new Random(0);
			int size = 0;

			for (int i = 0; i < arr_jagged.Length; i++)
			{
				for (int j = 0; j < arr_jagged[i].Length; j++)
				{
					arr_jagged[i][j] = rand.Next(20);
					size++;
				}				
			}
			int[] arr = new int[size];

			for (int i = 0; i < arr_jagged.Length; i++)
			{
				for (int j = 0; j < arr_jagged[i].Length; j++)
				{
					if (arr_jagged[i][j] > max) max = arr_jagged[i][j];
					if (arr_jagged[i][j] < min) min = arr_jagged[i][j];
					amount += arr_jagged[i][j];
				}
			}
			middleLocatedArithmeticalResult = amount / size;

			for (int i = 0; i < arr_jagged.Length; i++)
			{
				for (int j = 0; j < arr_jagged[i].Length; j++)
				{
					Console.Write(arr_jagged[i][j] + "\t");
				}
				Console.WriteLine();
			}			

			for (int i = 0; i < arr_jagged.Length; i++)
			{
				for (int j = 0; j < arr_jagged[i].Length; j++)
				{					
					arr[ctr] = arr_jagged[i][j];
					++ctr;
				}
			}

			for (int i = 0; i < arr.Length; i++)
			{
				for (int j = 0; j < arr.Length - i - 1; j++)
				{
					if (arr[j] > arr[j + 1])
					{
						buffer = arr[j + 1];
						arr[j + 1] = arr[j];
						arr[j] = buffer;
					}
				}
			}

			ctr = 0;
			for (int i = 0; i < arr_jagged.Length; i++)
			{
				for (int j = 0; j < arr_jagged[i].Length; j++)
				{
					arr_jagged[i][j] = arr[ctr];
					++ctr;
				}
			}

			//for (int i = 0; i < arr.Length; i++)
			//{
			//	Console.Write(arr[i] + "\t");
			//}
			//Console.WriteLine();
			//Console.WriteLine();

			Console.WriteLine($"maxilum = {max}\t minilum = {min}");
			Console.WriteLine($"amount = {amount}");
			Console.WriteLine($"middleLocatedArithmeticalResult = {middleLocatedArithmeticalResult}");

			for (int i = 0; i < arr_jagged.Length; i++)
			{
				for (int j = 0; j < arr_jagged[i].Length; j++)
				{
					Console.Write(arr_jagged[i][j] + "\t");
				}
				Console.WriteLine();
			} 
#endif

		}
	}
}
