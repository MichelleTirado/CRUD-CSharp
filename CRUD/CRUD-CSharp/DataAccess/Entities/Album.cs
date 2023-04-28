using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using Common.Attributes;

namespace DataAccess.Entities
{
    public class Album
    {
        //Variables 
        Connection_DataBase c = new Connection_DataBase();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader rdr;
        DataTable dt = new DataTable();
        Dictionary<int, string> nombresAlbum = new Dictionary<int, string>();

        public DataTable MostrarAlbumes()
        {
            try
            {
                cmd.Connection = c.OpenConnection();
                cmd.CommandText = "SP_Mostrar_Albumes";
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

        public Dictionary<int, string> MostrarNombreAlbum()
        {
            try
            {
                cmd.Connection = c.OpenConnection();
                cmd.CommandText = "SP_Mostrar_NombreAlbumes";
                cmd.CommandType = CommandType.StoredProcedure;
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    int id = rdr.GetInt32(0);
                    string nombre = rdr.GetString(1);
                    nombresAlbum.Add(id, nombre);
                }
                return nombresAlbum;

            }
            catch (Exception ex)
            {
                string msj = ex.ToString();
                return nombresAlbum;
            }
            finally
            {
                cmd.Connection = c.CloseConnection();
            }
        }

        public void Insertar(AttributesAlbum objAlbum)
        {

            try
            {
                cmd.Connection = c.OpenConnection();
                cmd.CommandText = "SP_Insertar_Album";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", objAlbum.Nombre);
                cmd.Parameters.AddWithValue("@Ano_Lanzamiento", objAlbum.Ano_lanzamiento);
                cmd.Parameters.AddWithValue("@Id_Artista", objAlbum.Id_Artista);

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

        public void Eliminar(AttributesAlbum objAlbum)
        {

            try
            {
                cmd.Connection = c.OpenConnection();
                cmd.CommandText = "SP_Delete_Album";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Album", objAlbum.Id_Album);

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

        public void Modificar(AttributesAlbum objAlbum)
        {
            try
            {
                cmd.Connection = c.OpenConnection();

                cmd.CommandText = "SP_Update_Album";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Album", objAlbum.Id_Album);
                cmd.Parameters.AddWithValue("@Nombre", objAlbum.Nombre);
                cmd.Parameters.AddWithValue("@Ano_Lanzamiento", objAlbum.Ano_lanzamiento);
                cmd.Parameters.AddWithValue("@Id_Artista", objAlbum.Id_Artista);

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
