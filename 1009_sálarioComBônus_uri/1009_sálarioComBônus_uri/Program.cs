using System;
using System.Globalization;

namespace salarioComBonus
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salarioFixo, bonus, total;


            nome = (Console.ReadLine());
            salarioFixo = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            total = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            total = total * 15 / 100 + salarioFixo;


            Console.WriteLine("TOTAL = R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
