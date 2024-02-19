namespace ListasDatosSimples
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.listBoxMostrar = new System.Windows.Forms.ListBox();
            this.buttonMostrar = new System.Windows.Forms.Button();
            this.buttonOrdenar = new System.Windows.Forms.Button();
            this.buttonDescendente = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un Numero";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(162, 64);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(208, 22);
            this.textBoxNumero.TabIndex = 1;
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.Location = new System.Drawing.Point(39, 111);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(150, 40);
            this.buttonIngresar.TabIndex = 2;
            this.buttonIngresar.Text = "Ingresar Dato";
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // listBoxMostrar
            // 
            this.listBoxMostrar.FormattingEnabled = true;
            this.listBoxMostrar.ItemHeight = 16;
            this.listBoxMostrar.Location = new System.Drawing.Point(408, 39);
            this.listBoxMostrar.Name = "listBoxMostrar";
            this.listBoxMostrar.Size = new System.Drawing.Size(363, 228);
            this.listBoxMostrar.TabIndex = 3;
            // 
            // buttonMostrar
            // 
            this.buttonMostrar.Location = new System.Drawing.Point(220, 111);
            this.buttonMostrar.Name = "buttonMostrar";
            this.buttonMostrar.Size = new System.Drawing.Size(150, 40);
            this.buttonMostrar.TabIndex = 4;
            this.buttonMostrar.Text = "Mostrar Datos";
            this.buttonMostrar.UseVisualStyleBackColor = true;
            this.buttonMostrar.Click += new System.EventHandler(this.buttonMostrar_Click);
            // 
            // buttonOrdenar
            // 
            this.buttonOrdenar.Location = new System.Drawing.Point(39, 157);
            this.buttonOrdenar.Name = "buttonOrdenar";
            this.buttonOrdenar.Size = new System.Drawing.Size(150, 40);
            this.buttonOrdenar.TabIndex = 5;
            this.buttonOrdenar.Text = "Ordenar Ascendente";
            this.buttonOrdenar.UseVisualStyleBackColor = true;
            this.buttonOrdenar.Click += new System.EventHandler(this.buttonOrdenar_Click);
            // 
            // buttonDescendente
            // 
            this.buttonDescendente.Location = new System.Drawing.Point(220, 157);
            this.buttonDescendente.Name = "buttonDescendente";
            this.buttonDescendente.Size = new System.Drawing.Size(150, 40);
            this.buttonDescendente.TabIndex = 6;
            this.buttonDescendente.Text = "Ordenar Descendente";
            this.buttonDescendente.UseVisualStyleBackColor = true;
            this.buttonDescendente.Click += new System.EventHandler(this.buttonDescendente_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(132, 203);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(150, 40);
            this.buttonEliminar.TabIndex = 7;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 299);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonDescendente);
            this.Controls.Add(this.buttonOrdenar);
            this.Controls.Add(this.buttonMostrar);
            this.Controls.Add(this.listBoxMostrar);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.ListBox listBoxMostrar;
        private System.Windows.Forms.Button buttonMostrar;
        private System.Windows.Forms.Button buttonOrdenar;
        private System.Windows.Forms.Button buttonDescendente;
        private System.Windows.Forms.Button buttonEliminar;
    }
}

