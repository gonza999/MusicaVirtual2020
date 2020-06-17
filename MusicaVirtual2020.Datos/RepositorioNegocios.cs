using MusicaVirtual2020.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicaVirtual2020.Datos
{
    public class RepositorioNegocios
    {
        private readonly SqlConnection _cn;
        private readonly RepositorioPaises _repositorioPais;

        public RepositorioNegocios(SqlConnection cn, RepositorioPaises repositorioPais)
        {
            this._cn = cn;
            this._repositorioPais = repositorioPais;
        }

        public RepositorioNegocios(SqlConnection cn)
        {
            _cn = cn;
        }
        public bool EstaRelacionado(Negocio negocio)
        {
            try
            {
                var cadenaComando = "SELECT COUNT(*) FROM Albumes WHERE NegocioId=@id";
                var comando = new SqlCommand(cadenaComando, _cn);
                comando.Parameters.AddWithValue("@id", negocio.NegocioId);
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

        public void Borrar(Negocio negocio)
        {
            try
            {
                string cadenaComando = "DELETE FROM Negocios WHERE NegocioId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _cn);
                comando.Parameters.AddWithValue("@id", negocio.NegocioId);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool Existe(Negocio negocio)
        {
            try
            {
                SqlCommand comando = null;
                SqlDataReader reader = null;

                if (negocio.NegocioId == 0)
                {
                    var cadenaComando = "SELECT NegocioId, Negocio, PaisId FROM Negocios WHERE Negocio=@nombre AND PaisId=@paisId";
                    comando = new SqlCommand(cadenaComando, _cn);
                    comando.Parameters.AddWithValue("@nombre", negocio.Nombre);
                    comando.Parameters.AddWithValue("@paisId", negocio.Pais.PaisId);

                }
                else
                {
                    var cadenaComando = "SELECT NegocioId, Negocio, PaisId FROM Negocios WHERE Negocio=@nombre AND PaisId=@paisId AND NegocioId<>@id";
                    comando = new SqlCommand(cadenaComando, _cn);
                    comando.Parameters.AddWithValue("@nombre", negocio.Nombre);
                    comando.Parameters.AddWithValue("@paisId", negocio.Pais.PaisId);
                    comando.Parameters.AddWithValue("@id", negocio.NegocioId);
                }

                reader = comando.ExecuteReader();
                return reader.HasRows;

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
        public void Agregar(Negocio negocio)
        {
            try
            {
                string cadenaComando = "INSERT INTO Negocios VALUES (@nombre, @paisid)";
                SqlCommand comando = new SqlCommand(cadenaComando, _cn);
                comando.Parameters.AddWithValue("@nombre", negocio.Nombre);
                comando.Parameters.AddWithValue("@paisid", negocio.Pais.PaisId);
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
        public List<Negocio> GetNegocios(Pais pais = null)
        {
            try
            {
                List<Negocio> lista = new List<Negocio>();
                var cadenaComando = "SELECT NegocioId, Negocio, PaisId FROM Negocios ";
                var whereCondicion = pais != null ? " WHERE PaisId=@paisId" : String.Empty;
                var orderBy = " ORDER BY Negocio";
                var comando = new SqlCommand($"{cadenaComando}{whereCondicion}{orderBy}", _cn);
                if (pais != null)
                {
                    comando.Parameters.AddWithValue("@paisId", pais.PaisId);
                }
                var reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    var negocio = ConstruirNegocio(reader);
                    lista.Add(negocio);
                }
                reader.Close();
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        private Negocio ConstruirNegocio(SqlDataReader reader)
        {
            return new Negocio
            {
                NegocioId = reader.GetInt32(0),
                Nombre = reader.GetString(1),
                Pais = _repositorioPais.GetPaisPorId(reader.GetInt32(2))
            };
        }

    }
}
