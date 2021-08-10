using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Windows.Forms;



namespace ReservaEntradas
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        
        [STAThread]
        static void Main()
        {
            Sistema sistema = new Sistema();

            if (File.Exists("serializacion2.bin"))
            {
                Stream flujo = File.OpenRead("serializacion2.bin");
                BinaryFormatter deserializar = new BinaryFormatter();
                sistema = (Sistema)deserializar.Deserialize(flujo);
                flujo.Close();
            } 

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new formPersona(sistema));

            Stream flujo2 = File.Create("serializacion2.bin");
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(flujo2, sistema);
            flujo2.Close();
        }

    }
}
