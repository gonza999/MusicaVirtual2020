using MusicaVirtual2020.Entidades.DTOs;
using MusicaVirtual2020.Entidades.DTOs.Album;
using MusicaVirtual2020.Entidades.DTOs.Estilo;
using MusicaVirtual2020.Entidades.DTOs.Negocio;
using MusicaVirtual2020.Entidades.DTOs.Soporte;
using MusicaVirtual2020.Entidades.DTOs.Tema;
using MusicaVirtual2020.Entidades.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicaVirtual2020.Entidades.Mapas
{
    public class Mapeador
    {

        public static EstiloListDto ConvertirEstiloListDto(Estilo estilo)
        {
            return new EstiloListDto
            {
                EstiloId = estilo.EstiloId,
                Nombre = estilo.Nombre
            };
        }

        public static NegocioListDto ConvertirNegocioListDto(Negocio negocio)
        {
            return new NegocioListDto
            {
                NegocioId = negocio.NegocioId,
                Nombre = negocio.Nombre
            };
        }

        public static SoporteListDto ConveritirSoporteListDto(Soporte soporte)
        {
            return new SoporteListDto
            {
                SoporteId = soporte.SoporteId,
                Nombre = soporte.Nombre
            };
        }

        public static Album ConvertirAlbum(AlbumEditDto albumEditDto, int interpreteId)
        {
            Album album = new Album
            {
                AlbumId = albumEditDto.AlbumId,
                Costo = albumEditDto.Costo,
                AñoComprado = albumEditDto.AñoComprado,
                Pistas = albumEditDto.Pistas,
                Titulo = albumEditDto.Titulo,
                Interprete = new Interprete() {
                    Nombre = albumEditDto.Interprete,
                    InterpreteId = interpreteId
                },
                Estilo = ConvertirEstilo(albumEditDto.EstiloListDto),
                Negocio = ConvertirNegocio(albumEditDto.NegocioListDto),
                Soporte = ConvertirSoporte(albumEditDto.SoporteListDto),

            };
            if (albumEditDto.Temas.Count > 0)
            {
                albumEditDto.Temas.ForEach(tema =>
                {
                    album.Temas.Add(tema);
                });
            }
            return album;
        }

        //public static Tema ConvertirTema(TemaListDto temaListDto)
        //{
        //    return new Tema
        //    {
        //        TemaId = temaListDto.TemaId,
        //        PistaNumero = temaListDto.NroTema,
        //        Nombre = temaListDto.Nombre,
        //        Duracion = temaListDto.Duracion
        //    };
        //}


        private static Soporte ConvertirSoporte(SoporteListDto soporteListDto)
        {
            return new Soporte
            {
                SoporteId = soporteListDto.SoporteId,
                Nombre = soporteListDto.Nombre
            };
        }

        private static Negocio ConvertirNegocio(NegocioListDto negocioListDto)
        {
            return new Negocio
            {
                NegocioId = negocioListDto.NegocioId,
                Nombre = negocioListDto.Nombre
            };
        }

        private static Estilo ConvertirEstilo(EstiloListDto estiloListDto)
        {
            return new Estilo
            {
                EstiloId = estiloListDto.EstiloId,
                Nombre = estiloListDto.Nombre
            };
        }

        public static AlbumListDto ConvertirAlbumListDto(AlbumEditDto albumEditDto)
        {
            return new AlbumListDto
            {
                AlbumId = albumEditDto.AlbumId,
                Interprete = albumEditDto.Interprete,
                Pistas = albumEditDto.Pistas,
                Titulo=albumEditDto.Titulo
            };
        }
    }
}
