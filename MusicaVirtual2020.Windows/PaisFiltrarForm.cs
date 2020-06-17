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
    public partial class PaisFiltrarForm : Form
    {
        public PaisFiltrarForm()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            ServicioPais servicio = new ServicioPais();
            var lista = servicio.GetLista();
            var paisDefault = new Pais();
            paisDefault.PaisId = 0;
            paisDefault.Nombre = "<Seleccionar Pais>";
            lista.Insert(0, paisDefault);
            comboPais.DataSource = lista;
            comboPais.DisplayMember = "Nombre";
            comboPais.ValueMember = "PaisId";
            comboPais.SelectedIndex = 0;

        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private Pais pais;
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                pais = (Pais)comboPais.SelectedItem;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (comboPais.SelectedIndex == 0)
            {
                errorProvider1.SetError(comboPais, "Debe seleccionar una pais");
                valido = false;
            }
            return valido;
        }

        internal Pais GetPais()
        {
            return pais;
        }
    }
}
