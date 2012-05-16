using System;
using NumerosRomanosTeste;

namespace ConsoleApplicationTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Digite um numero inteiro:");
                string numeroString = Console.ReadLine();
                var conv = new ConversorRomano();
                string resultado;
                try
                {
                    int numero = Convert.ToInt32(numeroString);
                    resultado = conv.ConverterDecimal(numero);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("FIM!");
                    Console.ReadLine();
                    return;
                }
                Console.WriteLine(resultado);
            }
        }
    }
}
