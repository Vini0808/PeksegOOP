using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeksegOOP
{
	internal class Pogacsa : Peksutemeny
	{
		public Pogacsa(string nev, int ar, double mennyiseg) : base(nev, ar, mennyiseg) { }
		public override void Megkostol()
		{
			Console.WriteLine("Ez egy sós pogácsa.");
		}
	}
}
