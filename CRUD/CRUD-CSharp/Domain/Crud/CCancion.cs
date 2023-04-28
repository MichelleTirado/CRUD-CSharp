using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Attributes;

namespace Domain.Crud
{
    public class CCancion
    {
        Cancion cancion = new Cancion();

        public DataTable MostrarCanciones()
        {
            DataTable dt = new DataTable();
            dt = cancion.MostrarCanciones();
            return dt;
        }

        public void Insertar(AttributesCancion objCancion)
        {
            cancion.Insertar(objCancion);
        }

        public void Eliminar(AttributesCancion objCancion)
        {
            cancion.Eliminar(objCancion);
        }

        public void Modificar(AttributesCancion objCancion)
        {
            cancion.Modificar(objCancion);
        }
    }
}
