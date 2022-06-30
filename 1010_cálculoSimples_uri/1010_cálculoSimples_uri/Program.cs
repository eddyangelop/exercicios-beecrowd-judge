using System;

// tag System.Globalization para transforma o sistema global.
using System.Globalization;

namespace calculoSimples
{
    class Program
    {
        static void Main(string[] args)
        {

            double valorTotal;

            string[] vet1 = Console.ReadLine().Split(' ');

            int codPeca1 = int.Parse(vet1[0]);
            int quantPeca1 = int.Parse(vet1[1]);
            double valorPeca1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);

            valorPeca1 = valorPeca1 * quantPeca1;

            string[] vet2 = Console.ReadLine().Split(' ');

            int codPeca2 = int.Parse(vet2[0]);
            int quantPeca2 = int.Parse(vet2[1]);
            double valorPeca2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            valorPeca2 = valorPeca2 * quantPeca2;

            valorTotal = valorPeca1 + valorPeca2;



            Console.WriteLine("VALOR A PAGAR: R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}