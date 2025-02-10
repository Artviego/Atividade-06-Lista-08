using System;

namespace d_
{
	public class Program
	{
		public static void Main(string[] args)
		{
			int soma = 0;
			int numero;
			
			Console.Write("Digite um número inteiro positivo: ");
			string input = Console.ReadLine();
			
			if (int.TryParse(input, out numero)&& numero > 0)
			{
				int i = 1;
				for (i = 1; i <= numero; i++)
				{
					soma += i;
				}
			}
			else
			{
				Console.WriteLine("Entrada inválida! Por favor, digite um número inteiro: ");
			}
			
			Console.Write("A soma entre 1 e {0} é: {1}", numero, soma);
			Console.ReadKey(true);
		}
	}
}