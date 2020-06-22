using System;
using System.Collections.Generic;
using aula.Entities;

namespace aula
{
	class Program
	{
		static void Main(string[] args)
		{
			HashSet<Alunos> set = new HashSet<Alunos>();

			Console.Write("How many students for course A? ");
			int alunosA = int.Parse(Console.ReadLine());
			for(int i = 0; i < alunosA; i++){
				int numMatricula = int.Parse(Console.ReadLine());
				set.Add(new Alunos(numMatricula));
			}
		}
	}
}
