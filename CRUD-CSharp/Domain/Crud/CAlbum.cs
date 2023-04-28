using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess.Entities;
using Common.Attributes;

namespace Domain.Crud
{
    public class CAlbum
    {
        Album album = new Album();

        public DataTable MostrarAlbumes()
        {
            DataTable dt = new DataTable();
            dt = album.MostrarAlbumes();
            return dt;
        }

        public Dictionary<int, string> Mostrar()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary = album.MostrarNombreAlbum();

            return dictionary;
        }

        public void Insertar(AttributesAlbum objAlbum)
        {
            album.Insertar(objAlbum);
        }

        public void Eliminar(AttributesAlbum objAlbum)
        {
            album.Eliminar(objAlbum);
        }

        public void Modificar(AttributesAlbum objAlbum)
        {
            album.Modificar(objAlbum);
        }
    }
}
