using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Attributes
{
    public class AttributesAlbum
    {
        private int id_Album;
        private string nombre;
        private int ano_lanzamiento;
        private int id_Artista;

        public int Id_Album { get => id_Album; set => id_Album = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Ano_lanzamiento { get => ano_lanzamiento; set => ano_lanzamiento = value; }
        public int Id_Artista { get => id_Artista; set => id_Artista = value; }

    }
}
