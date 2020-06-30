using MusicaVirtual2020.Entidades;
using MusicaVirtual2020.Servicios;
using MusicaVirtual2020.Windows.Helpers;
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

            Helper.CargarDatosComboNacionalidad(ref comboNacionalidad);

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
