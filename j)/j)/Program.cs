using System;

namespace j_
{
	class Program
	{
		public static void Main(string[] args)
		{
			int soma = 0;
			Console.WriteLine("A soma dos números pares entre 1 e 100 é: ");
			for (int numero = 1; numero <= 100; numero++)
			{
				if (numero % 2 == 0)
				{
					soma += numero;
				}
			}
			
			Console.Write(soma);
			Console.ReadKey(true);
		}
	}
}