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
    public class CArtista
    {

        Artista artista = new Artista();

        public DataTable MostrarArtista()
        {
            DataTable dt = new DataTable();
            dt = artista.MostrarArtista();
            return dt;
        }

        public Dictionary<int, string> Mostrar()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary = artista.MostrarNombreArtista();

            return dictionary;
        }

        public void Insertar(AttributesArtista objArtista)
        {
            artista.Insertar(objArtista);
        }

        public void Eliminar(AttributesArtista objArtista)
        {
            artista.Eliminar(objArtista);
        }

        public void Modificar(AttributesArtista objArtista)
        {
            artista.Modificar(objArtista);
        }

    }
}
