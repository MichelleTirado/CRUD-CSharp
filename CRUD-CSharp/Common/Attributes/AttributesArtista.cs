using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Attributes
{
    public class AttributesArtista
    {
        private int id_Artista;
        private string nombre;
        private string genero_Musical;
        private string pais_Origen;

        public int Id_Artista { get => id_Artista; set => id_Artista = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Genero_Musical { get => genero_Musical; set => genero_Musical = value; }
        public string Pais_Origen { get => pais_Origen; set => pais_Origen = value; }


    }
}
