using MusicaVirtual2020.Entidades;
using MusicaVirtual2020.Entidades.DTOs.Album;
using MusicaVirtual2020.Entidades.DTOs.Tema;
using MusicaVirtual2020.Entidades.Entities;
using MusicaVirtual2020.Entidades.Mapas;
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
    public partial class AlbumAEForm : Form
    {
        public AlbumAEForm()
        {
            InitializeComponent();
        }
        private AlbumEditDto albumDto;
        private List<Tema> temas = new List<Tema>();

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Helper.CargarDatosComboInterpretes(ref comboInterprete);
            Helper.CargarDatosComboEstilo(ref comboEstilo);
            Helper.CargarDatosComboNegocio(ref comboNegocio);
            Helper.CargarDatosComboSoporte(ref comboSoporte);


        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        int interpreteId = 0;
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (albumDto == null)
                {
                    albumDto = new AlbumEditDto();
                }
                albumDto.Titulo = txtTitulo.Text;
                albumDto.Interprete = ((Interprete)comboInterprete.SelectedItem).Nombre;
                interpreteId = ((Interprete)comboInterprete.SelectedItem).InterpreteId;
                albumDto.EstiloListDto = Mapeador.ConvertirEstiloListDto((Estilo)comboEstilo.SelectedItem);
                albumDto.NegocioListDto = Mapeador.ConvertirNegocioListDto((Negocio) comboNegocio.SelectedItem);
                albumDto.SoporteListDto = Mapeador.ConveritirSoporteListDto((Soporte)comboSoporte.SelectedItem);
                albumDto.Pistas =(int)pistasNumericUpDown1.Value;
                albumDto.AñoComprado =int.Parse( txtAnioComprado.Text);
                albumDto.Costo = decimal.Parse(txtCosto.Text);

                albumDto.Temas = temas;

                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtTitulo.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(txtTitulo, "Debe ingresar un titulo");
            }
            if (comboInterprete.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(comboInterprete, "Debe seleccionar un interprete");
            }
            if (comboEstilo.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(comboEstilo, "Debe seleccionar un estilo");
            }
            if (comboNegocio.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(comboNegocio, "Debe seleccionar un negocio");
            }
            if (comboSoporte.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(comboSoporte, "Debe seleccionar un soporte");
            }
            if (!int.TryParse(txtAnioComprado.Text, out int anio))
            {
                valido = false;
                errorProvider1.SetError(txtAnioComprado, "Año mal ingresado");
            }
            else if (anio < 1970 || anio > DateTime.Now.Year)
            {
                valido = false;
                errorProvider1.SetError(txtAnioComprado, "Año fuera del rango permitido");
            }
            if (!decimal.TryParse(txtCosto.Text, out decimal costo))
            {
                valido = false;
                errorProvider1.SetError(txtAnioComprado, "Costo mal ingresado");
            }
            else if (costo < 0 || costo > decimal.MaxValue - 1)
            {
                valido = false;
                errorProvider1.SetError(txtAnioComprado, "Costo fuera del rango permitido");
            }
            return valido;
        }

        internal int GetInterpreteId()
        {
            return interpreteId;
        }

        internal AlbumEditDto GetAlbum()
        {
            return albumDto;
        }
        private void btnAgregaTemas_Click(object sender, EventArgs e)
        {
            TemasAEForm frm = new TemasAEForm();
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.OK)
            {
                try
                {
                    Tema tema = frm.GetTema();

                    if (!temas.Contains(tema))
                    {
                        tema.PistaNumero = temas.Count() + 1;
                        temas.Add(tema);
                        DataGridViewRow r = ConstruirFila();
                        SetearFila(r, tema);
                        AgregarFila(r);
                        if (pistasNumericUpDown1.Value == temas.Count())
                        {
                            btnAgregaTemas.Enabled = false;
                        }
                        else
                        {
                            btnAgregaTemas.Enabled = true;
                        }
                    }
                    else
                    {
                        Helper.MensajeBox("Tema repetido",Tipo.Error);
                    }
                }
                catch (Exception ex)
                {
                    Helper.MensajeBox(ex.Message,Tipo.Error);
                }
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvDatosTemas.Rows.Add(r) ;
        }

        private void SetearFila(DataGridViewRow r, Tema tema)
        {
            r.Cells[cmnNro.Index].Value = tema.PistaNumero;
            r.Cells[cmnTema.Index].Value = tema.Nombre;
            r.Cells[cmnDuracion.Index].Value = tema.Duracion;
            r.Tag = tema;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dgvDatosTemas);
            return r;
        }

        private void pistasNumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (pistasNumericUpDown1.Value>0)
            {
                btnAgregaTemas.Enabled = true;
            }
            else
            {
                btnAgregaTemas.Enabled = false;
            }
        }
    }
}
