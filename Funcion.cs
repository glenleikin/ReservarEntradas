using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaEntradas
{
    [Serializable]
    public class Funcion
    {
        private Asiento[] asiento;
        private Horario horarios; 
        private Pelicula pelicula;

        public Funcion(int num, Horario hora, Pelicula peli)
        {
            asiento = new Asiento[num];
            for (int i = 0; i < num; i++)
            {
                asiento[i] = new Asiento(i, true);
            }

            this.horarios = hora;
            this.pelicula = peli;
        }

        public Horario Horarios { get { return horarios; } }
        public Pelicula Pelicula { get { return pelicula; } }
        public Asiento [] Asiento { get { return asiento; } }

        public bool EstaPelicula(string peliSeleccionada)
        {
            if (peliSeleccionada == pelicula.Titulo)
                return true;
            else return false;
        }

        public bool EstaHorario(string horaSeleccionada)
        {
            if (horaSeleccionada == horarios.Hora)
                return true;
            else return false;
        }

           public bool HayAsientos()
            {
                if (asiento[Asiento.Length - 1].EstaDisponible())
                {
                    return true;
                }
                return false;
            }

        public int RecorrerDisponibilidad()
        {
            int disponible = 0;
            for (int j = 0; j <= Asiento.Length-1; j++)
            {
                if (Asiento[j].EstaDisponible())
                {
                    disponible += 1;
                }
            }

            return disponible;
        }

        public void Compra()
        {
            for (int j = 0; j <= Asiento.Length-1; j++)
            {
                if (Asiento[j].EstaDisponible())
                {
                    Asiento[j].Ocupado(Asiento[j]);
                    break;
                }
            }
        }

    }
}
