using System;

namespace h_
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Digite um número inteiro positivo: ");
			string input = Console.ReadLine();
			
			int numero;
			if (Int32.TryParse(input, out numero))
			{
				Console.WriteLine("Todos os divisores de {0}: ", numero);
				for (int i = 1; i <= numero; i++)
				{
					if (numero % i == 0) // Verifica se o número é divisível
					{
						Console.WriteLine(i);
					}
				}
			}
			else
			{
				Console.WriteLine("Número inválido! Por favor tente novamente.");
				Console.Clear();
			}
			
			Console.WriteLine("Pressione qualquer tecla para continuar...");
			Console.ReadKey(true);
		}
	}
}