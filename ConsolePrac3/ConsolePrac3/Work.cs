using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsolePrac3
{
	class Work

	 
	{

		public enum teams
		{
			Champs = 1,
			Cavs,
			Spurs,
			Miami

		}
		public void Dude()
		{
			Console.WriteLine("No way Jose!!!");
		

		string[] pisano = { "words", "People", "now", "Sky" };

		for (int i = 0; i < pisano.Length; i++)
			{
				WriteLine(pisano[i]);
			}
			ReadKey();
		}

		public void BBall()
		{
			teams ballers = teams.Cavs;


			switch (ballers)
			{
				case teams.Champs:
					break;
				case teams.Cavs:
					break;
				case teams.Spurs:
					break;
				case teams.Miami:
					break;
				default:
					break;
			}
		}


	}
}
