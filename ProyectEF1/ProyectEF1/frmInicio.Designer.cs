namespace ProyectEF1
{
    partial class frmInicio
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
            this.btn_Incio = new System.Windows.Forms.Button();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Mostrar = new System.Windows.Forms.Button();
            this.btn_MayorNota = new System.Windows.Forms.Button();
            this.btn_Imprimir = new System.Windows.Forms.Button();
            this.btn_Archivos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Incio
            // 
            this.btn_Incio.Location = new System.Drawing.Point(12, 131);
            this.btn_Incio.Name = "btn_Incio";
            this.btn_Incio.Size = new System.Drawing.Size(149, 47);
            this.btn_Incio.TabIndex = 0;
            this.btn_Incio.Text = "Incio";
            this.btn_Incio.UseVisualStyleBackColor = true;
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.Location = new System.Drawing.Point(12, 184);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(149, 47);
            this.btn_Registrar.TabIndex = 1;
            this.btn_Registrar.Text = "Registrar alumno";
            this.btn_Registrar.UseVisualStyleBackColor = true;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(12, 290);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(149, 47);
            this.btn_Buscar.TabIndex = 2;
            this.btn_Buscar.Text = "Buscar alumno";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(12, 343);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(149, 47);
            this.btn_Modificar.TabIndex = 3;
            this.btn_Modificar.Text = "Modificar registro";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(12, 396);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(149, 47);
            this.btn_Eliminar.TabIndex = 4;
            this.btn_Eliminar.Text = "Eliminar registro";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_Mostrar
            // 
            this.btn_Mostrar.Location = new System.Drawing.Point(12, 237);
            this.btn_Mostrar.Name = "btn_Mostrar";
            this.btn_Mostrar.Size = new System.Drawing.Size(149, 47);
            this.btn_Mostrar.TabIndex = 5;
            this.btn_Mostrar.Text = "Lista de alumnos";
            this.btn_Mostrar.UseVisualStyleBackColor = true;
            // 
            // btn_MayorNota
            // 
            this.btn_MayorNota.Location = new System.Drawing.Point(12, 449);
            this.btn_MayorNota.Name = "btn_MayorNota";
            this.btn_MayorNota.Size = new System.Drawing.Size(149, 47);
            this.btn_MayorNota.TabIndex = 6;
            this.btn_MayorNota.Text = "Mayor nota";
            this.btn_MayorNota.UseVisualStyleBackColor = true;
            // 
            // btn_Imprimir
            // 
            this.btn_Imprimir.Location = new System.Drawing.Point(12, 502);
            this.btn_Imprimir.Name = "btn_Imprimir";
            this.btn_Imprimir.Size = new System.Drawing.Size(149, 47);
            this.btn_Imprimir.TabIndex = 7;
            this.btn_Imprimir.Text = "Impresion de tramite";
            this.btn_Imprimir.UseVisualStyleBackColor = true;
            // 
            // btn_Archivos
            // 
            this.btn_Archivos.Location = new System.Drawing.Point(12, 555);
            this.btn_Archivos.Name = "btn_Archivos";
            this.btn_Archivos.Size = new System.Drawing.Size(149, 47);
            this.btn_Archivos.TabIndex = 8;
            this.btn_Archivos.Text = "Archivos";
            this.btn_Archivos.UseVisualStyleBackColor = true;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.btn_Archivos);
            this.Controls.Add(this.btn_Imprimir);
            this.Controls.Add(this.btn_MayorNota);
            this.Controls.Add(this.btn_Mostrar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.btn_Registrar);
            this.Controls.Add(this.btn_Incio);
            this.Name = "frmInicio";
            this.Text = "Estrellitas de fatima";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Incio;
        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Mostrar;
        private System.Windows.Forms.Button btn_MayorNota;
        private System.Windows.Forms.Button btn_Imprimir;
        private System.Windows.Forms.Button btn_Archivos;
    }
}

