using System;

namespace f_
{
	class Program
	{
		public static void Main(string[] args)
		{
			int maiorNumero = int.MinValue; // Inicializa com o menor valor possível de um inteiro
			int numeroAtual;
			
			Console.WriteLine("Digite uma sequência de 5 números inteiros: ");
			int i = 0;
			for (i = 0; i < 5; i++) // Limita a uma sequência de 5
			{
				Console.Write("Digite um número: ");
				string input = Console.ReadLine();
				
				 // Converte a entrada para um núermo inteiro
				 int.TryParse(input, out numeroAtual);
				 if (numeroAtual > maiorNumero)
				 {
				 	maiorNumero = numeroAtual;
				 }
			}
			
			// Exibe o maior número
			if (maiorNumero != int.MinValue)
			{
				Console.WriteLine("O maior número digitado é: {0}", maiorNumero);
			}
			else
			{
				Console.WriteLine("Nnehum número válido foi inserido.");
			}
			
			Console.Write("Pressione qualquer tecla para sair...");
			Console.ReadKey(true);
		}
	}
}