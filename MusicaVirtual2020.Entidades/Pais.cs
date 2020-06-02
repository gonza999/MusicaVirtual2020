﻿using System;

namespace MusicaVirtual2020.Entidades
{
    public class Pais:ICloneable
    {
        public int PaisId { get; set; }
        public string Nombre { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
