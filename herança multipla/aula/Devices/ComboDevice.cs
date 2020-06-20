using System;

namespace aula.Devices
{
	class ComboDevice : Device, IScanner, IPrinter
	{
		public override void ProcessDoc(string documents)
		{
			Console.WriteLine("ComboDevice print: " + documents);
		}

		public string Scan()
		{
			return "ComboDevice scan result";
		}

		public void Print(string documents)
		{
			Console.WriteLine("ComboDevice processing: " + documents);
		}

	}
}
