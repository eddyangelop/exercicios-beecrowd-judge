using System;
using System.Globalization;

namespace salario
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUMBER, horasTrabalhadas;
            double valorHora, salario;

            NUMBER = int.Parse(Console.ReadLine());
            horasTrabalhadas = int.Parse(Console.ReadLine());
            valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = horasTrabalhadas * valorHora;

            Console.WriteLine("NUMBER = " + NUMBER);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}