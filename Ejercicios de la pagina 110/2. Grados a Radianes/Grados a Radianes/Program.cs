using System;

namespace Grados_a_Radianes
{
    static class constasn
    {
        public const double PI = 3.1416;
    }
    class Program
    {
        static void Main(string[] args)  
        {
            double grados, radianes, resultado;
            string linea;
            int valor;

            System.Console.WriteLine("Para convertir radianes ingrese 1 para convertir grados ingrese 2.");
            linea = Console.ReadLine();

            valor = Convert.ToInt32(linea);

            if (valor==1)
            {
                System.Console.WriteLine("Ingrese la cantidad de radianes a convertir: ");
                linea = Console.ReadLine();

                radianes = Convert.ToDouble(linea);

                resultado = (radianes * 180) / constasn.PI;

                System.Console.WriteLine("Los radianes {0} equivalen a: {1} grados", radianes, resultado);
            }
            if (valor==2)
            {
                System.Console.WriteLine("Ingrese los grados a convertir: ");
                linea = Console.ReadLine();

                grados = Convert.ToDouble(linea);

                radianes = (grados * constasn.PI) / 180;

                System.Console.WriteLine("Los grados {0} en radianes equivale a: {1} radianes", grados, radianes);

            }

        }
    }
}
