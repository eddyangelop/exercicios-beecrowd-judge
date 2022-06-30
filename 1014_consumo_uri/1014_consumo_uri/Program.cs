using System;

// tag System.Globalization para transforma o sistema global.
using System.Globalization;

namespace consumo
{
    class Program {
    
        static void Main(string[] args) {

        int distPercorrida;
        double litUsados, consumo;

        distPercorrida = int.Parse(Console.ReadLine());
        litUsados = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        consumo = distPercorrida / litUsados;

        Console.WriteLine(consumo.ToString("F3", CultureInfo.InvariantCulture) + " km/l");

        }
    }
}