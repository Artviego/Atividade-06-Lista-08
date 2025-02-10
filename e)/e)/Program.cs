using System;

namespace e_
{
	class Program
	{
		public static void Main(string[] args)
		{
			int numero;
			
			Console.WriteLine("Digite um número e o programa dirá se ele é primo ou não");
			Console.Write("Digite o número intiero: ");
			string input = Console.ReadLine();
			
			int.TryParse(input, out numero);
			if (IsPrime(numero))
			{
				Console.WriteLine("{0} é primo", numero);
			}
			else
			{
				Console.WriteLine("{0} não é primo", numero);
			}
			
			Console.ReadKey();
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