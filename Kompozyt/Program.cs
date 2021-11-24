using System;
using System.Collections.Generic;

public interface Kompozyt
{
    //
    void DodajElement(Kompozyt element);
    void UsunElement(Kompozyt element);
    void Renderuj();
}

public class Lisc : Kompozyt
{

    public string nazwa { get; set; }

    public void DodajElement(Kompozyt element)
    {
        throw new NotImplementedException();
    }

    public void Renderuj()
    {
        Console.WriteLine(nazwa + " renderowanie...");
    }

    public void UsunElement(Kompozyt element)
    {
        Wezel wezel = new Wezel();
        wezel.Lista.Remove(element);
    }


    // konstruktor

    // 2 brakujące metody których wymaga interfejs

}


public class Wezel : Kompozyt
{

    public List<Kompozyt> Lista = new List<Kompozyt>();

    public string nazwa { get; set; }

    public void DodajElement(Kompozyt element)
    {
        Lista.Add(element);
    }

    public void Renderuj()
    {
        //rozpoczęcie renderowania
        Console.WriteLine($"{nazwa} rozpoczecie renderowania");

        //foreach item.Renderuj();
        foreach (var item in Lista)
        {
            item.Renderuj();
        }

        //zakończenie renderowania
        Console.WriteLine($"{nazwa} zakończenie renderowania");
        
    }

    public void UsunElement(Kompozyt element)
    {
        Lista.Remove(element);
    }

    // 2 brakujące metody 

}


class MainClass
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Wezel korzen = new Wezel();
        korzen.nazwa = "Korzeń";
        Lisc lisc11 = new Lisc();
        lisc11.nazwa = "Liść 1.1";
        korzen.DodajElement(lisc11);

        Wezel wezel2 = new Wezel();
        wezel2.nazwa = "Węzeł 2";
        korzen.DodajElement(wezel2);

        Lisc lisc21 = new Lisc();
        lisc21.nazwa = "Liść 2.1";
        wezel2.DodajElement(lisc21);

        Lisc lisc22 = new Lisc();
        lisc22.nazwa = "Liść 2.2";
        wezel2.DodajElement(lisc22);

        Lisc lisc23 = new Lisc();
        lisc23.nazwa = "Liść 2.3";
        wezel2.DodajElement(lisc23);




        Wezel wezel3 = new Wezel();
        wezel3.nazwa = "Węzeł 3";
        korzen.DodajElement(wezel3);

        Lisc lisc31 = new Lisc();
        lisc31.nazwa = "Liść 3.1";
        wezel3.DodajElement(lisc31);

        Lisc lisc32 = new Lisc();
        lisc32.nazwa = "Liść 3.2";
        wezel3.DodajElement(lisc32);




        Wezel wezel4 = new Wezel();
        wezel4.nazwa = "Węzeł 3.3";
        wezel3.DodajElement(wezel4);

        Lisc lisc41 = new Lisc();
        lisc41.nazwa = "Liść 3.3.1";
        wezel4.DodajElement(lisc41);




        korzen.Renderuj();

    }
}