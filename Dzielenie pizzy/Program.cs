using System;
using System.Diagnostics;
using System.Text;

namespace Dzielenie_pizzy
{
    class Program
    {
        public static long ileKawalkow(long n)
        {
            Debug.Assert(n >= 1);
            if (n==1)
            {
                return 2;
            }
            return (n * n + n + 2) / 2;
        }




        static void Main(string[] args)
        {
            var results = new StringBuilder();
            int T = int.Parse(Console.ReadLine());

            for (int i = 1; i <= T; i++)
            {
                int n = int.Parse(Console.ReadLine());
                results.AppendLine(ileKawalkow(n).ToString());
            }
            Console.WriteLine(results.ToString());
        }
    }
}
