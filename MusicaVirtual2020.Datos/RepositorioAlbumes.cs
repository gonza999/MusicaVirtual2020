using MusicaVirtual2020.Entidades.DTOs;
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
    }
}
