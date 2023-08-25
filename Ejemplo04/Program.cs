using System;

namespace Ejemplo04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero: ");
            string numeroTexto = Console.ReadLine();
            int numero = int.Parse(numeroTexto);
            bool esPar = numero % 2 == 0;
            if (esPar)
            {
                Console.WriteLine("Es par");
            }
            else {
                Console.WriteLine("Es impar");
            }
        }
    }
}
