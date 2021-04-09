using System;

namespace MediaAritmetica
{
    class Program
    {
        static void Main(string[] args)
        {


            double val1, val2, val3;
            double resul;

            Console.WriteLine();
            Console.WriteLine("--- Média Aritmética ---");
            Console.WriteLine("--> Cálculo da média aritmética entre 3 números reais digitados pelo usuário.");
            Console.WriteLine();

            Console.WriteLine("- Insira o primeiro valor:");
            Console.ForegroundColor = ConsoleColor.Red;
            val1 = Convert.ToDouble (Console.ReadLine());
            Console.ResetColor();
            Console.WriteLine();

            Console.WriteLine("- Insira o segundo valor:");
            Console.ForegroundColor = ConsoleColor.Red;
            val2 = Convert.ToDouble (Console.ReadLine());
            Console.ResetColor();
            Console.WriteLine();

            Console.WriteLine("- Insira o terceiro valor:");
            Console.ForegroundColor = ConsoleColor.Red;
            val3 = Convert.ToDouble (Console.ReadLine());
            Console.ResetColor();
            Console.WriteLine();

            resul = (val1 + val2 + val3) / 3;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"- Média: {resul:N2}");
            Console.ResetColor();






        }
    }
}
