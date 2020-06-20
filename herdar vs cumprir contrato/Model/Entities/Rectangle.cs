using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace aula.Model.Entities
{
	class Rectangle : AbstractShape
	{
		public double Width { get; set; }
		public double Height { get; set; }

		public override double Area()
		{
			return Width * Width;
		}

		public override string ToString()
		{
			return "Rectangle color = "
				+ Color
				+ ", width = "
				+ Width.ToString("f2", CultureInfo.InvariantCulture)
				+ ", height = "
				+ Height.ToString("f2", CultureInfo.InvariantCulture)
				+ ", area = "
				+ Area().ToString("f2", CultureInfo.InvariantCulture);
		}
	}
}
