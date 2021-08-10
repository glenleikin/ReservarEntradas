using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaEntradas
{
    [Serializable]
    public class Pelicula
    {
        private string titulo;
        private int edadMinima;

        public Pelicula(string titu, int edadMin)
        {
            titulo = titu;
            edadMinima = edadMin;
        }

        public string Titulo { get { return titulo; } }
        //metodo q retorne un bool y recibe el titulo 
        public int EdadMinima { get { return edadMinima; } }

      /*  public bool edadMinima()
        {

        }*/
    }
}
