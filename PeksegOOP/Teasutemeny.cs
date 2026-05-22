using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeksegOOP
{
	internal class Teasutemeny : Peksutemeny
	{
		private string iz;

		public Teasutemeny(string nev, int ar, double mennyiseg, string íz) : base(nev, ar, mennyiseg)
		{
			this.iz = iz;
		}

		public string Iz { get => iz; set => iz = value; }

		public override void Megkostol()
		{
			this.mennyiseg -= 1;
			Console.WriteLine($"A {this.iz} teasütemény nagyon finom!");
		}
		public override string ToString()
		{
			return $"{base.ToString()} {this.iz}";
		}
	}
}
