using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicaVirtual2020.Entidades;

namespace MusicaVirtual2020.Reportes
{
    public class ManejadorDatosPaises
    {

        public MusicaVirtualDataSet PonerDatosDePaises(List<Pais> lista)
        {
            MusicaVirtualDataSet ds=new MusicaVirtualDataSet();

            foreach (var pais in lista)
            {
                ds.Tables["PaisesDataTable"].Rows.Add(pais.Nombre);

            }

            return ds;
        }
    }
}
