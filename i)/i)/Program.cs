using System;

namespace i_
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Todos os números primos entre 1 e 100: ");
			
			for (int numero = 1; numero <= 100; numero++)
			{
				if (IsPrime(numero))
				{
					Console.WriteLine(numero);
				}
			}
			
			Console.WriteLine("Pressione qualquer tecla para continuar...");
			Console.ReadKey(true);
		}
		
		
		public static bool IsPrime(int numero)
		{
			if (numero <= 1)
			{
				return false;
			}
			else
			{
				for (int i = 2; i <= Math.Sqrt(numero); i++)
				{
					if (numero % i == 0)
					{
						return false;
					}
				}
				
				return true;
			}
		}
	}
}