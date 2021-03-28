using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_de_Carro.Clases
{
    class ClsAutomotor
    {
        public string marca { get;  }
        public int vel_max { get;  }
        public string color { get; set; }

        private int velocidadactual = 0;
        public bool encendido { get; set; } = false;

        public ClsAutomotor(string marcacarro, int maxvel)
        {
            this.vel_max = maxvel;
            this.marca = marcacarro;
        }

        public string Encender()
        {
            string respuesta = "";
            if (encendido)
            {
                
                encendido = false;
                respuesta= "Carro Apagado";
            } else
            {
                
                encendido = true;
                respuesta=  "Carro Encendido, maneja con cuidado";
            }
            velocidadactual = 0;
            return respuesta;

        }


        public string Acelerar()
        {
           
            if(velocidadactual>vel_max)
            {
                velocidadactual = vel_max;
                return $"Para el carro ya no acelera mas ya llegaste a {vel_max} KPH ";
            }else
            {
                velocidadactual = velocidadactual + 10;
                return $"Vas a {velocidadactual} KPH";
            }
            
        }

        public string Detenermarcha()
        {
            if (!encendido)
            {
                return "Enciende el carro primero";
            }
            velocidadactual = 0;
            return "Auto detenido";
        }

        public string Frenando()
        {
            if (velocidadactual< 0)
            {
                velocidadactual = 0;
                return "!Acelera el carro esta detenido";
            }
            else
            {
                velocidadactual = velocidadactual - 10;
                return $"Vas a {velocidadactual} KPH";
            }
        }
        public string Velocidades()
        {
            if (!encendido)
            {
                return "Enciende el carro primero ";
            }
            string veloc = "";
            if(velocidadactual==10)
            {
                veloc="Primera Velocidad";
            }
            if(velocidadactual==40)
            {
                veloc = "Segunda Velocidad";
            }
            else if (velocidadactual==70)
            {
                veloc = "Tercera Velocida";
            }
            else if (velocidadactual == 130)
            {
                veloc = "Cuarta Velocida";
            }
            else if (velocidadactual == 190)
            {
                veloc = "Quinta Velocida";
            }
            return veloc;
        }
        public bool cambiosveloc()
        {
            bool cambiosveloc;
            switch(velocidadactual)
            {
                case 0:
                case 30:
                case 60:
                case 120:
                case 180:
                    cambiosveloc = false;
                    break;
                default:
                    cambiosveloc = true;
                    break;

            }
            return cambiosveloc;
        }
    }
}
