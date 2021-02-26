using System;

namespace _2._Numero_elevado
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero;
            double potencia;
            double resultado = 1;
            int i;
            Console.Write("Escriba una potencia: ");
            potencia = Convert.ToDouble(Console.ReadLine());
            Console.Write("Escriba un numero: ");
            numero = Convert.ToDouble(Console.ReadLine());
            for (i = 1; i <= potencia; i++)
            {
                resultado = (resultado * numero);
            }
            Console.WriteLine("Su resultado es: " + resultado);
            Console.ReadKey();
        }
    }
}
