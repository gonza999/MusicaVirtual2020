using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicaVirtual2020.Entidades
{
    public class Negocio : ICloneable
    {
        public int NegocioId { get; set; }
        public string Nombre { get; set; }
        public Pais Pais { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
