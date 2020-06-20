using aula.Model.Enums;

namespace aula.Model.Entities
{
	abstract class AbstractShape : IShape
	{
		public Color Color { get; set; }

		public abstract double Area();
	}
}
