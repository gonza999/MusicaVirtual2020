using MusicaVirtual2020.Entidades;
using MusicaVirtual2020.Entidades.DTOs;
using MusicaVirtual2020.Entidades.DTOs.Album;
using MusicaVirtual2020.Entidades.DTOs.Interprete;
using MusicaVirtual2020.Entidades.Mapas;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicaVirtual2020.Datos
{
    public class RepositorioAlbumes
    {
        private readonly SqlConnection cn;
        //private RepositorioInterpretes repositorioInterpretes;

        public RepositorioAlbumes(SqlConnection cn)
        {
            this.cn = cn;
            //this.repositorioInterpretes = repositorioInterpretes;
        }

        public List<AlbumListDto> GetLista()
        {
            try
            {
                List<AlbumListDto> lista = new List<AlbumListDto>();
                var cadenaDeComando = "SELECT AlbumId,Album,Interprete,Pistas FROM Albumes INNER JOIN Interpretes " +
                    "ON Interpretes.InterpreteId=Albumes.InterpreteId";
                var comando = new SqlCommand(cadenaDeComando,cn);
                var reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    AlbumListDto albumDto = ConstruirAlbumDto(reader);
                    lista.Add(albumDto);
                }
                reader.Close();
                return lista;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private AlbumListDto ConstruirAlbumDto(SqlDataReader reader)
        {
            return new AlbumListDto
            {
                AlbumId = reader.GetInt32(0),
                Titulo = reader.GetString(1),
                Interprete = reader.GetString(2),
                Pistas =reader.GetInt32(3)
            };
        }

        public List<InterpretesAlbumesDto> GetCantidadXInterprete()
        {
            try
            {
                List<InterpretesAlbumesDto> lista = new List<InterpretesAlbumesDto>();
                var cadenaDeComando = "SELECT i.Interprete,Count(a.Album) "+
                        " FROM Albumes a JOIN Interpretes I ON a.InterpreteId = i.InterpreteId "+
                        " GROUP BY i.Interprete";
                var comando = new SqlCommand(cadenaDeComando, cn);
                var reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    InterpretesAlbumesDto albumDto = ConstruirInterpretesAlbumesDto(reader);
                    lista.Add(albumDto);
                }
                reader.Close();
                return lista;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private InterpretesAlbumesDto ConstruirInterpretesAlbumesDto(SqlDataReader reader)
        {
            return new InterpretesAlbumesDto()
            {
                Interprete=reader.GetString(0),
                Cantidad=reader.GetInt32(1)
            };
        }

        public void Agregar(Album album,SqlTransaction transaction)
        {
            try
            {
                var cadenaDeComando = "INSERT INTO Albumes (Album,InterpreteId,EstiloId,SoporteId,Pistas,NegocioId,AñoComprado,Costo )" +
                    "VALUES (@album,@interpreteId,@estiloId,@soporteId,@pistas,@negocioId,@anioComprado,@costo)";
                var comando = new SqlCommand(cadenaDeComando,cn,transaction);
                comando.Parameters.AddWithValue("@album",album.Titulo);
                comando.Parameters.AddWithValue("@interpreteId", album.Interprete.InterpreteId);
                comando.Parameters.AddWithValue("@estiloId", album.Estilo.EstiloId);
                comando.Parameters.AddWithValue("@soporteId", album.Soporte.SoporteId);
                comando.Parameters.AddWithValue("@pistas", album.Pistas);
                comando.Parameters.AddWithValue("@negocioId", album.Negocio.NegocioId);
                comando.Parameters.AddWithValue("@anioComprado", album.AñoComprado);
                comando.Parameters.AddWithValue("@costo", album.Costo);
                comando.ExecuteNonQuery();

                cadenaDeComando = "SELECT @@identity";
                comando = new SqlCommand(cadenaDeComando,cn,transaction);
                var id = (int)(decimal)comando.ExecuteScalar();
                album.AlbumId = id;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
