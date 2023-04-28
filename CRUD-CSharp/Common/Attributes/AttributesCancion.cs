using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Attributes
{
    public class AttributesCancion
    {
        private int id_Cancion;
        private string nombre;
        private string duracion;
        private int id_Album;

        public int Id_Cancion { get => id_Cancion; set => id_Cancion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Duracion { get => duracion; set => duracion = value; }
        public int Id_Album { get => id_Album; set => id_Album = value; }

    }
}
