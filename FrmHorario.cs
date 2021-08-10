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
    public partial class FrmHorario : Form
    {
        private FrmAsiento frmAsiento;
        private Form frmPeliculas;
        Sistema sistema;

        public FrmHorario(Form peliculas, Sistema sist)
        {
            frmPeliculas = peliculas;
            InitializeComponent();
            sistema = sist;
            frmAsiento = new FrmAsiento(this, sistema);
        }

        private void FrmHorario_Load(object sender, EventArgs e)
        {
            foreach (Funcion f in sistema.añadeHorarios())
            {
                comboBoxHorario.Items.Add(f.Horarios.Hora);
            }

        }

        private void buttonHorario_Click(object sender, EventArgs e)
        {

            if (validarHorario() == false)
            {
                return;
            }

            sistema.HorarioSel(comboBoxHorario.Text);
            frmAsiento.Show();
            this.Hide();
        }
        private bool validarHorario()
        {
            if (string.IsNullOrEmpty(comboBoxHorario.Text))
            {
                MessageBox.Show("Debe seleccionar un horario");
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
