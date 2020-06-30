using MusicaVirtual2020.Entidades.DTOs;
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
    public partial class AlbumesForm : Form
    {
        private static AlbumesForm instancia = null;

        public static AlbumesForm GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new AlbumesForm();
                instancia.FormClosed += form_Close;
            }

            return instancia;
        }

        private static void form_Close(object sender, FormClosedEventArgs e)
        {
            instancia = null;
        }
        private AlbumesForm()
        {
            InitializeComponent();
        }
        private ServicioAlbum servicio;
        private List<AlbumListDto> lista;
        private void AlbumesForm_Load(object sender, EventArgs e)
        {
            try
            {
                servicio = new ServicioAlbum();
                lista = servicio.GetLista();
                MostrarDatosEnGrilla();
            }
            catch (Exception exception)
            {
                Helper.MensajeBox(exception.Message,Tipo.Error);
            }
        }

        private void MostrarDatosEnGrilla()
        {
            DatosDataGridView.Rows.Clear();
            foreach (var album in lista)
            {
                DataGridViewRow r=ConstruirFila();
                SetearFila(r,album);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            DatosDataGridView.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, AlbumListDto album)
        {
            r.Cells[cmnAlbum.Index].Value = album.Titulo;
            r.Cells[cmnInterprete.Index].Value = album.InterpreteListDto.Nombre;
            r.Cells[cmnPistas.Index].Value = album.Pistas;
            r.Tag = album;
        }

        private DataGridViewRow ConstruirFila()
        {
            var r = new DataGridViewRow();
            r.CreateCells(DatosDataGridView);
            return r;
        }

        private void CerrarToolStripButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
