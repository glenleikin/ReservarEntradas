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
    public partial class FrmVolver : Form
    {
        private Form frmAsiento;
        Sistema sistema;
        public FrmVolver(Form asiento, Sistema sist)
        {
            sistema = sist;
            frmAsiento = asiento;
            InitializeComponent();
        }

        private void FrmVolver_Load(object sender, EventArgs e)
        {
                
        }

        private void btnNuevaCompra_Click(object sender, EventArgs e)
        {
            Application.Restart();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
