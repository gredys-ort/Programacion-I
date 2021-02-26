using System;

namespace _1._Tabla_de_multiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, a, resul;
            string lin;
            Console.Write("Ingrese el número que desea saber la tabla de multiplicar: ");
            lin = Console.ReadLine();
            num = int.Parse(lin);
            a = 1;
            while ((a <= 10))
            {
                resul = num * a;
                Console.WriteLine("{0} * {1} = {2}", num, a, resul);
                a = a + 1;
            }
            Console.ReadLine();
        }
    }
}
