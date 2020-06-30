using MusicaVirtual2020.Datos;
using MusicaVirtual2020.Entidades.DTOs;
using System;
using System.Collections.Generic;
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

        public ServicioAlbum()
        {
                
        }

        public List<AlbumListDto> GetLista()
        {
            try
            {
                cn = new ConexionBd();
                repositorioInterpretes = new RepositorioInterpretes(cn.AbrirConexion());
                repositorio = new RepositorioAlbumes(cn.AbrirConexion(),repositorioInterpretes);
                var lista = repositorio.GetLista();
                cn.CerrarConexion();
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}
