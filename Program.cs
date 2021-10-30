using System;

namespace ParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            double n;

            Console.Beep();
            Console.Clear();

            Console.Write("Digite um número : ");
            n = double.Parse(Console.ReadLine());

            if(n % 2 == 0)
            {
                Console.Write($"{n} é");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(" Par");
                Console.ResetColor();
            }
            else 
            {
                Console.Write($"{n} é");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(" Ímpar");
                Console.ResetColor();
            }
        }
    }
}
