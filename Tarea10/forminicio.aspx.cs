using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tarea10.Clases_Tarea10;

namespace Tarea10
{
    public partial class forminicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void cargarArchivo()
        {
            string fuente = @"C:\Users\Usuario\Documents\Archivos scv\crudDB.csv";
            cls_archivo ar = new cls_archivo();
            cls_sqlserver cn = new cls_sqlserver();

            string[] arreglonotas = ar.LeerArchivo(fuente);
            string sentencia_sql = "";
            int numerolinea = 0;

            foreach(string linea in arreglonotas)
            {
                string[] datos = linea.Split(';');
                if (numerolinea>0)
                {
                    sentencia_sql = $"insert into TablaEstudiantes values({datos[0]},'{datos[1]}',{datos[2]},{datos[3]},{datos[4]},{datos[5]},'{datos[6]}');\n";
                    cn.EjecutaSQLDirecto(sentencia_sql);
                }
                numerolinea++;
            }
            numerolinea = 0;
            
        }
        public DataTable Cargardatosdb(string condicion="1=1")
        {
            cls_sqlserver cn = new cls_sqlserver();
            DataTable dt = new DataTable();
            string sentencia = $"select * from TablaEstudiantes where {condicion}";
            dt = cn.consultaTablaDirecta(sentencia);
            return dt;
        }
            

        protected void ButtonCardatos_Click(object sender, EventArgs e)
        {
            cargarArchivo();
        }

        protected void ButtonbuscarID_Click(object sender, EventArgs e)
        {
            string id = TextBoxID.Text.Trim();
            string condicion = $"correlativo = {id}";
            DataTable dt = Cargardatosdb(condicion);

            if(dt.Rows.Count>0)
            {
                string nombre = dt.Rows[0].Field<string>("nombre");
                TextBoxNombre.Text = nombre;
            }else
            {
                TextBoxNombre.Text = "NO HAY INFORMACION";
            }
        }

        protected void Buttonbuscpornombre_Click(object sender, EventArgs e)
        {
            string nombre = TextBoxNombre.Text.Trim();
            cls_sqlserver cn = new cls_sqlserver();
            DataTable dt = new DataTable();
            string sentencia = $"select * from TablaEstudiantes where nombre like ('%{nombre}%')";

            dt = cn.consultaTablaDirecta(sentencia);
            if (dt.Rows.Count > 0)
            {
                int id = dt.Rows[0].Field<Int32>("correlativo");
                TextBoxID.Text = id+"";
            }
            else
            {
                TextBoxID.Text = "NO HAY INFORMACION";
            }
        }
        private void cargarArchivoMY()
        {
            string fuente = @"C:\Users\Usuario\Documents\Archivos scv\crudDB.csv";
            cls_archivo ar = new cls_archivo();
            cls_mysql fo = new cls_mysql();

            string[] arreglonotas = ar.LeerArchivo(fuente);
            string sentencia_mysql = "";
            int numerolinea = 0;

            foreach (string linea in arreglonotas)
            {
                string[] datos = linea.Split(';');
                if (numerolinea > 0)
                {
                    sentencia_mysql = $"insert into estudiantes values({datos[0]},'{datos[1]}',{datos[2]},{datos[3]},{datos[4]},{datos[5]},'{datos[6]}');\n";
                    fo.EjecutaSQLDirecto(sentencia_mysql);
                }
                numerolinea++;
            }
            numerolinea = 0;

        }
        public DataTable CargardatosdbMY(string condicion = "1=1")
        {
            cls_mysql fa = new cls_mysql();
            DataTable dt = new DataTable();
            string sentencia = $"select * from estudiantes where {condicion}";
            dt = fa.consultaTablaDirecta(sentencia);
            return dt;
        }

        protected void ButtonCargardatosMysql_Click(object sender, EventArgs e)
        {
            cargarArchivoMY();
        }

        protected void ButtonBUSCARIDMY_Click(object sender, EventArgs e)
        {
            string id = TextBoxBuscarIDMY.Text.Trim();
            string condicion = $"correlativo = {id}";
            DataTable dt = CargardatosdbMY(condicion);

            if (dt.Rows.Count > 0)
            {
                string nombre = dt.Rows[0].Field<string>("nombres");
                TextBoxBuscarpornombreMY.Text = nombre;
            }
            else
            {
                TextBoxBuscarpornombreMY.Text = "NO HAY INFORMACION";
            }
        }

        protected void ButtonBUSCARNOMMY_Click(object sender, EventArgs e)
        {
            string nombre = TextBoxBuscarpornombreMY.Text.Trim();
            cls_mysql sn = new cls_mysql();
            DataTable dt = new DataTable();
            string sentencia = $"select * from estudiantes where nombres like ('%{nombre}%')";

            dt = sn.consultaTablaDirecta(sentencia);
            if (dt.Rows.Count > 0)
            {
                int id = dt.Rows[0].Field<Int32>("correlativo");
                TextBoxBuscarIDMY.Text = id + "";
            }
            else
            {
                TextBoxBuscarIDMY.Text = "NO HAY INFORMACION"; 
            }
        }
    }
}