﻿using System;

namespace aula
{
	class Program
	{
		static void Main(string[] args)
		{
			DateTime dt = new DateTime(2020, 06, 23, 8, 10, 45);
			Console.WriteLine(dt.ElapesdTime());

			string s1 = "Good morning dear students";
			Console.WriteLine(s1.Cut(10));
		}
	}
}
