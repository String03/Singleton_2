namespace Singleton_2
{
    partial class FormularioCajadeAhorro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grillaCajadeAhorro = new System.Windows.Forms.DataGridView();
            this.btn_alta_caja_de_ahorro = new System.Windows.Forms.Button();
            this.btn_baja_caja_de_ahorro = new System.Windows.Forms.Button();
            this.txt_codigo_caja_de_ahorro = new System.Windows.Forms.TextBox();
            this.txt_nombre_caja_de_ahorro = new System.Windows.Forms.TextBox();
            this.txt_monto_caja_de_ahorro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grillaCajadeAhorro)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaCajadeAhorro
            // 
            this.grillaCajadeAhorro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaCajadeAhorro.Location = new System.Drawing.Point(128, 28);
            this.grillaCajadeAhorro.MultiSelect = false;
            this.grillaCajadeAhorro.Name = "grillaCajadeAhorro";
            this.grillaCajadeAhorro.ReadOnly = true;
            this.grillaCajadeAhorro.RowTemplate.Height = 24;
            this.grillaCajadeAhorro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaCajadeAhorro.Size = new System.Drawing.Size(540, 150);
            this.grillaCajadeAhorro.TabIndex = 0;
            // 
            // btn_alta_caja_de_ahorro
            // 
            this.btn_alta_caja_de_ahorro.Location = new System.Drawing.Point(246, 227);
            this.btn_alta_caja_de_ahorro.Name = "btn_alta_caja_de_ahorro";
            this.btn_alta_caja_de_ahorro.Size = new System.Drawing.Size(75, 23);
            this.btn_alta_caja_de_ahorro.TabIndex = 1;
            this.btn_alta_caja_de_ahorro.Text = "Alta";
            this.btn_alta_caja_de_ahorro.UseVisualStyleBackColor = true;
            this.btn_alta_caja_de_ahorro.Click += new System.EventHandler(this.btn_alta_caja_de_ahorro_Click);
            // 
            // btn_baja_caja_de_ahorro
            // 
            this.btn_baja_caja_de_ahorro.Location = new System.Drawing.Point(426, 227);
            this.btn_baja_caja_de_ahorro.Name = "btn_baja_caja_de_ahorro";
            this.btn_baja_caja_de_ahorro.Size = new System.Drawing.Size(75, 23);
            this.btn_baja_caja_de_ahorro.TabIndex = 2;
            this.btn_baja_caja_de_ahorro.Text = "Baja";
            this.btn_baja_caja_de_ahorro.UseVisualStyleBackColor = true;
            // 
            // txt_codigo_caja_de_ahorro
            // 
            this.txt_codigo_caja_de_ahorro.Location = new System.Drawing.Point(110, 308);
            this.txt_codigo_caja_de_ahorro.Name = "txt_codigo_caja_de_ahorro";
            this.txt_codigo_caja_de_ahorro.Size = new System.Drawing.Size(242, 22);
            this.txt_codigo_caja_de_ahorro.TabIndex = 3;
            // 
            // txt_nombre_caja_de_ahorro
            // 
            this.txt_nombre_caja_de_ahorro.Location = new System.Drawing.Point(494, 310);
            this.txt_nombre_caja_de_ahorro.Name = "txt_nombre_caja_de_ahorro";
            this.txt_nombre_caja_de_ahorro.Size = new System.Drawing.Size(251, 22);
            this.txt_nombre_caja_de_ahorro.TabIndex = 4;
            // 
            // txt_monto_caja_de_ahorro
            // 
            this.txt_monto_caja_de_ahorro.Location = new System.Drawing.Point(296, 393);
            this.txt_monto_caja_de_ahorro.Name = "txt_monto_caja_de_ahorro";
            this.txt_monto_caja_de_ahorro.Size = new System.Drawing.Size(275, 22);
            this.txt_monto_caja_de_ahorro.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Monto";
            // 
            // FormularioCajadeAhorro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_monto_caja_de_ahorro);
            this.Controls.Add(this.txt_nombre_caja_de_ahorro);
            this.Controls.Add(this.txt_codigo_caja_de_ahorro);
            this.Controls.Add(this.btn_baja_caja_de_ahorro);
            this.Controls.Add(this.btn_alta_caja_de_ahorro);
            this.Controls.Add(this.grillaCajadeAhorro);
            this.Name = "FormularioCajadeAhorro";
            this.Text = "FormularioCajadeAhorro";
            this.Load += new System.EventHandler(this.FormularioCajadeAhorro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaCajadeAhorro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaCajadeAhorro;
        private System.Windows.Forms.Button btn_alta_caja_de_ahorro;
        private System.Windows.Forms.Button btn_baja_caja_de_ahorro;
        private System.Windows.Forms.TextBox txt_codigo_caja_de_ahorro;
        private System.Windows.Forms.TextBox txt_nombre_caja_de_ahorro;
        private System.Windows.Forms.TextBox txt_monto_caja_de_ahorro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}