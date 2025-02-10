using System;

namespace a_
{
	public class Program
	{
		public static void Main(string[] args)
		{
			int i = 0;
			int numerosPar;
			
			Console.WriteLine("Todos os números pares entre 0 e 100: ");
			
			for (i = 0; i <= 100; i++)
			{
				if (i % 2 == 0)
				{
					Console.WriteLine(i);
				}
			}
			
			Console.ReadKey(true);
		}
	}
}