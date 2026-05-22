using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeksegOOP
{
	internal abstract class Peksutemeny
	{
		private string nev;
		private int ar;
		private double mennyiseg;

		public Peksutemeny(string nev, int ar, double mennyiseg)
		{
			this.nev = nev;
			this.ar = ar;
			this.mennyiseg = mennyiseg;
		}

		protected string Nev { get => nev; set => nev = value; }
		protected int Ar { get => ar; set => ar = value; }
		protected double Mennyiseg { get => mennyiseg; set => mennyiseg = value; }

		public abstract void Megkostol();

		public override string ToString()
		{
			return $"{this.nev} {this.mennyiseg}darab/dkg {this.ar}FT";
		}
	}
}
