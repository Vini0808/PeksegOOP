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
			Console.WriteLine(c2);

		}
	}
}
