using aula.Entities.Enums;

namespace aula.Entities
{
    public abstract class Shape
    {
        public Color Color { get; set; }

        protected Shape(Color color){
            Color = color;
        }

        public abstract double Area();
    }
}