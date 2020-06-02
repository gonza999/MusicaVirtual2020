using MusicaVirtual2020.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicaVirtual2020.Reportes
{
    public class ManejadorDatosInterpretes
    {
        public MusicaVirtualDataSet PonerDatosDeInterpretes(List<Interprete> lista)
        {
            MusicaVirtualDataSet ds = new MusicaVirtualDataSet();
            foreach (var interprete in lista)
            {
                ds.Tables["InterpretesDataTable"].Rows.Add(interprete.Nombre,
                    interprete.Nacionalidad.Nombre);
            }
            return ds;
        }
    }
}
