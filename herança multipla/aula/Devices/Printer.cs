using System;
using System.Collections.Generic;
using System.Text;

namespace aula.Devices
{
	class Printer : Device, IPrinter
	{
		public override void ProcessDoc(string documents)
		{
			Console.WriteLine("Printer processing: " + documents);
		}

		public void Print(string documents)
		{
			Console.WriteLine("Printer print: " + documents);
		}
	}
}
