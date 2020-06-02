using MusicaVirtual2020.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicaVirtual2020.Datos
{
    public class RepositorioNacionalidades
    {

        private readonly SqlConnection _cn;

        public RepositorioNacionalidades(SqlConnection cn)
        {
            this._cn = cn;
        }

        public List<Nacionalidad> GetLista()
        {
            try
            {
                List<Nacionalidad> lista = new List<Nacionalidad>();
                string cadenaComando = "SELECT NacionalidadId, Nacionalidad FROM Nacionalidades";
                SqlCommand comando = new SqlCommand(cadenaComando, _cn);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Nacionalidad nacionalidad = ConstruirNacionalidad(reader);
                    lista.Add(nacionalidad);
                }
                reader.Close();
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private Nacionalidad ConstruirNacionalidad(SqlDataReader reader)
        {
            return new Nacionalidad
            {
                NacionalidadId = reader.GetInt32(0),
                Nombre = reader.GetString(1)
            };
        }



        public void Agregar(Nacionalidad nacionalidad)
        {
            try
            {
                var cadenaComando = "INSERT INTO Nacionalidades VALUES (@nombre)";
                var comando = new SqlCommand(cadenaComando, _cn);
                comando.Parameters.AddWithValue("@nombre", nacionalidad.Nombre);
                comando.ExecuteNonQuery();
                cadenaComando = "SELECT @@IDENTITY";
                comando = new SqlCommand(cadenaComando, _cn);
                int id = (int)(decimal)comando.ExecuteScalar();
                nacionalidad.NacionalidadId = id;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public bool Existe(Nacionalidad nacionalidad)
        {
            try
            {
                SqlCommand comando = null;
                SqlDataReader reader = null;

                if (nacionalidad.NacionalidadId == 0)
                {
                    var cadenaComando = "SELECT NacionalidadId, Nacionalidad FROM Nacionalidades WHERE Nacionalidad=@nombre";
                    comando = new SqlCommand(cadenaComando, _cn);
                    comando.Parameters.AddWithValue("@nombre", nacionalidad.Nombre);

                }
                else
                {
                    var cadenaComando = "SELECT NacionalidadId, Nacionalidad FROM Nacionalidades WHERE Nacionalidad=@nombre AND NacionalidadId<>@id";
                    comando = new SqlCommand(cadenaComando, _cn);
                    comando.Parameters.AddWithValue("@nombre", nacionalidad.Nombre);
                    comando.Parameters.AddWithValue("@id", nacionalidad.NacionalidadId);
                }

                reader = comando.ExecuteReader();
                return reader.HasRows;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(Nacionalidad nacionalidad)
        {
            try
            {
                var cadenaComando = "SELECT COUNT(*) FROM Interpretes WHERE NacionalidadId=@id";
                var comando = new SqlCommand(cadenaComando, _cn);
                comando.Parameters.AddWithValue("@id", nacionalidad.NacionalidadId);
                int cantidadRegistros = (int)comando.ExecuteScalar();
                if (cantidadRegistros > 0)
                {
                    return true;
                }
                    return false;
                

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void Borrar(Nacionalidad nacionalidad)
        {
            try
            {
                var cadenaComando = "DELETE FROM Nacionalidades WHERE NacionalidadId=@id";
                var comando = new SqlCommand(cadenaComando, _cn);
                comando.Parameters.AddWithValue("@id", nacionalidad.NacionalidadId);
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Editar(Nacionalidad nacionalidad)
        {
            try
            {
                var cadenaComando = "UPDATE Nacionalidades SET Nacionalidad=@nombre WHERE NacionalidadId=@id";
                var comando = new SqlCommand(cadenaComando, _cn);
                comando.Parameters.AddWithValue("@nombre", nacionalidad.Nombre);
                comando.Parameters.AddWithValue("@id", nacionalidad.NacionalidadId);
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public Nacionalidad GetNacionalidadPorId(int id)
        {
            try
            {
                Nacionalidad nacionalidad = null;
                string cadenaComando = "SELECT NacionalidadId, Nacionalidad FROM Nacionalidades WHERE NacionalidadId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _cn);
                comando.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    nacionalidad = ConstruirNacionalidad(reader);
                }
                reader.Close();
                return nacionalidad;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
    }
}

