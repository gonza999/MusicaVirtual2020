using System;
using System.Windows.Forms;
using MusicaVirtual2020.Entidades;
using MusicaVirtual2020.Servicios;

namespace MusicaVirtual2020.Windows
{
    public partial class InterpretesAEForm : Form
    {
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ServicioNacionalidad servicioNacionalidad=new ServicioNacionalidad();
            var listaNacionalidad = servicioNacionalidad.GetLista();
            var defaultNacionalidad = new Nacionalidad
            {
                NacionalidadId = 0,
                Nombre = "<Seleccione Nacionalidad>"
            };
            listaNacionalidad.Insert(0,defaultNacionalidad);
            NacionalidadComboBox.DataSource = listaNacionalidad;
            NacionalidadComboBox.DisplayMember = "Nombre";
            NacionalidadComboBox.ValueMember = "NacionalidadId";
            NacionalidadComboBox.SelectedIndex = 0;

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
    }
}
