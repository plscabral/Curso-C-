using System;
using System.Collections.Generic;
using aula.Entities;

namespace aula
{
	class Program
	{
		static void Main(string[] args)
		{
			/* Quando usamos classe e estamos instanciando um objeto igualzinho e o programa sempre aponta 
			 * como 'false' é porque a nossa classe não tem implementado o GetHashCode e o Equals. Agora quando
			 * usamos um struct ele vai olhar diretamente para o conteudo do objeto e não para a referencia de memoria
			 * a qual está sendo instânciada */

			HashSet<Product> a = new HashSet<Product>();
			a.Add(new Product("TV", 900.00));
			a.Add(new Product("Notebook", 1200.00));

			HashSet<Point> b = new HashSet<Point>();
			b.Add(new Point(3, 4));
			b.Add(new Point(5, 10));

			Product prod = new Product("Notebook", 1200.00);
			Console.WriteLine(a.Contains(prod));

			Point p = new Point(5, 10);
			Console.WriteLine(b.Contains(p));

		}
	}
}
