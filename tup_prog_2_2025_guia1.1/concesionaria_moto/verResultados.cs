using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace concesionaria_moto
{
    public partial class verResultados : Form
    {
        public verResultados()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbx_verResultados.Items.Clear();
            Close();
        }

        public void Cargar(string[] lineas)
        {
            lbx_verResultados.Items.Clear();
            lbx_verResultados.Items.AddRange(lineas); 
        }
    }
}
