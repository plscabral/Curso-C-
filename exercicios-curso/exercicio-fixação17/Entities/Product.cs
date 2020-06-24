using System;
using System.Collections.Generic;
using System.Text;

namespace aula.Entities
{
	class Product
	{
		public string Name { get; set; }
		public double Price { get; set; }

		public Product(string name, double price)
		{
			Name = name;
			Price = price;
		}
	}
}
