using System;
using System.Collections.Generic;
using System.Linq;
using aula.Entities;

namespace aula
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Product> list = new List<Product>();

			list.Add(new Product("TV", 900.00));
			list.Add(new Product("Mouse", 50.00));
			list.Add(new Product("Tablet", 350.50));
			list.Add(new Product("HD Case", 80.90));

			// OBS: Só usando as chaves {} no lambda quando for um método void ou seja que não retorne algo!

			// Func<Product, string> func = NameUpper; -> Forma alternativa criando o tipo Func e recebendo o método criado!
			// Func<Product, string> func = p => p.Name.ToUpper(); -> Forma alternativa usando o Lambda direto dentro da chamada do tipo Func!

			// List<string> result = list.Select(func).ToList(); -> Forma alternativa pegando o nome da variavel do tipo Func e passando como params!
			// List<string> result = list.Select(p => p.Name.ToUpper()).ToList(); -> Forma alternativa aplicando o	Lambda!
			List<string> result = list.Select(NameUpper).ToList();


			foreach (string s in result)
			{
				Console.WriteLine(s);
			}
		}

		// Forma alternativa -> Podemos criar um método de acordo com a operação e passar como params no select da lista!
		public static string NameUpper(Product p)
		{
			return p.Name.ToUpper();
		}
	}
}
