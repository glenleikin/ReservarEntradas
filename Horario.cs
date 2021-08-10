using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaEntradas
{
    [Serializable]
    public class Horario
    {
        private string hora;

        public Horario(string horario)
        {
            hora = horario;
        }

        public string Hora { get { return hora; } }
    }
}
