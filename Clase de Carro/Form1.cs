using Clase_de_Carro.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Clase_de_Carro
{
    public partial class Form1 : Form
    {
        ClsAutomotor carrito;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttoninicio_Click(object sender, EventArgs e)
        {
            carrito = new ClsAutomotor("Corolla", 250);
            carrito.color = "azul";


            buttonencender.Visible = true;

            buttoncrear.Visible = false;



            MessageBox.Show($"El carro = {carrito.marca} \n Llega a = {carrito.vel_max} KPH \n Es color = {carrito.color} ");
        }

        private void buttonencender_Click(object sender, EventArgs e)
        {
            buttonacelerar.Visible = true;
            buttonfrenodemano.Visible = true;
            buttonfrenando.Visible = true;
            buttoncambios.Visible = true;
            buttoncontinuar.Visible = true;
            buttonpausar.Visible = true;
            buttonreproducir.Visible = true;
            Buttondetener.Visible = true;

                
            
            labelEstado.Text =  carrito.Encender();
            
        }

        

        private void buttonacelerar_Click(object sender, EventArgs e)
        {
            buttonacelerar.Visible = carrito.cambiosveloc();
            if (carrito == null)
            {
                MessageBox.Show("Crea el carro primero");

            }
            else
            {
                labelestadovelocidad.Text = carrito.Acelerar();
            }
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonfrenodemano_Click(object sender, EventArgs e)
        {
            labelestadovelocidad.Text = carrito.Detenermarcha();
        }

        private void buttonfrenando_Click(object sender, EventArgs e)
        {
            labelestadovelocidad.Text = carrito.Frenando();
        }

        private void buttoncambios_Click(object sender, EventArgs e)
        {
            buttonacelerar.Visible = carrito.cambiosveloc();
            buttonacelerar.Show();
            labelvelocidades.Text = carrito.Velocidades();
            
        }

        WindowsMediaPlayer musica;
        private void buttonreproducir_Click(object sender, EventArgs e)
        {
           
            if (musica==null)
                {
                    musica = new WindowsMediaPlayer();
                    musica.URL = Application.StartupPath + @"/MP3/devuelta.mp3";
                    musica.controls.play();
                }
        }

        private void buttonpausar_Click(object sender, EventArgs e)
        {
            if(musica!=null)
            {
                musica.controls.pause();
            }
        }

        private void buttoncontinuar_Click(object sender, EventArgs e)
        {
            if (musica!=null)
            {
                double tiemp = musica.controls.currentPosition;
                musica.controls.currentPosition = tiemp;
                musica.controls.play();
            }
        }

        private void Buttondetener_Click(object sender, EventArgs e)
        {
            if (musica != null)
            {
                musica.controls.stop();
                musica = null;
            }
        }
        


    }
}
