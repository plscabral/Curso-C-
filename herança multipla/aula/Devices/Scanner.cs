using System;

namespace aula.Devices
{
	class Scanner : Device, IScanner
	{
		public override void ProcessDoc(string documents)
		{
			Console.WriteLine("Scanner processing" + documents);
		}
		public string Scan()
		{
			return "Scanner Scan Result";
		}
	}
}
