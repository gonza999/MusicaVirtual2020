using MusicaVirtual2020.Entidades;
using MusicaVirtual2020.Entidades.DTOs.Interprete;
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
    public partial class AlbumesPorInterpretes : Form
    {
        public AlbumesPorInterpretes()
        {
            InitializeComponent();
        }

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private List<InterpretesAlbumesDto> lista;
        private ServicioAlbum servicio;
        private void AlbumesPorInterpretes_Load(object sender, EventArgs e)
        {
            try
            {
                servicio = new ServicioAlbum();
                lista = servicio.GetCantidadXInterprete();
                MostrarDatosEnGrilla();
            }
            catch (Exception ex)
            {
                Helper.MensajeBox(ex.Message,Tipo.Error);
            }
        }

        private void MostrarDatosEnGrilla()
        {
            datosDataGridView.Rows.Clear();
            foreach (var interpretesAlbumesDto in lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, interpretesAlbumesDto);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            datosDataGridView.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, InterpretesAlbumesDto interpretesAlbumesDto)
        {
            r.Cells[cmnInterprete.Index].Value = interpretesAlbumesDto.Interprete;
            r.Cells[cmnCantidad.Index].Value = interpretesAlbumesDto.Cantidad;
            r.Tag = interpretesAlbumesDto;
        }

        private DataGridViewRow ConstruirFila()
        {
            var r = new DataGridViewRow();
            r.CreateCells(datosDataGridView);
            return r;
        }
    }
}
