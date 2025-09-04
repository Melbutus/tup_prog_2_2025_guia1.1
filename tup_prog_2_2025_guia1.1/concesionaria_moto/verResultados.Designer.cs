namespace concesionaria_moto
{
    partial class verResultados
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
            this.lbx_verResultados = new System.Windows.Forms.ListBox();
            this.btn_cerrar_verResultados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbx_verResultados
            // 
            this.lbx_verResultados.FormattingEnabled = true;
            this.lbx_verResultados.Location = new System.Drawing.Point(12, 20);
            this.lbx_verResultados.Name = "lbx_verResultados";
            this.lbx_verResultados.Size = new System.Drawing.Size(301, 121);
            this.lbx_verResultados.TabIndex = 0;
            // 
            // btn_cerrar_verResultados
            // 
            this.btn_cerrar_verResultados.Location = new System.Drawing.Point(113, 159);
            this.btn_cerrar_verResultados.Name = "btn_cerrar_verResultados";
            this.btn_cerrar_verResultados.Size = new System.Drawing.Size(75, 23);
            this.btn_cerrar_verResultados.TabIndex = 1;
            this.btn_cerrar_verResultados.Text = "Cerrar";
            this.btn_cerrar_verResultados.UseVisualStyleBackColor = true;
            this.btn_cerrar_verResultados.Click += new System.EventHandler(this.button1_Click);
            // 
            // verResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 194);
            this.Controls.Add(this.btn_cerrar_verResultados);
            this.Controls.Add(this.lbx_verResultados);
            this.Name = "verResultados";
            this.Text = "verResultados";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_verResultados;
        private System.Windows.Forms.Button btn_cerrar_verResultados;
    }
}