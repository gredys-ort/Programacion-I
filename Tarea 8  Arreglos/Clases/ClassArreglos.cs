using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Arreglos.Clases
{
    class ClassArreglos
    {
        private int[] arreglotemporal;
        private int[] datos;
        private int i, j, datotemporal;
        private int tamañoarreglo = 0;

        public int gettamañoarreglo()
        {
            return datos.Length;
        }
        public ClassArreglos(int[]arregloparametro)
        {
            datos = arregloparametro;
            tamañoarreglo = datos.Length;
        }
        public int [] MetodoBurbuja()
        {
            arreglotemporal = datos;

            for(i=0; i<tamañoarreglo-1;i ++)
            {
                for(j=i+1; j<tamañoarreglo;j ++)
                {
                    if (arreglotemporal[i]>arreglotemporal[j])
                    {
                        datotemporal = arreglotemporal[i];
                        arreglotemporal[i] = arreglotemporal[j];
                        arreglotemporal[j] = datotemporal;
                    }
                }
            }
            return arreglotemporal;
        }

    }
}
