﻿using System;

interface Stan
{
    void alert();
}
class Powiadomienia : Stan
{
    private Stan aktualnyStan;
    public Powiadomienia()
    {
        aktualnyStan = new Dzwonek();
    }

    public void alert()
    {
        aktualnyStan.alert();   
    }

    public void ustawStan(Stan stan)
    {
        aktualnyStan = stan;    
    }    
}
class Dzwonek : Stan
{
    public void alert()
    {
        Console.WriteLine("dzwonek...");
    }
}
class Wibracja : Stan
{
    public void alert()
    {
        Console.WriteLine("wibracja...");
    }
}
class Wyciszenie : Stan
{
    public void alert()
    {
        Console.WriteLine("wyciszenie...");
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Powiadomienia powiadomienia = new Powiadomienia();
        
        powiadomienia.ustawStan(new Wibracja());
        powiadomienia.alert();
        powiadomienia.ustawStan(new Dzwonek());
        powiadomienia.alert();
        powiadomienia.ustawStan(new Wyciszenie());
        powiadomienia.alert();
        powiadomienia.ustawStan(new Wyciszenie());
        powiadomienia.alert();
        powiadomienia.ustawStan(new Wibracja());
        powiadomienia.alert();
    }
}