using System;

public interface IClient
{
    string GetData();
}

public class RealClient : IClient
{
    readonly string Data;

    public RealClient()
    {
        Console.WriteLine("RealClient: Initialized");
        Data = "WSEI data";
    }

    public string GetData()
    {
        return Data;
    }
}


public class ProxyClient : IClient
{
    RealClient client = null;
    private RealClient _client;
    readonly bool _authenticated;
    readonly string _pass = "dobrehaslo";

    public ProxyClient(string password)
    {
        if (password == _pass)
        {
            _authenticated = true;
            Console.WriteLine("ProxyClient: Initialized");
        }
        else
        {
            _authenticated = false;
            Console.WriteLine("ProxyClient: Access deined");
        }
    }

    public string GetData()
    {
        string result = string.Empty;
        if (_authenticated)
        {
            _client = new RealClient();
            result = $"Data from proxy Client = {_client.GetData()}";
        }
        return result;
        //
        //
    }
}


class Program
{
    static void Main(string[] args)
    {

        ProxyClient proxy1 = new ProxyClient("zlehaslo");
        Console.WriteLine(proxy1.GetData());

        ProxyClient proxy2 = new ProxyClient("dobrehaslo");
        Console.WriteLine(proxy2.GetData());

    }

}
