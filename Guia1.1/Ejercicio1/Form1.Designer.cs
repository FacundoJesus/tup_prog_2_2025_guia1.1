namespace Ejercicio1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnCalcularCosto = new Button();
            btnSalir = new Button();
            tbValorFabricacion = new TextBox();
            tbMarca = new TextBox();
            nudModelo = new NumericUpDown();
            nudAñoACalcular = new NumericUpDown();
            tbVidaUtil = new TextBox();
            tbTasaDepreciacion = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nudModelo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAñoACalcular).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Marca";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 46);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 1;
            label2.Text = "Modelo (Año)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 88);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 2;
            label3.Text = "Año a calcular";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 128);
            label4.Name = "label4";
            label4.Size = new Size(122, 15);
            label4.TabIndex = 3;
            label4.Text = "Valor de Fabricación $";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(287, 9);
            label5.Name = "label5";
            label5.Size = new Size(117, 15);
            label5.TabIndex = 4;
            label5.Text = "Tasa de depreciación";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(287, 46);
            label6.Name = "label6";
            label6.Size = new Size(87, 15);
            label6.TabIndex = 5;
            label6.Text = "Vida Útil (años)";
            // 
            // btnCalcularCosto
            // 
            btnCalcularCosto.Location = new Point(12, 174);
            btnCalcularCosto.Name = "btnCalcularCosto";
            btnCalcularCosto.Size = new Size(112, 36);
            btnCalcularCosto.TabIndex = 6;
            btnCalcularCosto.Text = "Calcular Costo";
            btnCalcularCosto.UseVisualStyleBackColor = true;
            btnCalcularCosto.Click += btnCalcularCosto_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(403, 174);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 36);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Cerrar";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // tbValorFabricacion
            // 
            tbValorFabricacion.Location = new Point(151, 120);
            tbValorFabricacion.Name = "tbValorFabricacion";
            tbValorFabricacion.Size = new Size(100, 23);
            tbValorFabricacion.TabIndex = 8;
            // 
            // tbMarca
            // 
            tbMarca.Location = new Point(151, 6);
            tbMarca.Name = "tbMarca";
            tbMarca.Size = new Size(100, 23);
            tbMarca.TabIndex = 11;
            // 
            // nudModelo
            // 
            nudModelo.Location = new Point(151, 38);
            nudModelo.Maximum = new decimal(new int[] { 2030, 0, 0, 0 });
            nudModelo.Name = "nudModelo";
            nudModelo.Size = new Size(100, 23);
            nudModelo.TabIndex = 12;
            // 
            // nudAñoACalcular
            // 
            nudAñoACalcular.Location = new Point(151, 80);
            nudAñoACalcular.Maximum = new decimal(new int[] { 2030, 0, 0, 0 });
            nudAñoACalcular.Name = "nudAñoACalcular";
            nudAñoACalcular.Size = new Size(100, 23);
            nudAñoACalcular.TabIndex = 13;
            // 
            // tbVidaUtil
            // 
            tbVidaUtil.Location = new Point(415, 38);
            tbVidaUtil.Name = "tbVidaUtil";
            tbVidaUtil.Size = new Size(100, 23);
            tbVidaUtil.TabIndex = 14;
            // 
            // tbTasaDepreciacion
            // 
            tbTasaDepreciacion.Location = new Point(415, 6);
            tbTasaDepreciacion.Name = "tbTasaDepreciacion";
            tbTasaDepreciacion.Size = new Size(100, 23);
            tbTasaDepreciacion.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 223);
            Controls.Add(tbTasaDepreciacion);
            Controls.Add(tbVidaUtil);
            Controls.Add(nudAñoACalcular);
            Controls.Add(nudModelo);
            Controls.Add(tbMarca);
            Controls.Add(tbValorFabricacion);
            Controls.Add(btnSalir);
            Controls.Add(btnCalcularCosto);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Ejercicio1";
            ((System.ComponentModel.ISupportInitialize)nudModelo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAñoACalcular).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnCalcularCosto;
        private Button btnSalir;
        private TextBox tbValorFabricacion;
        private TextBox tbMarca;
        private NumericUpDown nudModelo;
        private NumericUpDown nudAñoACalcular;
        private TextBox tbVidaUtil;
        private TextBox tbTasaDepreciacion;
    }
}
