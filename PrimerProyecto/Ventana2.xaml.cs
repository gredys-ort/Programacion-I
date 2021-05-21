using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;


using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using Window = System.Windows.Window;
using DataTable = System.Data.DataTable;
using MySql.Data.MySqlClient;
using System.Data;

namespace PrimerProyecto
{
    /// <summary>
    /// Lógica de interacción para Ventana2.xaml
    /// </summary>
    public partial class Ventana2 : Window
    {
        public Ventana2()
        {
            InitializeComponent();
            LoadGrid();
        }
        MySqlConnection cn = new MySqlConnection(@"Data Source=localhost;port=3306;username=root;password=MYSQL2021;database=proyectofinal");
        private void LoadGrid()
        {
            MySqlCommand cmd = new MySqlCommand("select * from medicina", cn);
            DataTable dt = new DataTable();
            cn.Open();
            MySqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            cn.Close();
            DGconsultas.ItemsSource = dt.DefaultView;
        }
        public bool isValied()
        {
            if (TexboxIdProducto.Text == string.Empty)
            {
                MessageBox.Show("Codigo fallido", "Fallido", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (TexboxProducto.Text == string.Empty)
            {
                MessageBox.Show("Producto fallido", "Fallido", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (TexboxCantidad.Text == string.Empty)
            {
                MessageBox.Show("Cantidad fallida", "Fallido", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (TexboxPrecio.Text == string.Empty)
            {
                MessageBox.Show("Precio fallido", "Fallido", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (TexboxFecha.Text == string.Empty)
            {
                MessageBox.Show("Fecha fallida", "Fallido", MessageBoxButton.OK, MessageBoxImage.Error);
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
                    MySqlCommand cmd = new MySqlCommand("insert into medicina values (@Codigo,@producto,@Cantidad,@Precio,@Fecha)", cn);
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
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
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
        private void ButtonUpdate_Click(object sender, RoutedEventArgs e)
        {
            string nom = TexboxProducto.Text;
            string can = TexboxCantidad.Text;
            string pre = TexboxPrecio.Text;
            string fech = TexboxFecha.Text;
            string id = TexboxIdProducto.Text;
            cn.Open();
            MySqlCommand cmd = new MySqlCommand($"update medicina set Producto = '{nom}', Cantidad ='{can}',Precio='{pre}',Fecha='{fech}' where Codigo = {id}", cn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro Actualizado", "Actualizado", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Registro no Actualizado" + ex.Message);
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
            MySqlCommand cmd = new MySqlCommand($"delete from proyectofinal.medicina where Codigo={id}", cn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro Eliminado", "Eliminado", MessageBoxButton.OK, MessageBoxImage.Information);
                cn.Close();
                LoadGrid();
                cn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Registro No Borrado" + ex.Message);
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

        private void BuscarDatos()
        {
            string bs = TexboxBusqueda.Text;
            MySqlCommand cmd = new MySqlCommand($"select * from medicina where Fecha='{bs}'", cn);
            DataTable dt = new DataTable();
            cn.Open();
            MySqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            cn.Close();
            DGconsultas.ItemsSource = dt.DefaultView;
        }
        private void ButtonBuscar_Click(object sender, RoutedEventArgs e)
        {
            DGconsultas.ItemsSource = null;
            BuscarDatos();
        }
        private void ButtonRegresarDB_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow ventanaPrincipal = new MainWindow();
            ventanaPrincipal.Show();


            cn.Open();
            string id = TexboxIdProducto.Text;
            MySqlCommand cmd = new MySqlCommand($"delete from proyectofinal.medicina where Codigo>0", cn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pagina Principal", "Inicio", MessageBoxButton.OK, MessageBoxImage.Information);
                cn.Close();
                LoadGrid();
                cn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al Volver" + ex.Message);
            }
            finally
            {
                cn.Close();
                LoadGrid();
            }

        }

        private void ButtonExportarEx_Click(object sender, RoutedEventArgs e)
        {
            Excel.Application excel = new Excel.Application();
            excel.Visible = true; 
            Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];

            for (int j = 0; j < DGconsultas.Columns.Count; j++) 
            {
                Range myRange = (Range)sheet1.Cells[1, j + 1];
                sheet1.Cells[1, j + 1].Font.Bold = true; 
                sheet1.Columns[j + 1].ColumnWidth = 20; 
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

        private void Limpiar_Click(object sender, RoutedEventArgs e)
        {
            ClearData();
        }
    }
}
