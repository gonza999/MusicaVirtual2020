using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using MusicaVirtual2020.Entidades;

namespace MusicaVirtual2020.Datos
{
    public class RepositorioInterpretes
    {
        private readonly SqlConnection _cn;
        private readonly RepositorioNacionalidades _repositorioNacionalidad;

        public RepositorioInterpretes(SqlConnection cn, RepositorioNacionalidades repositorioNacionalidad)
        {
            this._cn = cn;
            this._repositorioNacionalidad = repositorioNacionalidad;
        }

        public RepositorioInterpretes(SqlConnection cn)
        {
            _cn = cn;
        }
        public bool EstaRelacionado(Interprete interprete)
        {
            try
            {
                var cadenaComando = "SELECT COUNT(*) FROM Albumes WHERE InterpreteId=@id";
                var comando = new SqlCommand(cadenaComando, _cn);
                comando.Parameters.AddWithValue("@id", interprete.InterpreteId);
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

        public void Borrar(Interprete interprete)
        {
            try
            {
                string cadenaComando = "DELETE FROM Interpretes WHERE InterpreteId=@id";
                SqlCommand comando=new SqlCommand(cadenaComando,_cn);
                comando.Parameters.AddWithValue("@id", interprete.InterpreteId);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool Existe(Interprete interprete)
        {
            try
            {
                SqlCommand comando = null;
                SqlDataReader reader = null;

                if (interprete.InterpreteId == 0)
                {
                    var cadenaComando = "SELECT InterpreteId, Interprete, NacionalidadId FROM Interpretes WHERE Interprete=@nombre AND NacionalidadId=@nacionalidadId";
                    comando = new SqlCommand(cadenaComando, _cn);
                    comando.Parameters.AddWithValue("@nombre", interprete.Nombre);
                    comando.Parameters.AddWithValue("@nacionalidadId", interprete.Nacionalidad.NacionalidadId);

                }
                else
                {
                    var cadenaComando = "SELECT InterpreteId, Interprete, NacionalidadId FROM Interpretes WHERE Interprete=@nombre AND NacionalidadId=@nacionalidadId AND InterpreteId<>@id";
                    comando = new SqlCommand(cadenaComando, _cn);
                    comando.Parameters.AddWithValue("@nombre", interprete.Nombre);
                    comando.Parameters.AddWithValue("@nacionalidadId", interprete.Nacionalidad.NacionalidadId);
                    comando.Parameters.AddWithValue("@id", interprete.InterpreteId);
                }

                reader = comando.ExecuteReader();
                return reader.HasRows;

            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
        }
        public void Agregar(Interprete interprete)
        {
            try
            {
                string cadenaComando = "INSERT INTO Interpretes VALUES (@nombre, @nacionalidadid)";
                SqlCommand comando=new SqlCommand(cadenaComando,_cn);
                comando.Parameters.AddWithValue("@nombre", interprete.Nombre);
                comando.Parameters.AddWithValue("@nacionalidadid", interprete.Nacionalidad.NacionalidadId);
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
        }
        public List<Interprete> GetInterpretes(Nacionalidad nacionalidad=null)
        {
            try
            {
                List<Interprete> lista = new List<Interprete>();
                var cadenaComando = "SELECT InterpreteId, Interprete, NacionalidadId FROM Interpretes ";
                var whereCondicion =nacionalidad!=null ? " WHERE NacionalidadId=@nacionalidadId" : String.Empty;
                var orderBy =    " ORDER BY Interprete";
                var comando = new SqlCommand($"{cadenaComando}{whereCondicion}{orderBy}", _cn);
                if (nacionalidad!=null)
                {
                    comando.Parameters.AddWithValue("@nacionalidadId",nacionalidad.NacionalidadId);
                }
                var reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    var interprete = ConstruirInterprete(reader);
                    lista.Add(interprete);
                }
                reader.Close();
                return lista;
            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
        }

        private Interprete ConstruirInterprete(SqlDataReader reader)
        {
            return new Interprete
            {
                InterpreteId = reader.GetInt32(0),
                Nombre = reader.GetString(1),
                Nacionalidad = _repositorioNacionalidad.GetNacionalidadPorId(reader.GetInt32(2))
            };
        }
    }
}
