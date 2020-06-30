using System;

namespace MusicaVirtual2020.Entidades
{
    public class Interprete:ICloneable
    {
        public int InterpreteId { get; set; }
        public string Nombre { get; set; }
        public Nacionalidad Nacionalidad { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
