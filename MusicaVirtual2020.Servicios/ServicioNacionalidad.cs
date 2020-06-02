using MusicaVirtual2020.Datos;
using MusicaVirtual2020.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicaVirtual2020.Servicios
{
    public class ServicioNacionalidad
    {
        private ConexionBd _conexion;
        private RepositorioNacionalidades _repositorio;

        public ServicioNacionalidad()
        {

        }

        public List<Nacionalidad> GetLista()
        {
            try
            {
                _conexion = new ConexionBd();
                _repositorio = new RepositorioNacionalidades(_conexion.AbrirConexion());
                var lista = _repositorio.GetLista();
                _conexion.CerrarConexion();
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void Agregar(Nacionalidad nacionalidad)
        {
            try
            {
                _conexion = new ConexionBd();
                _repositorio = new RepositorioNacionalidades(_conexion.AbrirConexion());
                _repositorio.Agregar(nacionalidad);
                _conexion.CerrarConexion();

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
                _conexion = new ConexionBd();
                _repositorio = new RepositorioNacionalidades(_conexion.AbrirConexion());
                var existe = _repositorio.Existe(nacionalidad);
                _conexion.CerrarConexion();
                return existe;
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
                _conexion = new ConexionBd();
                _repositorio = new RepositorioNacionalidades(_conexion.AbrirConexion());
                var estaRelacionado = _repositorio.EstaRelacionado(nacionalidad);
                _conexion.CerrarConexion();
                return estaRelacionado;
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
                _conexion = new ConexionBd();
                _repositorio = new RepositorioNacionalidades(_conexion.AbrirConexion());
                _repositorio.Borrar(nacionalidad);
                _conexion.CerrarConexion();

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
                _conexion = new ConexionBd();
                _repositorio = new RepositorioNacionalidades(_conexion.AbrirConexion());
                _repositorio.Editar(nacionalidad);
                _conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
