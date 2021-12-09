using System;
using System.Collections.Generic;

class Zycie
{
    private String Czas;

    public void set(String czas)
    {
        Console.WriteLine("Skok do roku: " + czas);
        this.Czas = czas;
    }

    public Pamiatka zapiszPamiatke()
    {
        Console.WriteLine("Stan Zapisany");
        return new Pamiatka(Czas);
    }

    public void przywrocPamiatke(Pamiatka pamiatka)
    {
        Czas = pamiatka.pobierzCzas();
        Console.WriteLine("Przywrócono rok: " + Czas);
    }

    public class Pamiatka
    {
        private String Czas;

        public Pamiatka(String czas)
        {
            Czas = czas;
        }

        public String pobierzCzas()
        {
            return Czas;    
        }
    }
}


class MainClass
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Powrot do przyszlosci (Back to the Future)");
        Console.WriteLine();

        List<Zycie.Pamiatka> zapisaneStany = new List<Zycie.Pamiatka>();
        Zycie zycie = new Zycie();

        zycie.set("1985");
        zapisaneStany.Add(zycie.zapiszPamiatke());
        zycie.set("1955");
        zapisaneStany.Add(zycie.zapiszPamiatke());
        zycie.set("2015");
        zapisaneStany.Add(zycie.zapiszPamiatke());
        zycie.set("1885");

        zycie.przywrocPamiatke(zapisaneStany[0]);

    }
}