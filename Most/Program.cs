using System;


public interface ITelewizor
{

	int Kanal { get; set; }
	// 
	void Wlacz();
	//
	void Wylacz();
	void ZmienKanal(int kanal);

}

public class TvLg : ITelewizor
{

	public TvLg()
	{
		this.Kanal = 1;
	}

	public int Kanal { get; set; }

	public void Wlacz()
	{
		Console.WriteLine("Telewizor LG włączony.");
	}

	public void Wylacz()
	{
		//
		Console.WriteLine("Telewizor LG wyłączony.");
		//
	}

	public void ZmienKanal(int kanal)
	{
		//
		Console.WriteLine($"Telewizor LG, kanał: {kanal}");
		//
		Kanal = kanal;

	}

}



public class TvXiaomi : ITelewizor
{

	public TvXiaomi()
	{
		this.Kanal = 1;
	}

	public int Kanal { get; set; }

	public void Wlacz()
	{
		Console.WriteLine("Telewizor Xiaomi włączony.");
	}

	public void Wylacz()
	{
		//
		Console.WriteLine("Telewizor Xiaomi wyłączony.");
		//
	}

	public void ZmienKanal(int kanal)
	{
		//
		Console.WriteLine($"Telewizor Xiaomi, kanał: {kanal}");
		//
		Kanal = kanal;

	}

}



public abstract class PilotAbstrakcyjny
{

	private ITelewizor tv;

	public PilotAbstrakcyjny(ITelewizor tv)
	{
		//
		this.tv = tv;
		//
	}

	public void Wylacz()
	{
		tv.Wylacz();
	}

	public void Wlacz()
	{
		tv.Wlacz();
	}


	public void ZmienKanal(int kanal)
	{
		tv.ZmienKanal(kanal);
	}

}



public class PilotHarmony : PilotAbstrakcyjny
{

	public PilotHarmony(ITelewizor tv) : base(tv)
	{

	}

	public void DoWylacz()
	{
		Console.WriteLine("Pilot Harmony wyłącza telewizor...");
		Wylacz();
	}

	public void DoWlacz()
	{
		Console.WriteLine("Pilot Harmony włącza telewizor...");
		Wlacz();
	}

	public void DoZmienKanal(int kanal)
	{
		Console.WriteLine("Pilot Harmony zmienia kanał...");
		ZmienKanal(kanal);
	}

}

public class PilotPhilips : PilotAbstrakcyjny
{
	public PilotPhilips(ITelewizor tv) : base(tv)
	{

	}

	public void DoWylacz()
	{
		Console.WriteLine("Pilot Philips wyłącza telewizor...");
		Wylacz();
	}

	public void DoWlacz()
	{
		Console.WriteLine("Pilot Philips włącza telewizor...");
		Wlacz();
	}

	public void DoZmienKanal(int kanal)
	{
		Console.WriteLine("Pilot Philips zmienia kanał...");
		ZmienKanal(kanal);
	}

}





class MainClass
{
	public static void Main(string[] args)
	{
		Console.OutputEncoding = System.Text.Encoding.UTF8;

		ITelewizor tv = new TvLg();
		PilotPhilips pilotPhilips = new PilotPhilips(tv);
		PilotHarmony pilotHarmony = new PilotHarmony(tv);

		pilotHarmony.DoWlacz();
		Console.WriteLine("Kanał: " + tv.Kanal);
		pilotPhilips.DoZmienKanal(100);
		Console.WriteLine("Kanał: " + tv.Kanal);
		pilotHarmony.DoWylacz();

	}
}