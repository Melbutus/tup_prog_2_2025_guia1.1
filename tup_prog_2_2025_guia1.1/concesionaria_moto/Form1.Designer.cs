namespace concesionaria_moto
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
            this.lbl_marca = new System.Windows.Forms.Label();
            this.lbl_modelo = new System.Windows.Forms.Label();
            this.lbl_anio_calcular = new System.Windows.Forms.Label();
            this.lbl_valorFabricacion = new System.Windows.Forms.Label();
            this.lbl_tasaDepreciacion = new System.Windows.Forms.Label();
            this.lbl_vidaUtil = new System.Windows.Forms.Label();
            this.tbx_tasa_depreciacion = new System.Windows.Forms.TextBox();
            this.tbx_vida_util = new System.Windows.Forms.TextBox();
            this.tbx_marca = new System.Windows.Forms.TextBox();
            this.tbx_valor_fabricacion = new System.Windows.Forms.TextBox();
            this.numeric_modelo = new System.Windows.Forms.NumericUpDown();
            this.numeric_anio_calcular = new System.Windows.Forms.NumericUpDown();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btn_calcular_costo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_modelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_anio_calcular)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_marca
            // 
            this.lbl_marca.AutoSize = true;
            this.lbl_marca.Location = new System.Drawing.Point(18, 20);
            this.lbl_marca.Name = "lbl_marca";
            this.lbl_marca.Size = new System.Drawing.Size(37, 13);
            this.lbl_marca.TabIndex = 0;
            this.lbl_marca.Text = "Marca";
            // 
            // lbl_modelo
            // 
            this.lbl_modelo.AutoSize = true;
            this.lbl_modelo.Location = new System.Drawing.Point(18, 55);
            this.lbl_modelo.Name = "lbl_modelo";
            this.lbl_modelo.Size = new System.Drawing.Size(70, 13);
            this.lbl_modelo.TabIndex = 1;
            this.lbl_modelo.Text = "Modelo (Año)";
            // 
            // lbl_anio_calcular
            // 
            this.lbl_anio_calcular.AutoSize = true;
            this.lbl_anio_calcular.Location = new System.Drawing.Point(18, 92);
            this.lbl_anio_calcular.Name = "lbl_anio_calcular";
            this.lbl_anio_calcular.Size = new System.Drawing.Size(76, 13);
            this.lbl_anio_calcular.TabIndex = 2;
            this.lbl_anio_calcular.Text = "Año a Calcular";
            // 
            // lbl_valorFabricacion
            // 
            this.lbl_valorFabricacion.AutoSize = true;
            this.lbl_valorFabricacion.Location = new System.Drawing.Point(12, 126);
            this.lbl_valorFabricacion.Name = "lbl_valorFabricacion";
            this.lbl_valorFabricacion.Size = new System.Drawing.Size(113, 13);
            this.lbl_valorFabricacion.TabIndex = 3;
            this.lbl_valorFabricacion.Text = "Valor de Fabricación $";
            // 
            // lbl_tasaDepreciacion
            // 
            this.lbl_tasaDepreciacion.AutoSize = true;
            this.lbl_tasaDepreciacion.Location = new System.Drawing.Point(285, 20);
            this.lbl_tasaDepreciacion.Name = "lbl_tasaDepreciacion";
            this.lbl_tasaDepreciacion.Size = new System.Drawing.Size(112, 13);
            this.lbl_tasaDepreciacion.TabIndex = 4;
            this.lbl_tasaDepreciacion.Text = "Tasa de Depreciación";
            // 
            // lbl_vidaUtil
            // 
            this.lbl_vidaUtil.AutoSize = true;
            this.lbl_vidaUtil.Location = new System.Drawing.Point(285, 55);
            this.lbl_vidaUtil.Name = "lbl_vidaUtil";
            this.lbl_vidaUtil.Size = new System.Drawing.Size(79, 13);
            this.lbl_vidaUtil.TabIndex = 5;
            this.lbl_vidaUtil.Text = "Vida Útil (Años)";
            // 
            // tbx_tasa_depreciacion
            // 
            this.tbx_tasa_depreciacion.Location = new System.Drawing.Point(403, 17);
            this.tbx_tasa_depreciacion.Name = "tbx_tasa_depreciacion";
            this.tbx_tasa_depreciacion.Size = new System.Drawing.Size(100, 20);
            this.tbx_tasa_depreciacion.TabIndex = 6;
            // 
            // tbx_vida_util
            // 
            this.tbx_vida_util.Location = new System.Drawing.Point(403, 52);
            this.tbx_vida_util.Name = "tbx_vida_util";
            this.tbx_vida_util.Size = new System.Drawing.Size(100, 20);
            this.tbx_vida_util.TabIndex = 7;
            // 
            // tbx_marca
            // 
            this.tbx_marca.Location = new System.Drawing.Point(131, 20);
            this.tbx_marca.Name = "tbx_marca";
            this.tbx_marca.Size = new System.Drawing.Size(120, 20);
            this.tbx_marca.TabIndex = 8;
            // 
            // tbx_valor_fabricacion
            // 
            this.tbx_valor_fabricacion.Location = new System.Drawing.Point(131, 123);
            this.tbx_valor_fabricacion.Name = "tbx_valor_fabricacion";
            this.tbx_valor_fabricacion.Size = new System.Drawing.Size(120, 20);
            this.tbx_valor_fabricacion.TabIndex = 9;
            // 
            // numeric_modelo
            // 
            this.numeric_modelo.Location = new System.Drawing.Point(131, 55);
            this.numeric_modelo.Maximum = new decimal(new int[] {
            2060,
            0,
            0,
            0});
            this.numeric_modelo.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numeric_modelo.Name = "numeric_modelo";
            this.numeric_modelo.Size = new System.Drawing.Size(120, 20);
            this.numeric_modelo.TabIndex = 10;
            this.numeric_modelo.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // numeric_anio_calcular
            // 
            this.numeric_anio_calcular.Location = new System.Drawing.Point(131, 90);
            this.numeric_anio_calcular.Maximum = new decimal(new int[] {
            2060,
            0,
            0,
            0});
            this.numeric_anio_calcular.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numeric_anio_calcular.Name = "numeric_anio_calcular";
            this.numeric_anio_calcular.Size = new System.Drawing.Size(120, 20);
            this.numeric_anio_calcular.TabIndex = 11;
            this.numeric_anio_calcular.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numeric_anio_calcular.ValueChanged += new System.EventHandler(this.numeric_anio_calcular_ValueChanged);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(305, 169);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(92, 26);
            this.btn_cerrar.TabIndex = 12;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_calcular_costo
            // 
            this.btn_calcular_costo.Location = new System.Drawing.Point(138, 169);
            this.btn_calcular_costo.Name = "btn_calcular_costo";
            this.btn_calcular_costo.Size = new System.Drawing.Size(113, 26);
            this.btn_calcular_costo.TabIndex = 13;
            this.btn_calcular_costo.Text = "Calcular Costo";
            this.btn_calcular_costo.UseVisualStyleBackColor = true;
            this.btn_calcular_costo.Click += new System.EventHandler(this.btn_calcular_costo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 214);
            this.Controls.Add(this.btn_calcular_costo);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.numeric_anio_calcular);
            this.Controls.Add(this.numeric_modelo);
            this.Controls.Add(this.tbx_valor_fabricacion);
            this.Controls.Add(this.tbx_marca);
            this.Controls.Add(this.tbx_vida_util);
            this.Controls.Add(this.tbx_tasa_depreciacion);
            this.Controls.Add(this.lbl_vidaUtil);
            this.Controls.Add(this.lbl_tasaDepreciacion);
            this.Controls.Add(this.lbl_valorFabricacion);
            this.Controls.Add(this.lbl_anio_calcular);
            this.Controls.Add(this.lbl_modelo);
            this.Controls.Add(this.lbl_marca);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numeric_modelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_anio_calcular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_marca;
        private System.Windows.Forms.Label lbl_modelo;
        private System.Windows.Forms.Label lbl_anio_calcular;
        private System.Windows.Forms.Label lbl_valorFabricacion;
        private System.Windows.Forms.Label lbl_tasaDepreciacion;
        private System.Windows.Forms.Label lbl_vidaUtil;
        private System.Windows.Forms.TextBox tbx_tasa_depreciacion;
        private System.Windows.Forms.TextBox tbx_vida_util;
        private System.Windows.Forms.TextBox tbx_marca;
        private System.Windows.Forms.TextBox tbx_valor_fabricacion;
        private System.Windows.Forms.NumericUpDown numeric_modelo;
        private System.Windows.Forms.NumericUpDown numeric_anio_calcular;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btn_calcular_costo;
    }
}

