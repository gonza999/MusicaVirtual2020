using System;
using System.Windows.Forms;
using MusicaVirtual2020.Entidades;
using MusicaVirtual2020.Servicios;
using MusicaVirtual2020.Windows.Helpers;

namespace MusicaVirtual2020.Windows
{
    public partial class InterpretesAEForm : Form
    {
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Helper.CargarDatosComboNacionalidad(ref NacionalidadComboBox);

            if (interprete!=null)
            {
                interpreteTextBox.Text = interprete.Nombre;
                NacionalidadComboBox.SelectedValue = interprete.Nacionalidad.NacionalidadId;
            }
        }

        private Interprete interprete;
        public InterpretesAEForm()
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
                if (interprete==null)
                {
                    interprete=new Interprete();
                }

                interprete.Nombre = interpreteTextBox.Text;
                interprete.Nacionalidad =(Nacionalidad) NacionalidadComboBox.SelectedItem;

                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(interpreteTextBox.Text) && string.IsNullOrWhiteSpace(interpreteTextBox.Text))
            {
                valido = false;
                errorProvider1.SetError(interpreteTextBox,"El nombre del intérprete es requerido");
            }

            if (NacionalidadComboBox.SelectedIndex==0)
            {
                valido = false;
                errorProvider1.SetError(NacionalidadComboBox, "Debe seleccionar una nacionalidad");

            }

            return valido;
        }

        public Interprete GetInterprete()
        {
            return interprete;
        }

        public void SetInterprete(Interprete interprete)
        {
            this.interprete = interprete;
        }

        private void AgregarNacionalidadButton_Click(object sender, EventArgs e)
        {

        }
    }
}
