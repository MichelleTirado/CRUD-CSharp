using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Common.Attributes;
using System.Diagnostics;

namespace DataAccess.Entities
{
    public class Artista
    {
        //Variables
        Connection_DataBase c = new Connection_DataBase();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader rdr;
        DataTable dt = new DataTable();
        Dictionary<int, string> nombresArtista = new Dictionary<int, string>();


        public DataTable MostrarArtista()
        {
            try
            {
                cmd.Connection = c.OpenConnection();
                cmd.CommandText = "SP_Mostrar_Artista";
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

        public Dictionary<int, string> MostrarNombreArtista()
        {
            try
            {
                cmd.Connection = c.OpenConnection();
                cmd.CommandText = "SP_Mostrar_NombreArtistas";
                cmd.CommandType = CommandType.StoredProcedure;
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    int id = rdr.GetInt32(0);
                    string nombre = rdr.GetString(1);
                    nombresArtista.Add(id, nombre);
                }
                return nombresArtista;

            }
            catch (Exception ex)
            {
                string msj = ex.ToString();
                return nombresArtista;
            }
            finally
            {
                cmd.Connection = c.CloseConnection();
            }
        }

        public void Insertar(AttributesArtista objArtista)
        {

            try
            {
                cmd.Connection = c.OpenConnection();
                cmd.CommandText = "SP_Insertar_Artista";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", objArtista.Nombre);
                cmd.Parameters.AddWithValue("@Genero_Musical", objArtista.Genero_Musical);
                cmd.Parameters.AddWithValue("@Pais_Origen", objArtista.Pais_Origen);

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
        public void Eliminar(AttributesArtista objArtista)
        {

            try
            {
                cmd.Connection = c.OpenConnection();
                cmd.CommandText = "SP_Delete_Artista";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Artista", objArtista.Id_Artista);

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

        public void Modificar(AttributesArtista objArtista)
        {
            try
            {
                cmd.Connection = c.OpenConnection();

                cmd.CommandText = "SP_Update_Artista";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Artista", objArtista.Id_Artista);
                cmd.Parameters.AddWithValue("@Nombre", objArtista.Nombre);
                cmd.Parameters.AddWithValue("@Genero_Artista", objArtista.Genero_Musical);
                cmd.Parameters.AddWithValue("@Pais_Origen", objArtista.Pais_Origen);

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
