using System;
using System.Globalization;

namespace gastoDeCombustível
{
    class Program
    {
        static void Main(string[] args)
        {


            int horas, km;
            double gastoCombust;

            double consumo = 12;

            horas = int.Parse(Console.ReadLine());
            km = int.Parse(Console.ReadLine());


            gastoCombust = horas * km / consumo;

            Console.WriteLine(gastoCombust.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
