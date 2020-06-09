using System;
using System.Globalization;
using System.Collections.Generic;
using aula.Entities;

namespace aula
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            System.Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++){
                Console.WriteLine("Product #" + i + " data:");

                Console.Write("Common, used or imported (c/u/i)? ");
                char response = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                if(response == 'u' || response == 'U'){
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine()); 
                    list.Add(new UsedProduct(name, price, date));
                }
                else if(response == 'i' || response == 'I'){
                    Console.Write("Customs Fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customsFee));
                }
                else{
                    list.Add(new Product(name, price));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach(Product p in list){
                System.Console.WriteLine(p.PriceTag());
            }
        }
    }
}
