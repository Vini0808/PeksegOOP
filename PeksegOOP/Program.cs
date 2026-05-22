namespace PeksegOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pogacsa p1 = new Pogacsa("Sajtos pogi", 120, 5);

			Console.WriteLine(p1);
            p1.Megkostol();
            Console.WriteLine(p1);

            Teasutemeny t = new Teasutemeny("teasüti", 100, 15, "csokis");
			Teasutemeny t1 = new Teasutemeny("teasüti", 110, 15, "baracklekváros");
            Pogacsa p2 = new Pogacsa("Tepertős pogi", 120, 5);

            p2.Megkostol();
			Console.WriteLine(p2);

			t.Megkostol();
			Console.WriteLine(t);
            t1.Megkostol();
			Console.WriteLine(t1);

            Croissant c1 = new Croissant("Croissant", 150, 10, "csokisSok");
            Croissant c2 = new Croissant("Croissant", 150, 10, "sajtosSok");

			Console.WriteLine(c1);
            c1.Megkostol();
			Console.WriteLine(c2);
            c2.Megkostol();


            List<IArlap> termekek = new List<IArlap>() {p1, p2, t, t1, c1, c2};
            termekek.Add(new Kave(220, true));
			termekek.Add(new Kave(220, false));
			termekek.Add(new Kave(180, true));

            foreach (var item in termekek)
            {
                 Console.WriteLine(item);
			}

		}
	}
}
