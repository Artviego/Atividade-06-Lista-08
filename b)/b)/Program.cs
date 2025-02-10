using System;

namespace b_
{
	public class Program
	{
		public static void Main(string[] args)
		{
			int i = 0;
			
			Console.Write("Digite um número inteiro positivo: ");
			string input = Console.ReadLine();
			int numero;
			
			if (int.TryParse(input, out numero)&& numero > 0)
			{
				Console.WriteLine("Números pares entre 0 e {0}: ", numero);
				
				for (i = 0; i <= numero; i++)
				{
					if (i % 2 == 0)
					{
						Console.WriteLine(i);
					}
				}
				
			}
			else
			{
				Console.WriteLine("Número inválido! Tente novamente");
			}
			
			Console.ReadKey(true);
		}
	}
}