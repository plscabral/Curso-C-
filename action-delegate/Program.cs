using System;
using System.Collections.Generic;
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

			// Action<Product> ac = UpdatePrice; -> Forma alternativa atribuindo o action ao mue método UpdatePrice!
			// Action<Product> ac = p => { p.Price += p.Price * 0.1; }; -> Forma alternativa usando lambda!

			// list.ForEach(ac); -> Forma alternativa usando um tipo action como parâmetro do metodo foreach da lista!
			// list.ForEach(p => { p.Price += p.Price * 0.1; }); -> Forma alternativa usando lambda dentro do metodo foreach da lista!

			list.ForEach(UpdatePrice);

			foreach (Product p in list)
			{
				Console.WriteLine(p);
			}
		}

		// Forma alternativa -> Pode criar um método que faça a operação desejada
		public static void UpdatePrice(Product p)
		{
			p.Price += p.Price * 0.1;
		}
	}
}
