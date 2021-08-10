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
    public partial class FrmAsiento : Form
    {
        private FrmVolver frmVolver;
        private FrmDisponibilidad frmDisponibilidad;
        private Form frmHorario;
        Sistema sistema;
        public FrmAsiento(Form horarios, Sistema sist)
        {
            sistema = sist;
            frmHorario = horarios;
            InitializeComponent();
            frmVolver = new FrmVolver(this, sistema);
            frmDisponibilidad = new FrmDisponibilidad(this, sistema);
        }

        private void FrmAsiento_Load(object sender, EventArgs e)
        {

        }

        private void buttonAsiento_Click(object sender, EventArgs e)
        {
            sistema.CargaAsientosAComprar(numericUpDownAsientos.Value);

            if (sistema.ValidaAsiento() == false)
            {
                MessageBox.Show("Debe comprar minimo un asiento");
                return;
            }

            if (sistema.ValidaDisponibilidad() == false)
            {
                MessageBox.Show("Se agotaron los asientos para esta función");
                return;
            }

            if (sistema.ChequeoDeAsientos() == true)
            {
                sistema.CompraEntradas();
                frmVolver.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No hay suficientes asientos disponibles :(");
            }

        }


        private void buttonDisponibilidad_Click(object sender, EventArgs e)
        {
            frmDisponibilidad.Show();
        }
        
    }
}
