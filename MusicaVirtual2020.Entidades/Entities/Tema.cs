using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicaVirtual2020.Entidades.Entities
{
    public class Tema
    {
        public int TemaId { get; set; }
        public int PistaNumero { get; set; }
        public string Nombre { get; set; }

        public float Duracion { get; set; }

        public Album Album { get; set; }
    }
}
