using MusicaVirtual2020.Entidades.DTOs.Estilo;
using MusicaVirtual2020.Entidades.DTOs.Negocio;
using MusicaVirtual2020.Entidades.DTOs.Soporte;
using MusicaVirtual2020.Entidades.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicaVirtual2020.Entidades.DTOs.Album
{
    public class AlbumEditDto
    {
        public int AlbumId { get; set; }

        public string Titulo { get; set; }

        public string Interprete { get; set; }

        public EstiloListDto EstiloListDto { get; set; }

        public SoporteListDto SoporteListDto { get; set; }

        public int Pistas { get; set; }

        public NegocioListDto NegocioListDto { get; set; }

        public int AñoComprado { get; set; }

        public decimal Costo { get; set; }

        public List<MusicaVirtual2020.Entidades.Entities.Tema> Temas { get; set; } = new List<MusicaVirtual2020.Entidades.Entities.Tema>();
    }
}
