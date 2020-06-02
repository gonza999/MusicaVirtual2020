﻿using System;
using System.Collections.Generic;
using MusicaVirtual2020.Datos;
using MusicaVirtual2020.Entidades;

namespace MusicaVirtual2020.Servicios
{
    public class ServicioInterprete
    {
        private ConexionBd cn;
        private RepositorioInterpretes repositorio;
        private RepositorioNacionalidades repositorioNacionalidad;

        public ServicioInterprete()
        {
            
        }

        public void Borrar(Interprete interprete)
        {
            try
            {
                cn=new ConexionBd();
                repositorio=new RepositorioInterpretes(cn.AbrirConexion());
                repositorio.Borrar(interprete);
                cn.CerrarConexion();
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
                cn=new ConexionBd();
                repositorio=new RepositorioInterpretes(cn.AbrirConexion());
                var existe = repositorio.Existe(interprete);
                cn.CerrarConexion();
                return existe;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        public void Agregar(Interprete interprete)
        {
            try
            {
                cn=new ConexionBd();
                repositorio=new RepositorioInterpretes(cn.AbrirConexion());
                repositorio.Agregar(interprete);
                cn.CerrarConexion();

            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
        }
        public List<Interprete> GetInterpretes()
        {
            try
            {
                cn=new ConexionBd();
                repositorioNacionalidad=new RepositorioNacionalidades(cn.AbrirConexion());
                repositorio=new RepositorioInterpretes(cn.AbrirConexion(), repositorioNacionalidad);
                var lista = repositorio.GetInterpretes();
                cn.CerrarConexion();
                return lista;
            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
        }

        public bool EstaRelaciona(Interprete interprete)
        {
            try
            {
                cn=new ConexionBd();
                repositorio=new RepositorioInterpretes(cn.AbrirConexion());
                var relacionado = repositorio.EstaRelacionado(interprete);
                cn.CerrarConexion();
                return relacionado;
            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
        }
    }
}
