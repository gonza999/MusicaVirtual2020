using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicaVirtual2020.Entidades
{
    public class Soporte : ICloneable
    {
        public int SoporteId { get; set; }
        public string Nombre { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
