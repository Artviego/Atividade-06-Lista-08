using System;

namespace g_
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Tabuada do número 5 até o número 10");
			for(int i = 1; i <= 10; i++)
			{
				int resultado = 5 * i;
				Console.WriteLine("5 x {0} = {1}", i, resultado);
			}

			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}