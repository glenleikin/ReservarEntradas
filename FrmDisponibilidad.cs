using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservaEntradas
{
    public partial class FrmDisponibilidad : Form
    {
        private Form frmAsientos;
        Sistema sistema;
        public FrmDisponibilidad(Form asientos, Sistema sist)
        {
            sistema = sist;
            frmAsientos = asientos;
            InitializeComponent();
        }

        private void FrmDisponibilidad_Load(object sender, EventArgs e)
        {
            listBoxCantAsientos.Items.Add(sistema.AsientosDisponibles());
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
