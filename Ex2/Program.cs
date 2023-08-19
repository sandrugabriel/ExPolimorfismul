using Ex2;

internal class Program
{
    private static void Main(string[] args)
    {

        List<Cladire> cladiri = new List<Cladire>();

        Cladire casa = new Casa(25,2);
        Cladire primarie = new Primarie(56, 25, "Sadu");
        Cladire scoala = new Scoala("Sadu", 1, 3);
        Cladire magazin = new Magazin(24, 24,"Doi pasi");

        cladiri.Add(casa);
        cladiri.Add(primarie);
        cladiri.Add(scoala);
        cladiri.Add(magazin);

        Desen desen = new Desen(cladiri);

        desen.afisare();
        desen.duplicare();
        desen.translatare(12, 12);
        desen.afisare();


    }
}