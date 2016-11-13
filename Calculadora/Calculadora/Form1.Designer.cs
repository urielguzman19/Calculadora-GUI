namespace Calculadora
{
    partial class Calculadora
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Pantalla = new System.Windows.Forms.TextBox();
            this.Siete = new System.Windows.Forms.Button();
            this.Ocho = new System.Windows.Forms.Button();
            this.Nueve = new System.Windows.Forms.Button();
            this.Cuatro = new System.Windows.Forms.Button();
            this.Cinco = new System.Windows.Forms.Button();
            this.Seis = new System.Windows.Forms.Button();
            this.Uno = new System.Windows.Forms.Button();
            this.Dos = new System.Windows.Forms.Button();
            this.Tres = new System.Windows.Forms.Button();
            this.Retroceso = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.Multiplicacion = new System.Windows.Forms.Button();
            this.Potencia = new System.Windows.Forms.Button();
            this.Cero = new System.Windows.Forms.Button();
            this.Punto = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.Resta = new System.Windows.Forms.Button();
            this.Suma = new System.Windows.Forms.Button();
            this.RaizCuadrada = new System.Windows.Forms.Button();
            this.Igual = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(449, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Pantalla
            // 
            this.Pantalla.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pantalla.Location = new System.Drawing.Point(14, 52);
            this.Pantalla.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Pantalla.Multiline = true;
            this.Pantalla.Name = "Pantalla";
            this.Pantalla.Size = new System.Drawing.Size(422, 67);
            this.Pantalla.TabIndex = 1;
            this.Pantalla.Text = "0";
            // 
            // Siete
            // 
            this.Siete.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Siete.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Siete.Location = new System.Drawing.Point(29, 194);
            this.Siete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Siete.Name = "Siete";
            this.Siete.Size = new System.Drawing.Size(62, 48);
            this.Siete.TabIndex = 2;
            this.Siete.Text = "7";
            this.Siete.UseVisualStyleBackColor = false;
            this.Siete.Click += new System.EventHandler(this.Siete_Click);
            // 
            // Ocho
            // 
            this.Ocho.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Ocho.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ocho.Location = new System.Drawing.Point(109, 193);
            this.Ocho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Ocho.Name = "Ocho";
            this.Ocho.Size = new System.Drawing.Size(62, 48);
            this.Ocho.TabIndex = 3;
            this.Ocho.Text = "8";
            this.Ocho.UseVisualStyleBackColor = false;
            this.Ocho.Click += new System.EventHandler(this.Ocho_Click);
            // 
            // Nueve
            // 
            this.Nueve.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Nueve.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nueve.Location = new System.Drawing.Point(189, 194);
            this.Nueve.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Nueve.Name = "Nueve";
            this.Nueve.Size = new System.Drawing.Size(62, 48);
            this.Nueve.TabIndex = 4;
            this.Nueve.Text = "9";
            this.Nueve.UseVisualStyleBackColor = false;
            this.Nueve.Click += new System.EventHandler(this.Nueve_Click);
            // 
            // Cuatro
            // 
            this.Cuatro.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Cuatro.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cuatro.Location = new System.Drawing.Point(29, 252);
            this.Cuatro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cuatro.Name = "Cuatro";
            this.Cuatro.Size = new System.Drawing.Size(62, 48);
            this.Cuatro.TabIndex = 5;
            this.Cuatro.Text = "4";
            this.Cuatro.UseVisualStyleBackColor = false;
            this.Cuatro.Click += new System.EventHandler(this.Cuatro_Click);
            // 
            // Cinco
            // 
            this.Cinco.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Cinco.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cinco.Location = new System.Drawing.Point(109, 251);
            this.Cinco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cinco.Name = "Cinco";
            this.Cinco.Size = new System.Drawing.Size(62, 48);
            this.Cinco.TabIndex = 6;
            this.Cinco.Text = "5";
            this.Cinco.UseVisualStyleBackColor = false;
            this.Cinco.Click += new System.EventHandler(this.Cinco_Click);
            // 
            // Seis
            // 
            this.Seis.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Seis.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seis.Location = new System.Drawing.Point(189, 252);
            this.Seis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Seis.Name = "Seis";
            this.Seis.Size = new System.Drawing.Size(62, 48);
            this.Seis.TabIndex = 7;
            this.Seis.Text = "6";
            this.Seis.UseVisualStyleBackColor = false;
            this.Seis.Click += new System.EventHandler(this.Seis_Click);
            // 
            // Uno
            // 
            this.Uno.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Uno.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uno.Location = new System.Drawing.Point(29, 308);
            this.Uno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Uno.Name = "Uno";
            this.Uno.Size = new System.Drawing.Size(62, 48);
            this.Uno.TabIndex = 8;
            this.Uno.Text = "1";
            this.Uno.UseVisualStyleBackColor = false;
            this.Uno.Click += new System.EventHandler(this.Uno_Click);
            // 
            // Dos
            // 
            this.Dos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Dos.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dos.Location = new System.Drawing.Point(109, 307);
            this.Dos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Dos.Name = "Dos";
            this.Dos.Size = new System.Drawing.Size(62, 48);
            this.Dos.TabIndex = 9;
            this.Dos.Text = "2";
            this.Dos.UseVisualStyleBackColor = false;
            this.Dos.Click += new System.EventHandler(this.Dos_Click);
            // 
            // Tres
            // 
            this.Tres.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Tres.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tres.Location = new System.Drawing.Point(189, 308);
            this.Tres.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tres.Name = "Tres";
            this.Tres.Size = new System.Drawing.Size(62, 48);
            this.Tres.TabIndex = 10;
            this.Tres.Text = "3";
            this.Tres.UseVisualStyleBackColor = false;
            this.Tres.Click += new System.EventHandler(this.Tres_Click);
            // 
            // Retroceso
            // 
            this.Retroceso.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Retroceso.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Retroceso.Location = new System.Drawing.Point(29, 142);
            this.Retroceso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Retroceso.Name = "Retroceso";
            this.Retroceso.Size = new System.Drawing.Size(142, 44);
            this.Retroceso.TabIndex = 11;
            this.Retroceso.Text = "Retroceso";
            this.Retroceso.UseVisualStyleBackColor = false;
            this.Retroceso.Click += new System.EventHandler(this.Retroceso_Click);
            // 
            // C
            // 
            this.C.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.C.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C.Location = new System.Drawing.Point(189, 142);
            this.C.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(62, 48);
            this.C.TabIndex = 12;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = false;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // Multiplicacion
            // 
            this.Multiplicacion.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Multiplicacion.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiplicacion.Location = new System.Drawing.Point(270, 141);
            this.Multiplicacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Multiplicacion.Name = "Multiplicacion";
            this.Multiplicacion.Size = new System.Drawing.Size(62, 48);
            this.Multiplicacion.TabIndex = 13;
            this.Multiplicacion.Text = "*";
            this.Multiplicacion.UseVisualStyleBackColor = false;
            this.Multiplicacion.Click += new System.EventHandler(this.Multiplicacion_Click);
            // 
            // Potencia
            // 
            this.Potencia.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Potencia.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Potencia.Location = new System.Drawing.Point(350, 141);
            this.Potencia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Potencia.Name = "Potencia";
            this.Potencia.Size = new System.Drawing.Size(62, 48);
            this.Potencia.TabIndex = 14;
            this.Potencia.Text = "x^2";
            this.Potencia.UseVisualStyleBackColor = false;
            this.Potencia.Click += new System.EventHandler(this.Potencia_Click);
            // 
            // Cero
            // 
            this.Cero.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Cero.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cero.Location = new System.Drawing.Point(29, 370);
            this.Cero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cero.Name = "Cero";
            this.Cero.Size = new System.Drawing.Size(142, 35);
            this.Cero.TabIndex = 15;
            this.Cero.Text = "0";
            this.Cero.UseVisualStyleBackColor = false;
            this.Cero.Click += new System.EventHandler(this.Cero_Click);
            // 
            // Punto
            // 
            this.Punto.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Punto.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Punto.Location = new System.Drawing.Point(189, 370);
            this.Punto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Punto.Name = "Punto";
            this.Punto.Size = new System.Drawing.Size(62, 35);
            this.Punto.TabIndex = 16;
            this.Punto.Text = ".";
            this.Punto.UseVisualStyleBackColor = false;
            // 
            // Division
            // 
            this.Division.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Division.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Division.Location = new System.Drawing.Point(270, 193);
            this.Division.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(62, 48);
            this.Division.TabIndex = 17;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = false;
            this.Division.Click += new System.EventHandler(this.Division_Click);
            // 
            // Resta
            // 
            this.Resta.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Resta.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resta.Location = new System.Drawing.Point(270, 251);
            this.Resta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Resta.Name = "Resta";
            this.Resta.Size = new System.Drawing.Size(62, 48);
            this.Resta.TabIndex = 18;
            this.Resta.Text = "-";
            this.Resta.UseVisualStyleBackColor = false;
            this.Resta.Click += new System.EventHandler(this.Resta_Click);
            // 
            // Suma
            // 
            this.Suma.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Suma.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Suma.Location = new System.Drawing.Point(270, 308);
            this.Suma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Suma.Name = "Suma";
            this.Suma.Size = new System.Drawing.Size(62, 97);
            this.Suma.TabIndex = 19;
            this.Suma.Text = "+";
            this.Suma.UseVisualStyleBackColor = false;
            this.Suma.Click += new System.EventHandler(this.Suma_Click);
            // 
            // RaizCuadrada
            // 
            this.RaizCuadrada.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.RaizCuadrada.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RaizCuadrada.Location = new System.Drawing.Point(350, 193);
            this.RaizCuadrada.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RaizCuadrada.Name = "RaizCuadrada";
            this.RaizCuadrada.Size = new System.Drawing.Size(62, 48);
            this.RaizCuadrada.TabIndex = 20;
            this.RaizCuadrada.Text = "√";
            this.RaizCuadrada.UseVisualStyleBackColor = false;
            this.RaizCuadrada.Click += new System.EventHandler(this.RaizCuadrada_Click);
            // 
            // Igual
            // 
            this.Igual.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Igual.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Igual.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Igual.Location = new System.Drawing.Point(350, 252);
            this.Igual.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Igual.Name = "Igual";
            this.Igual.Size = new System.Drawing.Size(62, 157);
            this.Igual.TabIndex = 21;
            this.Igual.Text = "=";
            this.Igual.UseVisualStyleBackColor = false;
            this.Igual.Click += new System.EventHandler(this.Igual_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 418);
            this.Controls.Add(this.Igual);
            this.Controls.Add(this.RaizCuadrada);
            this.Controls.Add(this.Suma);
            this.Controls.Add(this.Resta);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Punto);
            this.Controls.Add(this.Cero);
            this.Controls.Add(this.Potencia);
            this.Controls.Add(this.Multiplicacion);
            this.Controls.Add(this.C);
            this.Controls.Add(this.Retroceso);
            this.Controls.Add(this.Tres);
            this.Controls.Add(this.Dos);
            this.Controls.Add(this.Uno);
            this.Controls.Add(this.Seis);
            this.Controls.Add(this.Cinco);
            this.Controls.Add(this.Cuatro);
            this.Controls.Add(this.Nueve);
            this.Controls.Add(this.Ocho);
            this.Controls.Add(this.Siete);
            this.Controls.Add(this.Pantalla);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Calculadora";
            this.Text = "Mi Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.TextBox Pantalla;
        private System.Windows.Forms.Button Siete;
        private System.Windows.Forms.Button Ocho;
        private System.Windows.Forms.Button Nueve;
        private System.Windows.Forms.Button Cuatro;
        private System.Windows.Forms.Button Cinco;
        private System.Windows.Forms.Button Seis;
        private System.Windows.Forms.Button Uno;
        private System.Windows.Forms.Button Dos;
        private System.Windows.Forms.Button Tres;
        private System.Windows.Forms.Button Retroceso;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button Multiplicacion;
        private System.Windows.Forms.Button Potencia;
        private System.Windows.Forms.Button Cero;
        private System.Windows.Forms.Button Punto;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Button Resta;
        private System.Windows.Forms.Button Suma;
        private System.Windows.Forms.Button RaizCuadrada;
        private System.Windows.Forms.Button Igual;
    }
}

