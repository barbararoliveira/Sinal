using System;

namespace Sinal
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero; 

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine(" -----  Negativo, Zero ou Positivo ----- \n");
                            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Digite um número: ");
                           numero = Convert.ToDouble(Console.ReadLine());

            if (numero >= 1 )
                Console.WriteLine("Positivo.");

            else if (numero <=-1)
                     Console.WriteLine("Negativo.");

            else if (numero == 0)
                     Console.WriteLine("Zero.");
            
            Console.WriteLine ("Pressione enter para finalizar.");
            Console.ReadKey();
            
        }
    }
}
