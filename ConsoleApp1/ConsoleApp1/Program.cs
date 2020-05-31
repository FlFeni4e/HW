using System;

namespace LabDelegates
{
	class Program
	{
		private static int NumOfFunc;
		private static int Value;
		private static Func<int, double>[] funcs;

		static void Main(string[] args)
		{

			Console.WriteLine("Вводьте рядки послiдовно один за одним.\n" +
			"Поки вони матимуть вигляд 0 x чи 1 x чи 2 x\n" +
			"0 -- sqrt(abs(x))\n" +
			"1 -- x^3 (?накше кажучи, x*x*x)\n" +
			"2 -- x + 3,5\n" +
			"Якщо вхiдний рядок не задовольнятиме цей формат, програма завершить роботу.");

			while (true)
			{
				try
				{
					InputData();
					ThreeFuncs();
					Result();
				}
				catch(Exception)
				{
					Console.WriteLine("Введена некоректна iнформацiя. Натиснiть будь яку клавiшу, щоб завершити роботу...");
					Console.ReadKey();
					break;
				}
			}
		}

		private static void InputData()
		{
			var input = Console.ReadLine().Split(' ');
			NumOfFunc = int.Parse(input[0]);
			Value = int.Parse(input[1]);
		}

		private static void ThreeFuncs()
		{
			Func<int, double>[] functions = new Func<int, double>[3];
			functions[0] = x => Math.Sqrt(Math.Abs(x));
			functions[1] = x => Math.Pow(x, 3);
			functions[2] = x => x + 3.5;
			funcs = functions;
		}

		private static void Result()
		{
			Console.WriteLine(funcs[NumOfFunc](Value));
		}
	}
}