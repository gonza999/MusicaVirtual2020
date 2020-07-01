using MusicaVirtual2020.Entidades;
using MusicaVirtual2020.Entidades.DTOs;
using MusicaVirtual2020.Entidades.DTOs.Album;
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
        private RepositorioInterpretes repositorioInterpretes;

        public RepositorioAlbumes(SqlConnection cn,RepositorioInterpretes repositorioInterpretes)
        {
            this.cn = cn;
            this.repositorioInterpretes = repositorioInterpretes;
        }

        public List<AlbumListDto> GetLista()
        {
            try
            {
                List<AlbumListDto> lista = new List<AlbumListDto>();
                var cadenaDeComando = "SELECT AlbumId,Album,InterpreteId,Pistas FROM Albumes";
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
                InterpreteListDto = repositorioInterpretes.GetInterpretesPorId(reader.GetInt32(2)),
                Pistas =reader.GetInt32(3)
            };
        }

        public void Agregar(AlbumEditDto albumEditDto)
        {
            Album album = Mapeador.ConvertirAlbum(albumEditDto);
            try
            {
                var cadenaDeComando = "INSERT INTO Albumes (Album,InterpreteId,EstiloId,SoporteId,Pistas,NegocioId,AñoComprado,Costo )" +
                    "VALUES (@album,@interpreteId,@estiloId,@soporteId,@pistas,@negocioId,@anioComprado,@costo)";
                var comando = new SqlCommand(cadenaDeComando,cn);
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
                comando = new SqlCommand(cadenaDeComando,cn);
                var id = (int)(decimal)comando.ExecuteScalar();
                album.AlbumId = id;
                albumEditDto.AlbumId = id;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
