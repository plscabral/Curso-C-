using System;
using System.Collections.Generic;

namespace aula
{
	class Program
	{
		static void Main(string[] args)
		{
			HashSet<int> A = new HashSet<int>();
			HashSet<int> B = new HashSet<int>();
			HashSet<int> C = new HashSet<int>();

			Console.Write("How many students for course A? ");
			int n = int.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				int numMatricula = int.Parse(Console.ReadLine());
				A.Add(numMatricula);
			}

			Console.Write("How many students for course B? ");
			n = int.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				int numMatricula = int.Parse(Console.ReadLine());
				B.Add(numMatricula);
			}

			Console.Write("How many students for course C? ");
			n = int.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				int numMatricula = int.Parse(Console.ReadLine());
				C.Add(numMatricula);
			}

			HashSet<int> all = new HashSet<int>(A);
			all.UnionWith(B);
			all.UnionWith(C);
			Console.WriteLine("Total students: " + all.Count);

		}
	}
}
