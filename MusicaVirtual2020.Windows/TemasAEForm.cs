using MusicaVirtual2020.Entidades.DTOs.Tema;
using MusicaVirtual2020.Entidades.Entities;
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
    public partial class TemasAEForm : Form
    {
        public TemasAEForm()
        {
            InitializeComponent();
        }
        private Tema tema;
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (tema==null)
                {
                    tema = new Tema();
                }
                tema.Nombre = txtTema.Text;
                tema.Duracion =float.Parse(txtDuracion.Text);
                DialogResult = DialogResult.OK;
            }
        }
        public Tema GetTema()
        {
            return tema;
        }
        private bool ValidarDatos()
        {
            errorProvider1.Clear();
            bool valido = true;
            if (string.IsNullOrEmpty(txtTema.Text) &&
                string.IsNullOrWhiteSpace(txtTema.Text))
            {
                errorProvider1.SetError(txtTema,"Debe ingresar un tema");
                valido = false;
            }
            if (string.IsNullOrEmpty(txtDuracion.Text) &&
               string.IsNullOrWhiteSpace(txtDuracion.Text))
            {
                errorProvider1.SetError(txtDuracion, "Debe ingresar la duracion");
                valido = false;
            }

            return valido;
        }
    }
}
