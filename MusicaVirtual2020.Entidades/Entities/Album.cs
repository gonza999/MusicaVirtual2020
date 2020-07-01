using MusicaVirtual2020.Entidades.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicaVirtual2020.Entidades
{
    public class Album
    {
        public int AlbumId { get; set; }

        public string Titulo { get; set; }

        public Interprete Interprete { get; set; }

        public Estilo Estilo { get; set; }

        public Soporte Soporte { get; set; }

        public int Pistas { get; set; }

        public Negocio Negocio { get; set; }

        public int AñoComprado { get; set; }

        public decimal Costo { get; set; }

        public List<Tema> Temas { get; set; } = new List<Tema>();
    }
}
