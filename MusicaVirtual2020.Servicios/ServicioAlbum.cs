using MusicaVirtual2020.Datos;
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

namespace MusicaVirtual2020.Servicios
{
    public class ServicioAlbum
    {
        private ConexionBd cn;
        private RepositorioAlbumes repositorio;
        private RepositorioInterpretes repositorioInterpretes;
        private RepositorioTemas repositorioTemas;
        public ServicioAlbum()
        {

        }

        public List<AlbumListDto> GetLista()
        {
            try
            {
                cn = new ConexionBd();
                repositorioInterpretes = new RepositorioInterpretes(cn.AbrirConexion());
                repositorio = new RepositorioAlbumes(cn.AbrirConexion(), repositorioInterpretes);
                var lista = repositorio.GetLista();
                cn.CerrarConexion();
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Agregar(AlbumEditDto albumEditDto)
        {
            SqlTransaction transac = null;
            try
            {
                cn = new ConexionBd();
                SqlConnection conexion = cn.AbrirConexion();
                repositorio = new RepositorioAlbumes(conexion, repositorioInterpretes);
                repositorioTemas = new RepositorioTemas(conexion);
                using (transac = conexion.BeginTransaction())
                {
                    Album album = Mapeador.ConvertirAlbum(albumEditDto);
                    repositorio.Agregar(album, transac);
                    albumEditDto.AlbumId = album.AlbumId;
                    if (album.Temas.Count > 0)
                    {
                        album.Temas.ForEach(t =>
                        {
                            t.Album = album;
                            repositorioTemas.Agregar(t,transac);
                        } );
                    }
                    transac.Commit();
                }
                cn.CerrarConexion();

            }
            catch (Exception e)
            {
                transac.Rollback();
                throw new Exception(e.Message);
            }
        }
    }
}
