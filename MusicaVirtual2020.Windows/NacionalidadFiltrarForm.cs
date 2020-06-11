using MusicaVirtual2020.Entidades;
using MusicaVirtual2020.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicaVirtual2020.Windows
{
    public partial class NacionalidadFiltrarForm : Form
    {
        public NacionalidadFiltrarForm()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            ServicioNacionalidad servicio = new ServicioNacionalidad();
            var lista = servicio.GetLista();
            var nacionalidadDefault = new Nacionalidad();
            nacionalidadDefault.NacionalidadId = 0;
            nacionalidadDefault.Nombre = "<Seleccionar Nacionalidad>";
            lista.Insert(0, nacionalidadDefault);
            comboNacionalidad.DataSource = lista;
            comboNacionalidad.DisplayMember = "Nombre";
            comboNacionalidad.ValueMember = "NacionalidadId";
            comboNacionalidad.SelectedIndex = 0;

        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private Nacionalidad nacionalidad;
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                nacionalidad =(Nacionalidad) comboNacionalidad.SelectedItem;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (comboNacionalidad.SelectedIndex==0)
            {
                errorProvider1.SetError(comboNacionalidad,"Debe seleccionar una nacionalidad");
                valido = false;
            }
            return valido;
        }

        internal Nacionalidad GetNacionalidad()
        {
            return nacionalidad;
        }
    }
}
