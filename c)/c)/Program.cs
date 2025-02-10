using System;

namespace c_
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Digite uma palavra: ");
			string palavra = Console.ReadLine();
		
			foreach (char letra in palavra) // Exibe os caractéres separados da palavra inserida
			{
					
				Console.WriteLine(letra);
			}
			
			Console.ReadKey(true);
		}
	}
}