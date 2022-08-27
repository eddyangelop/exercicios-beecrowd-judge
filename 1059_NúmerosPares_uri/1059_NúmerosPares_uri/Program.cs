using System;

namespace numeros_pares
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            x = 100;

            for (int i = 1; i <= x; i++)
            {
                if (i % 2 != 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
