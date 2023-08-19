using ExPolimorfismul.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Punct punct1 = new Punct(12, 6);
        Punct punct2 = new Punct(17, 9);

        Eticheta eticheta = new Eticheta("text", punct1, punct2);
     /*   eticheta.afisare();
        eticheta.translatare(12,0);
        eticheta.duplicare();*/

        punct1.X += 10;
        punct2.X += 10;
        punct1.Y += 10;
        punct2.Y += 10;

        Console.WriteLine("\n");
        Figura linie = new Linie(punct1, punct2);
    /*    figura.afisare();
        figura.translatare(-5, 10);
        figura.duplicare();
*/
        Console.WriteLine("\n");
        Figura dreptunghi = new Dreptunghi(punct1 , punct2);
  /*      figura.afisare();
        figura.translatare(25, 25);
        figura.duplicare();*/

        punct1.X += 10;
        punct2.X += 10;
        punct1.Y += 10;
        punct2.Y += 10;
        Linie linie1 = new Linie(punct1,punct2);
        Punct punct3 = new Punct(64, 61);

        Console.WriteLine("\n");
        Figura cerc = new Cerc(linie1,punct3);
        /*        figura.afisare();
                figura.translatare(10, 5);
                figura.duplicare();
        */
        /*
                Console.WriteLine(punct3);*/

        List<Figura> figuri = new List<Figura>();
        figuri.Add(linie);
        figuri.Add(eticheta);
        figuri.Add(cerc);
        figuri.Add(dreptunghi);
        figuri.Add(punct1);


        Desen desen = new Desen(figuri);
        desen.afisare();
        desen.translatare(2, 4);
        desen.duplicare();
        desen.descriereDesen();
    }
}