using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaEntradas
{
    [Serializable]
    public class Asiento
    {
        private int numero;
        private bool disponible;

        public Asiento(int num, bool dispo)
        {
            numero = num;
            disponible = dispo;
        }

        public int Numero { get { return numero; } }
        public bool Disponible { get { return disponible; } set { disponible = value; } }

        public bool EstaDisponible()
        {
            if (disponible == true)
            {
                return true;
            }
            else return false;
        }

        public void Ocupado(Asiento ocupado)
        {
            ocupado.Disponible = false;
        }
    }
 
}
