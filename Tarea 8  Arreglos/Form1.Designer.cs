
namespace Tarea_Arreglos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonarreglo = new System.Windows.Forms.Button();
            this.listBoxresultado = new System.Windows.Forms.ListBox();
            this.textBoxresultado = new System.Windows.Forms.TextBox();
            this.buttonCargarArchivo = new System.Windows.Forms.Button();
            this.buttonNombres = new System.Windows.Forms.Button();
            this.buttonPromedioAlumno = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonPromedioGeneral = new System.Windows.Forms.Button();
            this.buttonMaxMin = new System.Windows.Forms.Button();
            this.buttonnombresOrdenados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonarreglo
            // 
            this.buttonarreglo.BackColor = System.Drawing.Color.Lime;
            this.buttonarreglo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonarreglo.ForeColor = System.Drawing.Color.Blue;
            this.buttonarreglo.Location = new System.Drawing.Point(948, 365);
            this.buttonarreglo.Name = "buttonarreglo";
            this.buttonarreglo.Size = new System.Drawing.Size(173, 70);
            this.buttonarreglo.TabIndex = 0;
            this.buttonarreglo.Text = "Numeros Ordenados";
            this.buttonarreglo.UseVisualStyleBackColor = false;
            this.buttonarreglo.Click += new System.EventHandler(this.buttonarreglo_Click);
            // 
            // listBoxresultado
            // 
            this.listBoxresultado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxresultado.ForeColor = System.Drawing.Color.Tomato;
            this.listBoxresultado.FormattingEnabled = true;
            this.listBoxresultado.ItemHeight = 20;
            this.listBoxresultado.Location = new System.Drawing.Point(911, 9);
            this.listBoxresultado.Name = "listBoxresultado";
            this.listBoxresultado.Size = new System.Drawing.Size(798, 304);
            this.listBoxresultado.TabIndex = 1;
            // 
            // textBoxresultado
            // 
            this.textBoxresultado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxresultado.ForeColor = System.Drawing.Color.Tomato;
            this.textBoxresultado.Location = new System.Drawing.Point(233, 9);
            this.textBoxresultado.Multiline = true;
            this.textBoxresultado.Name = "textBoxresultado";
            this.textBoxresultado.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxresultado.Size = new System.Drawing.Size(662, 312);
            this.textBoxresultado.TabIndex = 2;
            // 
            // buttonCargarArchivo
            // 
            this.buttonCargarArchivo.AutoSize = true;
            this.buttonCargarArchivo.BackColor = System.Drawing.Color.Lime;
            this.buttonCargarArchivo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCargarArchivo.ForeColor = System.Drawing.Color.Blue;
            this.buttonCargarArchivo.Location = new System.Drawing.Point(28, 24);
            this.buttonCargarArchivo.Name = "buttonCargarArchivo";
            this.buttonCargarArchivo.Size = new System.Drawing.Size(199, 106);
            this.buttonCargarArchivo.TabIndex = 3;
            this.buttonCargarArchivo.Text = "Cargar Archivo";
            this.buttonCargarArchivo.UseVisualStyleBackColor = false;
            this.buttonCargarArchivo.Click += new System.EventHandler(this.buttonCargarArchivo_Click);
            // 
            // buttonNombres
            // 
            this.buttonNombres.BackColor = System.Drawing.Color.Lime;
            this.buttonNombres.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNombres.ForeColor = System.Drawing.Color.Blue;
            this.buttonNombres.Location = new System.Drawing.Point(28, 155);
            this.buttonNombres.Name = "buttonNombres";
            this.buttonNombres.Size = new System.Drawing.Size(199, 64);
            this.buttonNombres.TabIndex = 4;
            this.buttonNombres.Text = "Nombres de Alumnos";
            this.buttonNombres.UseVisualStyleBackColor = false;
            this.buttonNombres.Click += new System.EventHandler(this.buttonNombres_Click);
            // 
            // buttonPromedioAlumno
            // 
            this.buttonPromedioAlumno.BackColor = System.Drawing.Color.Lime;
            this.buttonPromedioAlumno.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPromedioAlumno.ForeColor = System.Drawing.Color.Blue;
            this.buttonPromedioAlumno.Location = new System.Drawing.Point(42, 370);
            this.buttonPromedioAlumno.Name = "buttonPromedioAlumno";
            this.buttonPromedioAlumno.Size = new System.Drawing.Size(199, 67);
            this.buttonPromedioAlumno.TabIndex = 5;
            this.buttonPromedioAlumno.Text = "Promedio de cada alumno";
            this.buttonPromedioAlumno.UseVisualStyleBackColor = false;
            this.buttonPromedioAlumno.Click += new System.EventHandler(this.buttonPromedioAlumno_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.BackColor = System.Drawing.Color.Lime;
            this.buttonLimpiar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiar.ForeColor = System.Drawing.Color.Blue;
            this.buttonLimpiar.Location = new System.Drawing.Point(701, 368);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(165, 70);
            this.buttonLimpiar.TabIndex = 6;
            this.buttonLimpiar.Text = "Limpiar ListBox";
            this.buttonLimpiar.UseVisualStyleBackColor = false;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonPromedioGeneral
            // 
            this.buttonPromedioGeneral.BackColor = System.Drawing.Color.Lime;
            this.buttonPromedioGeneral.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPromedioGeneral.ForeColor = System.Drawing.Color.Blue;
            this.buttonPromedioGeneral.Location = new System.Drawing.Point(279, 371);
            this.buttonPromedioGeneral.Name = "buttonPromedioGeneral";
            this.buttonPromedioGeneral.Size = new System.Drawing.Size(199, 67);
            this.buttonPromedioGeneral.TabIndex = 7;
            this.buttonPromedioGeneral.Text = "Promedio General";
            this.buttonPromedioGeneral.UseVisualStyleBackColor = false;
            this.buttonPromedioGeneral.Click += new System.EventHandler(this.buttonPromedioGeneral_Click);
            // 
            // buttonMaxMin
            // 
            this.buttonMaxMin.BackColor = System.Drawing.Color.Lime;
            this.buttonMaxMin.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMaxMin.ForeColor = System.Drawing.Color.Blue;
            this.buttonMaxMin.Location = new System.Drawing.Point(515, 371);
            this.buttonMaxMin.Name = "buttonMaxMin";
            this.buttonMaxMin.Size = new System.Drawing.Size(171, 67);
            this.buttonMaxMin.TabIndex = 8;
            this.buttonMaxMin.Text = "Nota maxima y Nota minima";
            this.buttonMaxMin.UseVisualStyleBackColor = false;
            this.buttonMaxMin.Click += new System.EventHandler(this.buttonMaxMin_Click);
            // 
            // buttonnombresOrdenados
            // 
            this.buttonnombresOrdenados.BackColor = System.Drawing.Color.Lime;
            this.buttonnombresOrdenados.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonnombresOrdenados.ForeColor = System.Drawing.Color.Blue;
            this.buttonnombresOrdenados.Location = new System.Drawing.Point(28, 254);
            this.buttonnombresOrdenados.Name = "buttonnombresOrdenados";
            this.buttonnombresOrdenados.Size = new System.Drawing.Size(199, 67);
            this.buttonnombresOrdenados.TabIndex = 9;
            this.buttonnombresOrdenados.Text = "Nombres Ordenados";
            this.buttonnombresOrdenados.UseVisualStyleBackColor = false;
            this.buttonnombresOrdenados.Click += new System.EventHandler(this.buttonnombresOrdenados_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1714, 469);
            this.Controls.Add(this.buttonnombresOrdenados);
            this.Controls.Add(this.buttonMaxMin);
            this.Controls.Add(this.buttonPromedioGeneral);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonPromedioAlumno);
            this.Controls.Add(this.buttonNombres);
            this.Controls.Add(this.buttonCargarArchivo);
            this.Controls.Add(this.textBoxresultado);
            this.Controls.Add(this.listBoxresultado);
            this.Controls.Add(this.buttonarreglo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonarreglo;
        private System.Windows.Forms.ListBox listBoxresultado;
        private System.Windows.Forms.TextBox textBoxresultado;
        private System.Windows.Forms.Button buttonCargarArchivo;
        private System.Windows.Forms.Button buttonNombres;
        private System.Windows.Forms.Button buttonPromedioAlumno;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonPromedioGeneral;
        private System.Windows.Forms.Button buttonMaxMin;
        private System.Windows.Forms.Button buttonnombresOrdenados;
    }
}

