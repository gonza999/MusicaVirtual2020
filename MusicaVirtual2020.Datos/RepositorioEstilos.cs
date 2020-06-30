using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using MusicaVirtual2020.Entidades;

namespace MusicaVirtual2020.Datos
{
    public class RepositorioEstilos
    {
        private readonly SqlConnection _cn;

        public RepositorioEstilos(SqlConnection cn)
        {
            this._cn = cn;
        }

        public void Agregar(Estilo estilo)
        {
            try
            {
                var cadenaComando = "INSERT INTO Estilos VALUES (@estilo)";
                var comando=new SqlCommand(cadenaComando,_cn);
                comando.Parameters.AddWithValue("@estilo", estilo.Nombre);
                comando.ExecuteNonQuery();
                cadenaComando = "SELECT @@Identity";
                comando=new SqlCommand(cadenaComando,_cn);
                int id =(int)(decimal) comando.ExecuteScalar();
                estilo.EstiloId = id;
            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
        }
        public List<Estilo> GetLista()
        {
            try
            {
                List<Estilo> lista=new List<Estilo>();
                string cadenaComando = "SELECT EstiloId, Estilo FROM Estilos";
                var comando=new SqlCommand(cadenaComando, _cn);
                var reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Estilo estilo = ConstruirEstilo(reader); 
                    lista.Add(estilo);
                }
                reader.Close();
                return lista;
            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
        }

        public bool Existe(Estilo estilo)
        {
            try
            {
                SqlCommand comando = null;
                SqlDataReader reader = null;

                if (estilo.EstiloId == 0)
                {
                    var cadenaComando = "SELECT EstiloId, Estilo FROM Estilos WHERE Estilo=@nombre";
                    comando = new SqlCommand(cadenaComando, _cn);
                    comando.Parameters.AddWithValue("@nombre", estilo.Nombre);

                }
                else
                {
                    var cadenaComando = "SELECT EstiloId, Estilo FROM Estilos WHERE Estilo=@nombre AND EstiloId<>@id";
                    comando = new SqlCommand(cadenaComando, _cn);
                    comando.Parameters.AddWithValue("@nombre", estilo.Nombre);
                    comando.Parameters.AddWithValue("@id", estilo.EstiloId);
                }

                reader = comando.ExecuteReader();
                return reader.HasRows;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        private Estilo ConstruirEstilo(SqlDataReader reader)
        {
            return new Estilo
            {
                EstiloId = reader.GetInt32(0),
                Nombre = reader.GetString(1)
            };
        }


      
    }
}
