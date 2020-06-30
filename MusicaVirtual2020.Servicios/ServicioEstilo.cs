﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicaVirtual2020.Datos;
using MusicaVirtual2020.Entidades;

namespace MusicaVirtual2020.Servicios
{
    public class ServicioEstilo
    {
        private ConexionBd conexion;
        private RepositorioEstilos repositorio;

        public ServicioEstilo()
        {
        }

        public void Agregar(Estilo estilo)
        {
            try
            {
                conexion=new ConexionBd();
                repositorio=new RepositorioEstilos(conexion.AbrirConexion());
                repositorio.Agregar(estilo);
                
                conexion.CerrarConexion();
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
                conexion=new ConexionBd();
                repositorio=new RepositorioEstilos(conexion.AbrirConexion());
                var lista=repositorio.GetLista();
                
                conexion.CerrarConexion();
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
                conexion = new ConexionBd();
                repositorio = new RepositorioEstilos(conexion.AbrirConexion());
                bool existe = repositorio.Existe(estilo);
                conexion.CerrarConexion();
                return existe;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
