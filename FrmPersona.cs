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
    public partial class formPersona : Form
    {
        Sistema sistema;
        private FrmPeliculas frmPeliculas;
        Persona persona;
        public formPersona(Sistema sist)
        {
            sistema = sist;
            InitializeComponent();
            frmPeliculas = new FrmPeliculas(this, sistema);
        }

        private void buttonPersona_Click(object sender, EventArgs e)
        {
            if (validarNombre() == false)
            {
                return;
            }
            if (validarEdad() == false)
            {
                return;
            }

            persona = sistema.creaPersona();
            persona.Nombre = nombrePersona.Text;
            double d = (double)numericUpDownPersona.Value;
            int x = (int)Math.Round(d);
            persona.Edad = x;

            sistema.ObtieneEdad(persona);

            frmPeliculas.Show();
            this.Hide();
        }

        private bool validarNombre()
        {
            if (string.IsNullOrEmpty(nombrePersona.Text))
            {
                MessageBox.Show("Debe ingresar un nombre");
                return false;
            }

            else
            {
                return true;
            }
        }
        private bool validarEdad()
            {
                if (numericUpDownPersona.Value == 0)
                {
                    MessageBox.Show("Debe ingresar una edad real");
                    return false;
                }

                else
                {
                    return true;
                }
            }

        private void formPersona_Load(object sender, EventArgs e)
        {

        }

        private void formPersona_Load_1(object sender, EventArgs e)
        {

        }
    }
}
