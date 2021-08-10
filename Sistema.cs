using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ReservaEntradas
{
    [Serializable]
    public class Sistema
    {
        List<Pelicula> Peliculas = new List<Pelicula>();
        List<Horario> Horarios = new List<Horario>();
        List<Funcion> Funciones = new List<Funcion>();
        private int edad;
        private string pelicula;
        private string horario;
        private decimal cantidad;

        public Sistema()
        {
            Peliculas.Add(new Pelicula("Tiempos violentos", 18));
            Peliculas.Add(new Pelicula("La naranja mecánica", 18));
            Peliculas.Add(new Pelicula("El resplandor", 13));
            Peliculas.Add(new Pelicula("Taxi Driver", 0));
            Peliculas.Add(new Pelicula("1984", 0));

            Horarios.Add(new Horario("Mañana"));
            Horarios.Add(new Horario("Tarde"));
            Horarios.Add(new Horario("Noche"));

            Funciones.Add(new Funcion(20, Horarios[0], Peliculas[0])); //mañana, tiempos violentos
            Funciones.Add(new Funcion(20, Horarios[1], Peliculas[0])); //tarde, tiempos violentos
            Funciones.Add(new Funcion(20, Horarios[0], Peliculas[1])); //mañana, la naranja
            Funciones.Add(new Funcion(20, Horarios[2], Peliculas[1])); //noche, ña naranja
            Funciones.Add(new Funcion(20, Horarios[1], Peliculas[2])); //tarde, el resplandor
            Funciones.Add(new Funcion(20, Horarios[2], Peliculas[2])); //noche, el resplandor
            Funciones.Add(new Funcion(20, Horarios[0], Peliculas[3])); //mañana, taxi driver
            Funciones.Add(new Funcion(20, Horarios[2], Peliculas[3])); //tarde, taxi driver
            Funciones.Add(new Funcion(20, Horarios[0], Peliculas[4])); //mañana, 1984

        }

        public Persona creaPersona()
        {
            Persona pers = new Persona();
            return pers;
        }

        public void ObtieneEdad(Persona pers)
        {
            edad = pers.Edad;
        }

        public List<Pelicula> añadePelis()
        {
            List<Pelicula> arrayPelis = new List<Pelicula>();
            foreach (Pelicula p in Peliculas)
            {
                if (edad >= p.EdadMinima)
                {
                    arrayPelis.Add(p);
                }
            }
            return arrayPelis;
        }

        public List<Funcion> añadeHorarios()
        {
            List<Funcion> arrayFunciones = new List<Funcion>();

            foreach (Funcion f in Funciones)
            {
                if (f.EstaPelicula(pelicula))
                {
                    arrayFunciones.Add(f);
                }
            }

            return arrayFunciones;
        }

        public void PeliculaSel(string peli)
        {
            pelicula = peli;
        }
        public void HorarioSel(string hora)
        {
            horario = hora;
        }

        public void CargaAsientosAComprar(decimal cant)
        {
            cantidad = cant;
        }

        public int AsientosDisponibles() 
        {
            int disponibles = 0;
            return disponibles = Funcion().RecorrerDisponibilidad();
        }

        public bool ChequeoDeAsientos()
        {
            if (cantidad <= AsientosDisponibles())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void CompraEntradas()
        {
            for (int i = 1; i <= cantidad; i++)
            {
               Funcion().Compra();
            }
        }

        public bool ValidaDisponibilidad()
        {
            bool asiento;
            return asiento = Funcion().HayAsientos();
        }

        public bool ValidaAsiento()
        {
            if (cantidad == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public Funcion Funcion()
        {
            foreach (Funcion f in Funciones)
            {
                if (f.EstaPelicula(pelicula) && f.EstaHorario(horario))
                {
                    return f;
                }
            }
            return null;          
        }

    }
}
