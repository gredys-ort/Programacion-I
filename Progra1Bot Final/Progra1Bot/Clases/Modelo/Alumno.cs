using System;
using System.Collections.Generic;
using System.Text;

namespace Progra1Bot.Clases.Modelo
{
    class Alumno
    {
        private String id;
        private String nombre;
        private Double parcial1;
        private Double parcial2;
        private Double parcial3;
        private Double parcial4;
        private String seccion;

        public Alumno() { }

        public string Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Parcial1 { get => parcial1; set => parcial1 = value; }
        public double Parcial2 { get => parcial2; set => parcial2 = value; }
        public double Parcial3 { get => parcial3; set => parcial3 = value; }
        public double Parcial4 { get => parcial4; set => parcial4 = value; }
        public string Seccion { get => seccion; set => seccion = value; }

        public Alumno(string id, string nombre, double parcial1, double parcial2, double parcial3, double parcial4, string seccion)
        {
            this.Id = id;
            Nombre = nombre;
            Parcial1 = parcial1;
            Parcial2 = parcial2;
            Parcial3 = parcial3;
            Parcial4 = parcial4;
            Seccion = seccion;
        }


    }
}
