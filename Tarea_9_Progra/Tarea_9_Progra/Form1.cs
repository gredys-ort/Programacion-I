using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea_9_Progra.Clases;

namespace Tarea_9_Progra
{
    public partial class Form1 : Form
    {
        private string[] ArregloNotas;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cls_conectar cn = new cls_conectar();
           
            foreach (string linea in ArregloNotas)

            {
                string[] datos = linea.Split(';');
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                string cuerito = $"insert into tb_estudiantes values('{datos[0]}','{datos[1]}','{datos[2]}','{datos[3]}','{datos[4]}')";
                cn.consultaTablaDirecta(cuerito);
            }

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cls_archivo ar = new cls_archivo();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Porfa Selecciona tu Archivo Plano";
            ofd.InitialDirectory = @"C: \Users\alumno\Desktop\datos Texto.csv";
            ofd.Filter = "Archivo Plano (*.csv)|*.csv";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var archivo = ofd.FileName;
                string resultado = ar.LeerTodoArchivo(archivo);
                ArregloNotas = ar.LeerArchivo(archivo);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cls_mysql cn = new cls_mysql();
            foreach (string linea in ArregloNotas)

            {
                string[] datos = linea.Split(';');
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                string cuerito = $"insert into tb_estudiantes values('{datos[0]}','{datos[1]}','{datos[2]}','{datos[3]}','{datos[4]}')";
                cn.consultaTablaDirecta(cuerito);
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            cls_oracle cn = new cls_oracle();
            foreach (string linea in ArregloNotas)

            {
                string[] datos = linea.Split(';');
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                string cuerito = $"insert into TB_ESTUDIANTES values('{datos[0]}','{datos[1]}','{datos[2]}','{datos[3]}','{datos[4]}')";
                cn.consultaTablaDirecta(cuerito);
            }

        }
    }
}
