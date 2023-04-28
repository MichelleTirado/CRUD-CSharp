using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Attributes;

namespace DataAccess.Entities
{
    public class Cancion
    {
        //Variables
        Connection_DataBase c = new Connection_DataBase();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader rdr;
        DataTable dt = new DataTable();

        public DataTable MostrarCanciones()
        {
            try
            {
                cmd.Connection = c.OpenConnection();
                cmd.CommandText = "SP_Mostrar_Canciones";
                cmd.CommandType = CommandType.StoredProcedure;
                rdr = cmd.ExecuteReader();

                dt.Load(rdr);
            }
            catch (Exception ex)
            {
                string msj = ex.ToString();
            }
            finally
            {
                cmd.Connection = c.CloseConnection();
            }
            return dt;
        }

        public void Insertar(AttributesCancion objCancion)
        {

            cmd.Connection = c.OpenConnection();
            cmd.CommandText = "SP_Insertar_Cancion";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Nombre", objCancion.Nombre);
            cmd.Parameters.AddWithValue("@Duracion", objCancion.Duracion);
            cmd.Parameters.AddWithValue("@Id_Album", objCancion.Id_Album);

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public void Eliminar(AttributesCancion objCancion)
        {
            try
            {
                cmd.Connection = c.OpenConnection();
                cmd.CommandText = "SP_Delete_Cancion";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Cancion", objCancion.Id_Cancion);

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                string msj = ex.ToString();
            }
            finally
            {
                cmd.Connection = c.CloseConnection();
            }
        }

        public void Modificar(AttributesCancion objCancion)
        {
            try
            {
                cmd.Connection = c.OpenConnection();

                cmd.CommandText = "SP_Update_Cancion";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Cancion", objCancion.Id_Cancion);
                cmd.Parameters.AddWithValue("@Nombre", objCancion.Nombre);
                cmd.Parameters.AddWithValue("@Duracion", objCancion.Duracion);
                cmd.Parameters.AddWithValue("@Id_Album", objCancion.Id_Album);

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                string msj = ex.ToString();
            }
            finally
            {
                cmd.Connection = c.CloseConnection();
            }
        }

    }
}
