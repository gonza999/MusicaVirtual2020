using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicaVirtual2020.Entidades;

namespace MusicaVirtual2020.Reportes
{
    public class ManejadorDeReportes
    {
        public PaisesReporte GetPaisesReporte(List<Pais> lista)
        {
            PaisesReporte rpt=new PaisesReporte();
            ManejadorDatosPaises manejadorDatos=new ManejadorDatosPaises();
         
            var ds = manejadorDatos.PonerDatosDePaises(lista);
            rpt.SetDataSource(ds);
            return rpt;
        }
        public InterpretesFiltrado GetInterpretesFiltrado(List<Interprete> lista)
        {
            InterpretesFiltrado rpt = new InterpretesFiltrado();
            ManejadorDatosInterpretes manejadorDatos = new ManejadorDatosInterpretes();
            var ds = manejadorDatos.PonerDatosDeInterpretes(lista);
            rpt.SetDataSource(ds);
            return rpt;
        }
        public InterpretesReporte GetInterpretesReporte(List<Interprete> lista)
        {
            InterpretesReporte rpt = new InterpretesReporte();
            ManejadorDatosInterpretes manejadorDatos = new ManejadorDatosInterpretes();
            var ds = manejadorDatos.PonerDatosDeInterpretes(lista);
            rpt.SetDataSource(ds);
            return rpt;
        }

        public InterpretesAgrupadoXNacionalidad GetReporteInterpretesAgrupados(List<Interprete> lista)
        {
            InterpretesAgrupadoXNacionalidad rpt = new InterpretesAgrupadoXNacionalidad();
            ManejadorDatosInterpretes manejadorDatos = new ManejadorDatosInterpretes();
            var ds = manejadorDatos.PonerDatosDeInterpretes(lista);
            rpt.SetDataSource(ds);
            return rpt;
        }
    }
}
