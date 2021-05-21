using PrimerProyecto.CLASES.ARCHIVOS;
using PrimerProyecto.CLASES.CONEXIONES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using Window = System.Windows.Window;
using DataTable = System.Data.DataTable;


namespace PrimerProyecto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadGrid();
            
        }
        SqlConnection cn = new SqlConnection(@"Data Source=LAPTOP-2FL6TIV9\SQLSERVER_G;Initial Catalog=Proyecto_Final;Integrated Security=True");
        private void CargarArchivoExterno()
        {

            string fuente = @"C:\Users\Usuario\Documents\Archivos scv\MEDICINA.csv";
            ClsArchivo ar = new ClsArchivo();

            //obtener todo el archivo de un arreglo
            string[] ArregloNotas = ar.LeerArchivo(fuente);
            string SentenciaSql = "";

            int NumeroLinea = 0;

            //iteramos sobre el arreglo, linea por linea
            //para luego convertirlos en datos individuales
            ClsConexionSql cn= new ClsConexionSql();
            foreach (string linea in ArregloNotas)
            {
                string[] datos = linea.Split(';');
                if (NumeroLinea > 0)
                {
                    SentenciaSql = $"insert into TbMedicina values({datos[0]},'{datos[1]}',{datos[2]},{datos[3]},'{datos[4]}')";
                    cn.consultaTablaDirecta(SentenciaSql);
                }
                NumeroLinea++;
            }

        }

        private void CargarArchivoExternoMySql()
        {
            string fuente = @"C:\Users\Usuario\Documents\Archivos scv\MEDICINA.csv";
            ClsArchivo ar = new ClsArchivo();

            //obtener todo el archivo de un arreglo
            string[] ArregloNotas = ar.LeerArchivo(fuente);
            string SentenciaSql = "";

            int NumeroLinea = 0;

            //iteramos sobre el arreglo, linea por linea
            //para luego convertirlos en datos individuales
            ClsConexionMySql cn = new ClsConexionMySql();
            foreach (string linea in ArregloNotas)
            {
                string[] datos = linea.Split(';');
                if (NumeroLinea > 0)
                {
                    SentenciaSql = $"insert into medicina values({datos[0]},'{datos[1]}',{datos[2]},{datos[3]},'{datos[4]}')";
                    cn.consultaTablaDirecta(SentenciaSql);
                }
                NumeroLinea++;
            }

        }

        private void LoadGrid()
        {
            SqlCommand cmd = new SqlCommand("select * from TbMedicina", cn);
            DataTable dt = new DataTable();
            cn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            cn.Close();
            DGconsultas.ItemsSource = dt.DefaultView;
        }
        public bool isValied()
        {
            if (TexboxIdProducto.Text==string.Empty)
            {
                MessageBox.Show("Nombre fallido","Failed", MessageBoxButton.OK,MessageBoxImage.Error);
                return false;
            }
            if (TexboxIdProducto.Text == string.Empty)
            {
                MessageBox.Show("Nombre fallido", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (TexboxCantidad.Text == string.Empty)
            {
                MessageBox.Show("Nombre fallido", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (TexboxPrecio.Text == string.Empty)
            {
                MessageBox.Show("Nombre fallido", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (TexboxFecha.Text == string.Empty)
            {
                MessageBox.Show("Nombre fallido", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
        }
        private void ButtonAgregar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (isValied())
                {
                    SqlCommand cmd = new SqlCommand("insert into TbMedicina values (@Codigo,@producto,@Cantidad,@Precio,@Fecha)", cn);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Codigo", TexboxIdProducto.Text);
                    cmd.Parameters.AddWithValue("@Producto", TexboxProducto.Text);
                    cmd.Parameters.AddWithValue("@Cantidad", TexboxCantidad.Text);
                    cmd.Parameters.AddWithValue("@Precio", TexboxPrecio.Text);
                    cmd.Parameters.AddWithValue("@Fecha", TexboxFecha.Text);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    LoadGrid();
                    MessageBox.Show("Registrado Con Exito", "Registrado", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void ButtonConectarSql_Click(object sender, RoutedEventArgs e)
        {
            CargarArchivoExterno();
        }

        private void ButtonConectarMySql_Click(object sender, RoutedEventArgs e)
        {
            CargarArchivoExternoMySql();
            this.Hide();
            Ventana2 nuevaventana = new Ventana2();
            nuevaventana.Show();
        }

        private void ButtonUpdate_Click(object sender, RoutedEventArgs e)
        {
            string nom = TexboxProducto.Text;
            string can = TexboxCantidad.Text;
            string pre = TexboxPrecio.Text;
            string fech = TexboxFecha.Text;
            string id = TexboxIdProducto.Text;
            cn.Open();
            SqlCommand cmd = new SqlCommand($"update TbMedicina set Producto = '{nom}', Cantidad ='{can}',Precio='{pre}',Fecha='{fech}' where Codigo = {id}",cn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro Actualizado", "Actualizado", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            catch(SqlException ex)
            {
                MessageBox.Show("Registro Actualizado" + ex.Message);
            }
            finally
            {
                cn.Close();
                LoadGrid();
            }

        }

        private void ButtonEliminar_Click(object sender, RoutedEventArgs e)
        {
            cn.Open();
            string id = TexboxIdProducto.Text;
            SqlCommand cmd = new SqlCommand($"delete from TbMedicina where Codigo={id}", cn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro Eliminado", "Eliminado",MessageBoxButton.OK,MessageBoxImage.Information);
                cn.Close();
                LoadGrid();
                cn.Close();
            }catch(SqlException ex)
            {
                MessageBox.Show("Registro No Borrado"+ex.Message);
            }
            finally
            {
                cn.Close();
                LoadGrid();
            }
        }

        private void ButtonBuscarTodo_Click(object sender, RoutedEventArgs e)
        {
            LoadGrid();
        }

        public void ClearData()
        {
            TexboxProducto.Clear();
            TexboxPrecio.Clear();
            TexboxIdProducto.Clear();
            TexboxFecha.Clear();
            TexboxCantidad.Clear();
            TexboxBusqueda.Clear();

        }


        private void Limpiar_Click(object sender, RoutedEventArgs e)
        {
            ClearData();
        }

        private void ButtonExportarEx_Click(object sender, RoutedEventArgs e)
        {
            {
                Excel.Application excel = new Excel.Application();
                excel.Visible = true; 
                Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
                Worksheet sheet1 = (Worksheet)workbook.Sheets[1];

                for (int j = 0; j < DGconsultas.Columns.Count; j++) 
                {
                    Range myRange = (Range)sheet1.Cells[1, j + 1];
                    sheet1.Cells[1, j + 1].Font.Bold = true; 
                    sheet1.Columns[j + 1].ColumnWidth = 15; 
                    myRange.Value2 = DGconsultas.Columns[j].Header;
                }
                for (int i = 0; i < DGconsultas.Columns.Count; i++)
                { 
                    for (int j = 0; j < DGconsultas.Items.Count; j++)
                    {
                        TextBlock b = DGconsultas.Columns[i].GetCellContent(DGconsultas.Items[j]) as TextBlock;
                        Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[j + 2, i + 1];
                        myRange.Value2 = b.Text;
                    }
                }
            }
        }
        private void BuscarDatos()
        {
            string bs = TexboxBusqueda.Text;
            SqlCommand cmd = new SqlCommand($"select * from TbMedicina where Fecha='{bs}'", cn);
            DataTable dt = new DataTable();
            cn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            cn.Close();
            DGconsultas.ItemsSource = dt.DefaultView;
        }
        private void ButtonBuscar_Click(object sender, RoutedEventArgs e)
        {
            
            DGconsultas.ItemsSource = null;
            BuscarDatos();
            ClearData();
        }
    }
}
