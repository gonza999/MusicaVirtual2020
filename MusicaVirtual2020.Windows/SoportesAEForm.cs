﻿using MusicaVirtual2020.Entidades;
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
    public partial class SoportesAEForm : Form
    {
        public SoportesAEForm()
        {
            InitializeComponent();
        }

        internal Soporte GetSoporte()
        {
            return soporte;
        }
        internal void SetSoporte(Soporte soporte)
        {
            this.soporte = soporte;
        }

        private Soporte soporte;
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (soporte != null)
            {
                SoporteTextBox.Text = soporte.Nombre;
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (soporte == null)
                {
                    soporte = new Soporte();
                }

                soporte.Nombre = SoporteTextBox.Text.Trim();
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            if (string.IsNullOrEmpty(SoporteTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(SoporteTextBox, "Debe ingresar un soporte");
            }

            return valido;
        }

    }
}
