using System;

public interface IPolecenie
{
    void wykonaj();
}

public class KomendaWlacz : IPolecenie
{
    Lampa lampa;
    public KomendaWlacz(Lampa lampa)
    {
        this.lampa = lampa;
    }
    public void wykonaj()
    {
        lampa.wlacz();
    }
}

public class KomendaWylacz : IPolecenie
{
    Lampa lampa;
    public KomendaWylacz(Lampa lampa)
    {
        this.lampa = lampa;
    }
    public void wykonaj()
    {
        lampa.wylacz();
    }
}


public class Lampa
{
    private bool stan;

    public bool sprawdz()
    {
        return stan;
    }

    internal void wylacz()
    {
        stan = false;
    }
    internal void wlacz()
    {
        stan = true;
    }
}


public class Pilot
{
    private IPolecenie polecenie;

    public void ustawPolecenie(IPolecenie c)
    {
        polecenie = c;
    }

    public void wcisnijGuzik()
    {
        polecenie.wykonaj();
    }

}


class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Pilot pilot = new Pilot();
        Lampa lampa = new Lampa();

        IPolecenie wlacz = new KomendaWlacz(lampa);
        IPolecenie wylacz = new KomendaWylacz(lampa);

        Console.WriteLine(lampa.sprawdz() ? "Lampa włączona" : "Lampa wyłączona");

        pilot.ustawPolecenie(wlacz);
        pilot.wcisnijGuzik();
        Console.WriteLine(lampa.sprawdz() ? "Lampa włączona" : "Lampa wyłączona");


        pilot.ustawPolecenie(wylacz);
        pilot.wcisnijGuzik();
        Console.WriteLine(lampa.sprawdz() ? "Lampa włączona" : "Lampa wyłączona");

    }
}