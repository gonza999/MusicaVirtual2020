using MusicaVirtual2020.Entidades;
using MusicaVirtual2020.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicaVirtual2020.Windows.Helpers
{
    public class Helper
    {
        public static void CargarDatosComboPais(ref ComboBox comboPais)
        {
            ServicioPais servicio = new ServicioPais();
            var lista = servicio.GetLista();
            Pais paisDefault = new Pais();
            paisDefault.PaisId = 0;
            paisDefault.Nombre = "<Seleccionar Pais>";
            lista.Insert(0, paisDefault);
            comboPais.DataSource = lista;
            comboPais.DisplayMember = "Nombre";
            comboPais.ValueMember = "PaisId";
            comboPais.SelectedIndex = 0;
        }

        public static void CargarDatosComboInterpretes(ref ComboBox comboInterprete)
        {
            ServicioInterprete servicio = new ServicioInterprete();
            var lista = servicio.GetInterpretes();
            Interprete interpreteDefault = new Interprete();
            interpreteDefault.InterpreteId = 0;
            interpreteDefault.Nombre = "<Seleccionar Interprete>";
            lista.Insert(0, interpreteDefault);
            comboInterprete.DataSource = lista;
            comboInterprete.DisplayMember = "Nombre";
            comboInterprete.ValueMember = "InterpreteId";
            comboInterprete.SelectedIndex = 0;
        }

        public static void CargarDatosComboEstilo(ref ComboBox comboEstilo)
        {
            ServicioEstilo servicio = new ServicioEstilo();
            var lista = servicio.GetLista();
            Estilo estiloDefault = new Estilo();
            estiloDefault.EstiloId = 0;
            estiloDefault.Nombre = "<Seleccionar Estilo>";
            lista.Insert(0, estiloDefault);
            comboEstilo.DataSource = lista;
            comboEstilo.DisplayMember = "Nombre";
            comboEstilo.ValueMember = "EstiloId";
            comboEstilo.SelectedIndex = 0;
        }
        public static void CargarDatosComboSoporte(ref ComboBox comboSoporte)
        {
            ServicioSoporte servicio = new ServicioSoporte();
            var lista = servicio.GetLista();
            Soporte soporteDefault = new Soporte();
            soporteDefault.SoporteId = 0;
            soporteDefault.Nombre = "<Seleccionar Soporte>";
            lista.Insert(0, soporteDefault);
            comboSoporte.DataSource = lista;
            comboSoporte.DisplayMember = "Nombre";
            comboSoporte.ValueMember = "SoporteId";
            comboSoporte.SelectedIndex = 0;
        }
        public static void CargarDatosComboNegocio(ref ComboBox comboNegocio)
        {
            ServicioNegocio servicio = new ServicioNegocio();
            var lista = servicio.GetNegocios();
            Negocio negocioDefault = new Negocio();
            negocioDefault.NegocioId = 0;
            negocioDefault.Nombre = "<Seleccionar Negocio>";
            lista.Insert(0, negocioDefault);
            comboNegocio.DataSource = lista;
            comboNegocio.DisplayMember = "Nombre";
            comboNegocio.ValueMember = "NegocioId";
            comboNegocio.SelectedIndex = 0;
        }
        public static void CargarDatosComboNacionalidad(ref ComboBox NacionalidadComboBox)
        {
            ServicioNacionalidad servicioNacionalidad = new ServicioNacionalidad();
            var listaNacionalidad = servicioNacionalidad.GetLista();
            var defaultNacionalidad = new Nacionalidad
            {
                NacionalidadId = 0,
                Nombre = "<Seleccione Nacionalidad>"
            };
            listaNacionalidad.Insert(0, defaultNacionalidad);
            NacionalidadComboBox.DataSource = listaNacionalidad;
            NacionalidadComboBox.DisplayMember = "Nombre";
            NacionalidadComboBox.ValueMember = "NacionalidadId";
            NacionalidadComboBox.SelectedIndex = 0;
        }

        public static void MensajeBox(string mensaje, Tipo tipo)
        {
            switch (tipo)
            {
                case Tipo.Success:
                    MessageBox.Show(mensaje,"Operación Exitosa",MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    break;
                case Tipo.Error:
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    break;

                default:
                    break;
            }
        }
        public static void MensajeBox(string mensaje)
        {
            MessageBox.Show(mensaje, "Confirmar Operación", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
        }
    }
}
