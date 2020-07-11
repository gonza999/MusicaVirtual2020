using MusicaVirtual2020.Entidades.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicaVirtual2020.Datos
{
    public class RepositorioTemas
    {
        private readonly SqlConnection conexion;
        public RepositorioTemas(SqlConnection conexion)
        {
            this.conexion = conexion;
        }

        public void Agregar(Tema tema,SqlTransaction transaction)
        {
            try
            {
                var cadenaDeComando = "INSERT INTO Temas (PistaNumero,Nombre,Duracion,AlbumId) VALUES (@nro,@tema,@duracion,@albumId) ";
                var comando =new SqlCommand(cadenaDeComando,conexion,transaction);
                comando.Parameters.AddWithValue("@nro",tema.PistaNumero);
                comando.Parameters.AddWithValue("@tema",tema.Nombre);
                comando.Parameters.AddWithValue("@duracion",tema.Duracion);
                comando.Parameters.AddWithValue("@albumId",tema.Album.AlbumId);
                comando.ExecuteNonQuery();


            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
