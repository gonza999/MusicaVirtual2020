using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicaVirtual2020.Entidades.DTOs
{
    public class AlbumListDto
    {
        public int AlbumId { get; set; }

        public string Titulo { get; set; }

        public string Interprete { get; set; }

        public int Pistas { get; set; }
    }
}
