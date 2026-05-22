using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeksegOOP
{
	internal class Kave : IArlap
	{
		private int ar;
		private bool habosE;

		public Kave(int ar, bool habosE)
		{
			this.ar = ar;
			this.habosE = habosE;
		}

		public int Ar { get => ar; set => ar = value; }
		public bool HabosE { get => habosE; set => habosE = value; }

		public int MennyibeKerul()
		{
			return this.habosE ? (int)(this.ar * 1.5) : this.ar;
		}

		public override string ToString()
		{
			return $"Kávé: {this.MennyibeKerul()}Ft {(this.habosE? "(Habos)" :"")} ";
		}
	}
}
