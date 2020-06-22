using System;
using System.ComponentModel.DataAnnotations;
using aula.Entities;

namespace aula
{
    class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client{  Name = "Maria", Email = "maria@gmail.com"   };
            Client b = new Client{  Name = "Alex", Email = "alex@gmail.com"   };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a == b);
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
            /* Primeiro faz o GetHashCode pelo fato de ser mais rádipo e depois 
            confimar usando o Equals, que é mais preciso! */
        }
    }
}
