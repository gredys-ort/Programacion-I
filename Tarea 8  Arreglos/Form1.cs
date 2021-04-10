using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea_Arreglos.Clases;

namespace Tarea_Arreglos
{
    public partial class Form1 : Form
    {
        private string[] ArregloNotas;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonarreglo_Click(object sender, EventArgs e)
        {
            int[] arreglo = new int[5];
            arreglo[0] = 20;
            arreglo[1] = 7;
            arreglo[2] = 18;
            arreglo[3] = 2;
            arreglo[4] = 40;
            
            ClassArreglos objetoarreglo = new ClassArreglos(arreglo);
            int[] resultado = objetoarreglo.MetodoBurbuja();


            foreach (int final in resultado)
            {
                listBoxresultado.Items.Add(final);
            }
           
        }

        private void buttonCargarArchivo_Click(object sender, EventArgs e)
        {
            ClsArchivo arch = new ClsArchivo();
            OpenFileDialog msj = new OpenFileDialog();

            msj.Title = "Porfa, Selecciona tu archivo plano";
            msj.InitialDirectory = @"C:\Users\Usuario\Documents\Archivo Plano";
            msj.Filter = "Archivo Plano (*.csv)|*.csv";

            if(msj.ShowDialog() == DialogResult.OK)
            {
                var archivo = msj.FileName;
                string resultado = arch.LeerTodoArchivo(archivo);
                ArregloNotas = arch.LeerArchivo(archivo);
                textBoxresultado.Text = resultado;
            }
            

                
        }

        private void buttonNombres_Click(object sender, EventArgs e)
        {
            foreach(string linea in ArregloNotas)
            {
                string[] datosUnitarios = linea.Split(';');
                listBoxresultado.Items.Add(datosUnitarios[0]);

            }
        }

        private void buttonPromedioAlumno_Click(object sender, EventArgs e)
        {
            int PrimerParcial;
            int SegundoParcial;
            int TercerParcial;
            int SumaPromedio;
            int Promedioporalumno;


            foreach (string linea in ArregloNotas)
            {
                string[] datosUnitarios = linea.Split(';');
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                PrimerParcial = Convert.ToInt32(datosUnitarios[1]);
                SegundoParcial = Convert.ToInt32(datosUnitarios[2]);
                TercerParcial = Convert.ToInt32(datosUnitarios[3]);

                SumaPromedio = (PrimerParcial + SegundoParcial + TercerParcial);
                Promedioporalumno = SumaPromedio / 3;

                listBoxresultado.Items.Add($"{datosUnitarios[0]} su promedio es de: {Promedioporalumno}");
            }
           
           
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            listBoxresultado.Items.Clear();
        }

        private void buttonPromedioGeneral_Click(object sender, EventArgs e)
        {
            int PrimerParcial ;
            int SegundoParcial ;
            int TercerParcial ;
            int SumaNotaPrimer = 0;
            int SumaNotaSegunda = 0;
            int SumaNotaTercer = 0;
            int PromePirmer ;
            int PromeSegun ;
            int Prometer ;
            


            foreach (string linea in ArregloNotas)
            {
                string[] datosUnitarios = linea.Split(';');
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                PrimerParcial = Convert.ToInt32(datosUnitarios[1]);
                SegundoParcial = Convert.ToInt32(datosUnitarios[2]);
                TercerParcial = Convert.ToInt32(datosUnitarios[3]);

                SumaNotaPrimer += PrimerParcial;
                SumaNotaSegunda += SegundoParcial;
                SumaNotaTercer += TercerParcial;
                
            }
            PromePirmer = SumaNotaPrimer / 60;
            PromeSegun = SumaNotaSegunda / 60;
            Prometer = SumaNotaTercer / 60;

            listBoxresultado.Items.Add($"Suma Total del Primer Parcial: {SumaNotaPrimer} Promedio Gemneral del Primer Parcial:{PromePirmer}"); 
            listBoxresultado.Items.Add($"Suma Total del Segundo Parcial: {SumaNotaSegunda} Promedio General del Segundo Parcial:{PromeSegun}");
            listBoxresultado.Items.Add($"Suma Total del Tercer Parcial: {SumaNotaTercer} Promedio General del Tercer Parcial:{Prometer}");
        }

        private void buttonMaxMin_Click(object sender, EventArgs e)
        {
            int PrimerParcial;
            int SegundoParcial;
            int TercerParcial;
            int SumaPromedio;
            int Promedioporalumno;
            int Maximo = 0;
            int Minimo = 20;


            foreach (string linea in ArregloNotas)
            {
                string[] datosUnitarios = linea.Split(';');
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                PrimerParcial = Convert.ToInt32(datosUnitarios[1]);
                SegundoParcial = Convert.ToInt32(datosUnitarios[2]);
                TercerParcial = Convert.ToInt32(datosUnitarios[3]);

                SumaPromedio = (PrimerParcial + SegundoParcial + TercerParcial);
                Promedioporalumno = SumaPromedio / 3;
                if (Promedioporalumno != 0)
                {
                    if (Promedioporalumno>Maximo)
                    {
                        Maximo = Promedioporalumno;
                    }
                    if(Promedioporalumno<Minimo)
                    {
                        Minimo = Promedioporalumno;
                    }
                }
                else
                {
                    Maximo = Promedioporalumno;
                    Minimo = Promedioporalumno;
                }

               
            }
            listBoxresultado.Items.Add($"Promedio Maximos es: {Maximo} y Promedio Minimo es: {Minimo}");
        }

        private void buttonnombresOrdenados_Click(object sender, EventArgs e)
        {
            string[] alumnos = ArregloNotas;
            string comparador;
            for (int lineas = 1; lineas <= alumnos.Length; lineas++)
            {
                for (int posicion = 0; posicion < alumnos.Length - 1; posicion++)
                {
                    if (alumnos[posicion].CompareTo(alumnos[posicion + 1]) > 0)
                    {
                        comparador = alumnos[posicion];
                        alumnos[posicion] = alumnos[posicion + 1];
                        alumnos[posicion + 1] = comparador;
                    }
                }
            }
            foreach (string ordenado in ArregloNotas)
            {
                string[] datosUnitarios = ordenado.Split(';');
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                listBoxresultado.Items.Add(ordenado);
            }
        }
    }
}
