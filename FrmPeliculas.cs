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
    public partial class FrmPeliculas : Form
    {
        Sistema sistema;
        private Form frmPersona;
        private FrmHorario frmHorario;

        public FrmPeliculas(Form persona, Sistema sist)
        {
            frmPersona = persona;
            sistema = sist;
            InitializeComponent();
            frmHorario = new FrmHorario(this, sistema);
        }

        private void FrmPeliculas_Load(object sender, EventArgs e)
        {
            foreach (Pelicula p in sistema.añadePelis())
            {
                comboBoxPeliculas.Items.Add(p.Titulo);
            }

        }

        private void buttonPeliculas_Click(object sender, EventArgs e)
        {
            if (validarPelicula() == false)
            {
                return;
            }

            sistema.PeliculaSel(comboBoxPeliculas.Text);
            frmHorario.Show();
            this.Hide();
        }
        private bool validarPelicula()
        {
            if (string.IsNullOrEmpty(comboBoxPeliculas.Text))
            {
                MessageBox.Show("Debe seleccionar una pelicula");
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
