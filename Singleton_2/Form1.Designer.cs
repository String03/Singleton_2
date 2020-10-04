namespace Singleton_2
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
            this.btn_caja_de_ahorro = new System.Windows.Forms.Button();
            this.btn_caja_de_ahorro_en_dolares = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_caja_de_ahorro
            // 
            this.btn_caja_de_ahorro.Location = new System.Drawing.Point(122, 68);
            this.btn_caja_de_ahorro.Name = "btn_caja_de_ahorro";
            this.btn_caja_de_ahorro.Size = new System.Drawing.Size(329, 23);
            this.btn_caja_de_ahorro.TabIndex = 0;
            this.btn_caja_de_ahorro.Text = "Caja de Ahorro";
            this.btn_caja_de_ahorro.UseVisualStyleBackColor = true;
            this.btn_caja_de_ahorro.Click += new System.EventHandler(this.btn_caja_de_ahorro_Click);
            // 
            // btn_caja_de_ahorro_en_dolares
            // 
            this.btn_caja_de_ahorro_en_dolares.Location = new System.Drawing.Point(117, 138);
            this.btn_caja_de_ahorro_en_dolares.Name = "btn_caja_de_ahorro_en_dolares";
            this.btn_caja_de_ahorro_en_dolares.Size = new System.Drawing.Size(329, 23);
            this.btn_caja_de_ahorro_en_dolares.TabIndex = 1;
            this.btn_caja_de_ahorro_en_dolares.Text = "Caja de Ahorro en Dólares";
            this.btn_caja_de_ahorro_en_dolares.UseVisualStyleBackColor = true;
            this.btn_caja_de_ahorro_en_dolares.Click += new System.EventHandler(this.btn_caja_de_ahorro_en_dolares_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 299);
            this.Controls.Add(this.btn_caja_de_ahorro_en_dolares);
            this.Controls.Add(this.btn_caja_de_ahorro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_caja_de_ahorro;
        private System.Windows.Forms.Button btn_caja_de_ahorro_en_dolares;
    }
}

