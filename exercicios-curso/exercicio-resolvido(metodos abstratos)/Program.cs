using System;
using System.Collections.Generic;
using System.Globalization;
using aula.Entities.Enums;
using aula.Entities;

namespace aula
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++){
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Retangle or Circle (r/c)? ");
                char response = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if(response == 'r' || response == 'R'){
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Heigth: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Rectangle(color, width, height));
                }
                else  {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(color, radius));
                }
            }
            
            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS:");
            foreach(Shape shape in list){
                Console.WriteLine(shape.Area().ToString("f2", CultureInfo.InvariantCulture));
            }
        }
    }
}
