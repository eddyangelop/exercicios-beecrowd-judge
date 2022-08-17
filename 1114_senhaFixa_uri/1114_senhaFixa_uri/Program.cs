using System;

namespace senha_fixa
{
    class program
    {
        static void Main(string[] args)
        {
   

            int senha = int.Parse(Console.ReadLine());

     

            while (senha != 2002)
            {
                Console.WriteLine("Senha Invalida");
                senha = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Acesso Permitido");
            Console.ReadLine();

        }
    }
}

