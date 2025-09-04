using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace concesionaria_moto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Moto moto;
        private void btn_calcular_costo_Click(object sender, EventArgs e)
        {
            verResultados ventanaDatos = new verResultados();

            string marca = tbx_marca.Text.Trim();
            int modelo = (int)numeric_modelo.Value;                 // año de fabricación
            double valorFab = Convert.ToDouble(tbx_valor_fabricacion.Text);

            int anioACalcular = (int)numeric_anio_calcular.Value;          // año a calcular
            int vidaUtil = Convert.ToInt32(tbx_vida_util.Text);
            var texto = tbx_tasa_depreciacion.Text.Trim().Replace(',', '.');
            double tasa = double.Parse(texto, CultureInfo.InvariantCulture) / 100.0;

            // Validaciones básicas
            if (anioACalcular < modelo) { MessageBox.Show("El año a calcular no puede ser menor que el modelo."); return; }
            if (vidaUtil <= 0) { MessageBox.Show("La vida útil debe ser mayor que 0."); return; }
            if (tasa < 0 || tasa > 1) { MessageBox.Show("La tasa debe estar entre 0% y 100%."); return; }

            moto = new Moto(marca, modelo, valorFab);

            string desc = moto.VerDescripcion();
            double vLin = moto.CalcularDepreciacionLineal(anioACalcular, vidaUtil);
            double vAnu = moto.CalcularDepreciacionAnual(anioACalcular, tasa);

                var lineas = new string[]
                {
            $"Marca: {marca}",
            $"Modelo (año): {modelo}",
            $"Año a calcular: {anioACalcular}",
            $"Valor de fábrica: {valorFab:C2}",
            $"Valor actualizado (lineal): {vLin:C2}",
            $"Valor actualizado (anual):  {vAnu:C2}"
                };

                ventanaDatos.Cargar(lineas);   //limpia y carga el ListBox
                ventanaDatos.ShowDialog();
        }

        private void numeric_anio_calcular_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
