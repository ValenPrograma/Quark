namespace FormSumar2textBox
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
            this.resultado = new System.Windows.Forms.Label();
            this.textValor1 = new System.Windows.Forms.Label();
            this.textValor2 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.operacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Location = new System.Drawing.Point(140, 133);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(55, 13);
            this.resultado.TabIndex = 0;
            this.resultado.Text = "Resultado";
            // 
            // textValor1
            // 
            this.textValor1.AutoSize = true;
            this.textValor1.Location = new System.Drawing.Point(24, 35);
            this.textValor1.Name = "textValor1";
            this.textValor1.Size = new System.Drawing.Size(83, 13);
            this.textValor1.TabIndex = 1;
            this.textValor1.Text = "Ingrese numero:";
            // 
            // textValor2
            // 
            this.textValor2.AutoSize = true;
            this.textValor2.Location = new System.Drawing.Point(24, 80);
            this.textValor2.Name = "textValor2";
            this.textValor2.Size = new System.Drawing.Size(83, 13);
            this.textValor2.TabIndex = 2;
            this.textValor2.Text = "Ingrese numero:";
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(121, 32);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(100, 20);
            this.TextBox1.TabIndex = 3;
            this.TextBox1.Text = "0";
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(121, 77);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(100, 20);
            this.TextBox2.TabIndex = 4;
            this.TextBox2.Text = "0";
            // 
            // operacion
            // 
            this.operacion.Location = new System.Drawing.Point(27, 128);
            this.operacion.Name = "operacion";
            this.operacion.Size = new System.Drawing.Size(75, 23);
            this.operacion.TabIndex = 5;
            this.operacion.Text = "Sumar";
            this.operacion.UseVisualStyleBackColor = true;
            this.operacion.Click += new System.EventHandler(this.operacion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 169);
            this.Controls.Add(this.operacion);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.textValor2);
            this.Controls.Add(this.textValor1);
            this.Controls.Add(this.resultado);
            this.Name = "Form1";
            this.Text = "Sumar 2 numeros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Label textValor1;
        private System.Windows.Forms.Label textValor2;
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.TextBox TextBox2;
        private System.Windows.Forms.Button operacion;
    }
}

