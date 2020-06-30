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
    public partial class NegociosAEForm : Form
    {
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Helper.CargarDatosComboPais(ref PaisComboBox);

            if (negocio != null)
            {
                negocioTextBox.Text = negocio.Nombre;
                PaisComboBox.SelectedValue = negocio.Pais.PaisId;
            }
        }

        public NegociosAEForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (negocio == null)
                {
                    negocio = new Negocio();
                }

                negocio.Nombre = negocioTextBox.Text;
                negocio.Pais = (Pais)PaisComboBox.SelectedItem;

                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(negocioTextBox.Text) && string.IsNullOrWhiteSpace(negocioTextBox.Text))
            {
                valido = false;
                errorProvider1.SetError(negocioTextBox, "El nombre del negocio es requerido");
            }

            if (PaisComboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(PaisComboBox, "Debe seleccionar una pais");

            }

            return valido;
        }
        private Negocio negocio;
        internal Negocio GetNegocio()
        {
            return negocio;
        }

        internal void SetNegocio(Negocio negocio)
        {
            this.negocio = negocio;
        }
    }
}
