using System;
using System.Diagnostics;
using System.Text;

namespace Dzielenie_ciasta
{
    class Program
    {
        public static long ileKawalkow(long n)
        {
            if (n <= 1)
            {
                return 0;
            }
            double delta = Math.Sqrt((n*2 - 2 )*4 + 1)-2;
            if (delta % 2 != 0)
            {
                return Convert.ToInt64(delta) / 2 + 1;
            }
            return Convert.ToInt64(delta) / 2;
        }




        static void Main()
        {
            var results = new StringBuilder();
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                results.AppendLine(ileKawalkow(long.Parse(Console.ReadLine())).ToString());
            }
            Console.WriteLine(results.ToString());
        }
    }
}
