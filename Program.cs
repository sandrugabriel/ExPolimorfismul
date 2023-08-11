using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
/*
        Fairy_tale tale;

        //Console.WriteLine("FAIRY TALE\n");
        //tale  = new Fairy_tale();
        //tale.act0();


        Console.WriteLine("UNHAPPY TALE\n");
        tale = new unhappy_tale();
        tale.act0();*/
/*
        Basm basm;

        Console.WriteLine("Basm\n");
        basm = new Basm();
        basm.act0();

        Console.WriteLine("Basm modificat\n");
        basm = new Basm_trist();
        basm.act0();*/

        Ustensila ustensila;

        ustensila = new Ustensila();
        ustensila.descriere1();

        ustensila = new Lingura();
        ustensila.descriere1();

        ustensila = new Paleta();
        ustensila.descriere1();
    }
}

class Fairy_tale
{
    public void act0() { Console.WriteLine("0 Inceput poveste originala\n"); act1(); }

    public virtual void act1() { Console.WriteLine("1 Printesa intilneste broscoiul \n"); act2(); }

    public void act2() { Console.WriteLine("2 Printesa saruta broscoiul \n"); act3(); }

    public virtual void act3() { Console.WriteLine("3 Broscoiul se transforma in Print \n"); act4(); }

    public virtual void act4() { Console.WriteLine("4 Si au trait multi ani fericiti\n"); act5(); }

    public void act5() { Console.WriteLine("5 Sfarsit fericit\n"); }

}

class unhappy_tale : Fairy_tale
{

    public void act0() { Console.WriteLine("0 Inceput poveste modificata\n"); act1(); }

    public override void act1() { Console.WriteLine("1 Printesa intilneste broscoiul\n"); act2(); }

    public void act2() { Console.WriteLine("2 Printesa atinge broscoiul \n"); act3(); }

    public override void act3() { Console.WriteLine("3 Broscoiul ramane broscoi \n"); act4(); }

    public override void act4() { Console.WriteLine("4 Printesa fuge ingrozita \n");  act5(); }

    public void act5() { Console.WriteLine("5 Sfirsit nu prea fericit\n"); }
}

class Basm
{

    public virtual void act0() { Console.WriteLine("0 Inceput poveste originala\n"); act1(); }

    public void act1() { Console.WriteLine("1 Printesa gaseste o casa\n"); act2(); }

    public void act2() { Console.WriteLine("2 Vine o batrana\n"); act3(); }

    public virtual void act3() { Console.WriteLine("3 Printesa mananca marul batranei\n"); act4(); }

    public virtual void act4() { Console.WriteLine("4 Vine printul si o saruta\n"); act5(); }

    public void act5() { Console.WriteLine("5 Se trezeste si au trait multi ani fericiti\n"); }

}

class Basm_trist : Basm
{

    public override void act0() { Console.WriteLine("0 Inceput poveste modificata\n"); base.act1(); }

    public void act1() { Console.WriteLine("1 Printesa gaseste o pestera\n"); act2(); }

    public override void act3() { Console.WriteLine("3 Printesa refuza marul batranei\n"); act4(); }

    public override void act4() { Console.WriteLine("4 Batrana pleaca\n"); act5(); }

    public void act5() { Console.WriteLine("5 Printesa este trista"); }

}

class Ustensila
{

    public void descriere0() { Console.WriteLine("Este folosita la ...\n"); }

    public virtual void descriere1() { Console.WriteLine("Acesta este o ustensila"); descriere0(); }


}

class Lingura : Ustensila
{

    public void descriere0() { Console.WriteLine("Este folosita la AMESTECAT\n"); }

    public override void descriere1() { Console.WriteLine("Acesta este o LINGURA"); descriere0(); }


}

class Paleta : Ustensila
{

    public void descriere0() { Console.WriteLine("Este folosita la INTOARCEREA MANCARI\n"); }

    public override void descriere1() { Console.WriteLine("Acesta este o PALETA"); base.descriere0(); }


}