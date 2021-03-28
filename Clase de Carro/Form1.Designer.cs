
namespace Clase_de_Carro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttoncrear = new System.Windows.Forms.Button();
            this.labelEstado = new System.Windows.Forms.Label();
            this.buttonencender = new System.Windows.Forms.Button();
            this.buttonacelerar = new System.Windows.Forms.Button();
            this.labelestadovelocidad = new System.Windows.Forms.Label();
            this.buttonfrenodemano = new System.Windows.Forms.Button();
            this.buttonfrenando = new System.Windows.Forms.Button();
            this.labelvelocidades = new System.Windows.Forms.Label();
            this.buttoncambios = new System.Windows.Forms.Button();
            this.buttonreproducir = new System.Windows.Forms.Button();
            this.buttonpausar = new System.Windows.Forms.Button();
            this.buttoncontinuar = new System.Windows.Forms.Button();
            this.Buttondetener = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttoncrear
            // 
            this.buttoncrear.Location = new System.Drawing.Point(778, 12);
            this.buttoncrear.Name = "buttoncrear";
            this.buttoncrear.Size = new System.Drawing.Size(116, 45);
            this.buttoncrear.TabIndex = 0;
            this.buttoncrear.Text = "Crear carro";
            this.buttoncrear.UseVisualStyleBackColor = true;
            this.buttoncrear.Click += new System.EventHandler(this.buttoninicio_Click);
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(539, 229);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(0, 20);
            this.labelEstado.TabIndex = 1;
            // 
            // buttonencender
            // 
            this.buttonencender.Location = new System.Drawing.Point(454, 321);
            this.buttonencender.Name = "buttonencender";
            this.buttonencender.Size = new System.Drawing.Size(144, 55);
            this.buttonencender.TabIndex = 2;
            this.buttonencender.Text = "Encender o Apagar Carro";
            this.buttonencender.UseVisualStyleBackColor = true;
            this.buttonencender.Visible = false;
            this.buttonencender.Click += new System.EventHandler(this.buttonencender_Click);
            // 
            // buttonacelerar
            // 
            this.buttonacelerar.Location = new System.Drawing.Point(376, 419);
            this.buttonacelerar.Name = "buttonacelerar";
            this.buttonacelerar.Size = new System.Drawing.Size(125, 29);
            this.buttonacelerar.TabIndex = 3;
            this.buttonacelerar.Text = "Acelerar";
            this.buttonacelerar.UseVisualStyleBackColor = true;
            this.buttonacelerar.Visible = false;
            this.buttonacelerar.Click += new System.EventHandler(this.buttonacelerar_Click);
            // 
            // labelestadovelocidad
            // 
            this.labelestadovelocidad.AutoSize = true;
            this.labelestadovelocidad.Location = new System.Drawing.Point(342, 245);
            this.labelestadovelocidad.Name = "labelestadovelocidad";
            this.labelestadovelocidad.Size = new System.Drawing.Size(0, 20);
            this.labelestadovelocidad.TabIndex = 4;
            // 
            // buttonfrenodemano
            // 
            this.buttonfrenodemano.Location = new System.Drawing.Point(465, 481);
            this.buttonfrenodemano.Name = "buttonfrenodemano";
            this.buttonfrenodemano.Size = new System.Drawing.Size(133, 29);
            this.buttonfrenodemano.TabIndex = 5;
            this.buttonfrenodemano.Text = "Freno de Mano";
            this.buttonfrenodemano.UseVisualStyleBackColor = true;
            this.buttonfrenodemano.Visible = false;
            this.buttonfrenodemano.Click += new System.EventHandler(this.buttonfrenodemano_Click);
            // 
            // buttonfrenando
            // 
            this.buttonfrenando.Location = new System.Drawing.Point(265, 419);
            this.buttonfrenando.Name = "buttonfrenando";
            this.buttonfrenando.Size = new System.Drawing.Size(94, 29);
            this.buttonfrenando.TabIndex = 6;
            this.buttonfrenando.Text = "Frenar";
            this.buttonfrenando.UseVisualStyleBackColor = true;
            this.buttonfrenando.Visible = false;
            this.buttonfrenando.Click += new System.EventHandler(this.buttonfrenando_Click);
            // 
            // labelvelocidades
            // 
            this.labelvelocidades.AutoSize = true;
            this.labelvelocidades.Location = new System.Drawing.Point(214, 218);
            this.labelvelocidades.Name = "labelvelocidades";
            this.labelvelocidades.Size = new System.Drawing.Size(0, 20);
            this.labelvelocidades.TabIndex = 8;
            // 
            // buttoncambios
            // 
            this.buttoncambios.Location = new System.Drawing.Point(630, 410);
            this.buttoncambios.Name = "buttoncambios";
            this.buttoncambios.Size = new System.Drawing.Size(94, 29);
            this.buttoncambios.TabIndex = 10;
            this.buttoncambios.Text = "Cambios";
            this.buttoncambios.UseVisualStyleBackColor = true;
            this.buttoncambios.Visible = false;
            this.buttoncambios.Click += new System.EventHandler(this.buttoncambios_Click);
            // 
            // buttonreproducir
            // 
            this.buttonreproducir.Location = new System.Drawing.Point(911, 220);
            this.buttonreproducir.Name = "buttonreproducir";
            this.buttonreproducir.Size = new System.Drawing.Size(109, 39);
            this.buttonreproducir.TabIndex = 11;
            this.buttonreproducir.Text = "Reproducir";
            this.buttonreproducir.UseVisualStyleBackColor = true;
            this.buttonreproducir.Visible = false;
            this.buttonreproducir.Click += new System.EventHandler(this.buttonreproducir_Click);
            // 
            // buttonpausar
            // 
            this.buttonpausar.Location = new System.Drawing.Point(832, 264);
            this.buttonpausar.Name = "buttonpausar";
            this.buttonpausar.Size = new System.Drawing.Size(62, 29);
            this.buttonpausar.TabIndex = 12;
            this.buttonpausar.Text = "Pausar";
            this.buttonpausar.UseVisualStyleBackColor = true;
            this.buttonpausar.Visible = false;
            this.buttonpausar.Click += new System.EventHandler(this.buttonpausar_Click);
            // 
            // buttoncontinuar
            // 
            this.buttoncontinuar.Location = new System.Drawing.Point(900, 264);
            this.buttoncontinuar.Name = "buttoncontinuar";
            this.buttoncontinuar.Size = new System.Drawing.Size(94, 29);
            this.buttoncontinuar.TabIndex = 13;
            this.buttoncontinuar.Text = "Continuar";
            this.buttoncontinuar.UseVisualStyleBackColor = true;
            this.buttoncontinuar.Visible = false;
            this.buttoncontinuar.Click += new System.EventHandler(this.buttoncontinuar_Click);
            // 
            // Buttondetener
            // 
            this.Buttondetener.Location = new System.Drawing.Point(1000, 264);
            this.Buttondetener.Name = "Buttondetener";
            this.Buttondetener.Size = new System.Drawing.Size(94, 29);
            this.Buttondetener.TabIndex = 14;
            this.Buttondetener.Text = "Detener";
            this.Buttondetener.UseVisualStyleBackColor = true;
            this.Buttondetener.Visible = false;
            this.Buttondetener.Click += new System.EventHandler(this.Buttondetener_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1102, 522);
            this.Controls.Add(this.Buttondetener);
            this.Controls.Add(this.buttoncontinuar);
            this.Controls.Add(this.buttonpausar);
            this.Controls.Add(this.buttonreproducir);
            this.Controls.Add(this.buttoncambios);
            this.Controls.Add(this.labelvelocidades);
            this.Controls.Add(this.buttonfrenando);
            this.Controls.Add(this.buttonfrenodemano);
            this.Controls.Add(this.labelestadovelocidad);
            this.Controls.Add(this.buttonacelerar);
            this.Controls.Add(this.buttonencender);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.buttoncrear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttoncrear;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Button buttonencender;
        private System.Windows.Forms.Button buttonacelerar;
        private System.Windows.Forms.Label labelestadovelocidad;
        private System.Windows.Forms.Button buttonfrenodemano;
        private System.Windows.Forms.Button buttonfrenando;
        private System.Windows.Forms.Label labelvelocidades;
        private System.Windows.Forms.Button buttoncambios;
        private System.Windows.Forms.Button buttonreproducir;
        private System.Windows.Forms.Button buttonpausar;
        private System.Windows.Forms.Button buttoncontinuar;
        private System.Windows.Forms.Button Buttondetener;
    }
}

