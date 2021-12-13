using System;

public interface Lancuch
{
    //
    //

    void ustawNastepne(Lancuch c);
    void Przetwarzaj(Powiadomienia powiadomienia);
    //
}

public class Powiadomienia
{

    private int number;

    public Powiadomienia(int number)
    {
        this.number = number;
    }

    public int pobierzLiczbe()
    {
        //
        return number;
        //
    }

}

public class BrakLancuch : Lancuch
{

    private Lancuch nastepneWLancuchu;

    public void ustawNastepne(Lancuch c)
    {
        nastepneWLancuchu = c;
    }
    public void Przetwarzaj(Powiadomienia powiadomienia)
    {
        if (powiadomienia.pobierzLiczbe() <= 0)
        {
            Console.WriteLine("Brak powiadomień");
        }
        else
        {
            nastepneWLancuchu.Przetwarzaj(powiadomienia);
        }
    }
}
public class MaloLancuch : Lancuch
{

    private Lancuch nastepneWLancuchu;

    public void ustawNastepne(Lancuch c)
    {
        nastepneWLancuchu = c;
    }
    public void Przetwarzaj(Powiadomienia powiadomienia)
    {
        if (powiadomienia.pobierzLiczbe() <= 5)
        {
            Console.WriteLine("Mało powiadomień: "+ powiadomienia.pobierzLiczbe());
        }
        else
        {
            nastepneWLancuchu.Przetwarzaj(powiadomienia);
        }
    }
}
public class DuzoLancuch : Lancuch
{

    private Lancuch nastepneWLancuchu;

    public void ustawNastepne(Lancuch c)
    {
        nastepneWLancuchu = c;
    }
    public void Przetwarzaj(Powiadomienia powiadomienia)
    {
        Console.WriteLine("Dużo powiadomień: " + powiadomienia.pobierzLiczbe());
    }
}


class Program
{
    static void Main(String[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Lancuch l1 = new BrakLancuch();
        Lancuch l2 = new MaloLancuch();
        Lancuch l3 = new DuzoLancuch();
        l1.ustawNastepne(l2);
        l2.ustawNastepne(l3);
        //
        //
        //

        int i = 0;
        l1.Przetwarzaj(new Powiadomienia(i));
        i++;

        l1.Przetwarzaj(new Powiadomienia(i));

        i = i + 11;
        l1.Przetwarzaj(new Powiadomienia(i));

        i = i - 9;
        l1.Przetwarzaj(new Powiadomienia(i));

        i = i - 3;
        l1.Przetwarzaj(new Powiadomienia(i));
       
        //
        //
        //

    }
}