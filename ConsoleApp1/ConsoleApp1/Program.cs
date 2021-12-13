using System;
using System.Text;

public interface Lancuch
{
    void ustawNastepne(Lancuch c);
    void przetwarzaj(Powiadomienia powiadomienia);
}

public class Powiadomienia
{

    private int number;
    private int liczba;

    public Powiadomienia(int number)
    {
        this.number = number;
    }
    public int PobierzLiczbe()
    {
        public pobierzLiczbe(int liczba)
        {
            this.liczba = liczba;
        }
    }





    public class BrakLancuch : Lancuch
{

    private Lancuch nastepneWLancuchu;

    public void ustawNastepne(Lancuch c)
    {
        this.nastepneWLancuchu = c;
    }

    public void przetwarzaj(Powiadomienia powiadomienia)
    {
        if (powiadomienia.PobierzLiczbe() <= 0)
        {
            Console.WriteLine("Brak powiadomień: ");
        }
        else
        {
            Console.WriteLine($"Mało powiadomień: {powiadomienia.PobierzLiczbe() <= 5}");
            Console.WriteLine($"Dużo powiadomień: {powiadomienia.PobierzLiczbe() > 5}");
        }
    }
}


class Program
{
    static void Main(String[] args)
    {

        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Lancuch l1 = new BrakLancuch();
        Lancuch l2 = new BrakLancuch();
        Lancuch l3 = new BrakLancuch();
        Lancuch l4 = new BrakLancuch();
        Lancuch l5 = new BrakLancuch();

        int i = 0;
        l1.przetwarzaj(new Powiadomienia(i));
        i++;
        l2.przetwarzaj(new Powiadomienia(i));
        i++;
        l3.przetwarzaj(new Powiadomienia(i));
        i++;
        l4.przetwarzaj(new Powiadomienia(i));
        i++;
        l5.przetwarzaj(new Powiadomienia(i));
        i++;

    }
}