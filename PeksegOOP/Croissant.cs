using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeksegOOP
{
	internal class Croissant : Peksutemeny
	{
		private string fajta;
		public Croissant(string nev, int ar, double mennyiseg, string fajta) : base(nev, ar, mennyiseg)
		{
			this.fajta = fajta;
		}

		public string Fajta { get => fajta; set => fajta = value; }
		public override void Megkostol()
		{
			this.mennyiseg -= 0.5;
			Console.WriteLine($"A {this.nev} {this.fajta} és nagyon finom!");
		}
		public override string ToString()
		{
			return $"{base.ToString()}";

		}
	}
}
