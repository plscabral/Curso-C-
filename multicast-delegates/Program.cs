using aula.Services;
using System;

namespace aula
{
	delegate void BinaryNumreciOperation(double n1, double n2);
	class Program
	{
		static void Main(string[] args)
		{
			double a = 10;
			double b = 12;

			BinaryNumreciOperation op = CalculationService.ShowSum;
			op += CalculationService.ShowMax;

			op(a, b);
		}
	}
}
