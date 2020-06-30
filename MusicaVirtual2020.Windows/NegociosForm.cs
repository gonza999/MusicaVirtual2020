using MusicaVirtual2020.Entidades;
using MusicaVirtual2020.Reportes;
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
    public partial class NegociosForm : Form
    {
        private static NegociosForm instancia = null;

        public static NegociosForm GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new NegociosForm();
                instancia.FormClosed += form_Close;
            }

            return instancia;
        }

        private static void form_Close(object sender, FormClosedEventArgs e)
        {
            instancia = null;
        }

        private NegociosForm()
        {
            InitializeComponent();
        }

        private List<Negocio> lista;
        private ServicioNegocio servicio;
        private void NegociosForm_Load(object sender, EventArgs e)
        {
            try
            {
                servicio = new ServicioNegocio();
                lista = servicio.GetNegocios();
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
            foreach (var negocio in lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, negocio);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            DatosDataGridView.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Negocio negocio)
        {
            r.Cells[cmnNegocio.Index].Value = negocio.Nombre;
            r.Cells[cmnPais.Index].Value = negocio.Pais.Nombre;


            r.Tag = negocio;
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

        private void NuevoToolStripButton_Click(object sender, EventArgs e)
        {
            NegociosAEForm frm = new NegociosAEForm();
            frm.Text = "Nuevo Negocio";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                try
                {
                    Negocio negocio = frm.GetNegocio();

                    if (!servicio.Existe(negocio))
                    {
                        servicio.Agregar(negocio);
                        DataGridViewRow r = ConstruirFila();
                        SetearFila(r, negocio);
                        AgregarFila(r);
                        Helper.MensajeBox("Registro agregado",Tipo.Success);
                    }
                    else
                    {
                        Helper.MensajeBox("Registro Duplicado \nAlta Denegada", Tipo.Error);
                    }

                }
                catch (Exception exception)
                {
                    Helper.MensajeBox(exception.Message, Tipo.Error);
                }
            }
        }

        private void BorrarToolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow r = DatosDataGridView.SelectedRows[0];
                Negocio negocio = (Negocio)r.Tag;
                DialogResult dr = MessageBox.Show($"¿Desea dar de baja al intérprete {negocio.Nombre}?",
                    "Confirmar Baja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        if (!servicio.EstaRelaciona(negocio))
                        {
                            servicio.Borrar(negocio);
                            DatosDataGridView.Rows.Remove(r);
                            Helper.MensajeBox("Registro Borrado", Tipo.Success);
                        }
                        else
                        {
                            Helper.MensajeBox("Negocio con Álbumes \nBaja Denegada", Tipo.Error);
                        }
                    }
                    catch (Exception exception)
                    {
                        Helper.MensajeBox(exception.Message, Tipo.Error);
                    }
                }

            }
        }

        private void EditarToolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow r = DatosDataGridView.SelectedRows[0];
                Negocio negocio = (Negocio)r.Tag;
                Negocio negocioAux = (Negocio)negocio.Clone();
                NegociosAEForm frm = new NegociosAEForm();
                frm.Text = "Editar Negocio";
                frm.SetNegocio(negocio);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        negocio = frm.GetNegocio();

                        if (!servicio.Existe(negocio))
                        {
                            servicio.Agregar(negocio);
                            SetearFila(r, negocio);
                            Helper.MensajeBox("Registro agregado",Tipo.Success);
                        }
                        else
                        {
                            SetearFila(r, negocioAux);
                            Helper.MensajeBox("Registro Duplicado \nAlta Denegada", Tipo.Error);
                        }

                    }
                    catch (Exception exception)
                    {
                        Helper.MensajeBox(exception.Message, Tipo.Error);
                    }
                }

            }

        }

        //private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    lista = servicio.GetNegocios();
        //    ManejadorDeReportes manejadorDeReportes = new ManejadorDeReportes();
        //    var rpt = manejadorDeReportes.GetNegociosReporte(lista);
        //    ReportesForm frm = new ReportesForm();
        //    frm.Text = "Reporte Negocio";
        //    frm.SetReporte(rpt);
        //    frm.ShowDialog(this);
        //}

        //private void agrupadoXPaisToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    lista = servicio.GetNegocios();
        //    ManejadorDeReportes manejadorDeReportes = new ManejadorDeReportes();
        //    NegociosAgrupadoXPais rpt = manejadorDeReportes.GetReporteNegociosAgrupados(lista);
        //    ReportesForm frm = new ReportesForm();
        //    frm.Text = "Reporte Negocio agrupado por Pais";
        //    frm.SetReporte(rpt);
        //    frm.ShowDialog(this);
        //}

        //private void filtradoXPaisToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    PaisFiltrarForm frm = new PaisFiltrarForm();
        //    DialogResult dr = frm.ShowDialog(this);
        //    if (dr == DialogResult.OK)
        //    {
        //        try
        //        {
        //            var nacionalidad = frm.GetPais();
        //            var listafiltrada = servicio.GetNegocios(nacionalidad);
        //            ManejadorDeReportes manejadorDeReportes = new ManejadorDeReportes();
        //            NegociosFiltrado rpt = manejadorDeReportes.GetNegociosFiltrado(listafiltrada);
        //            ReportesForm frmReporte = new ReportesForm();
        //            frmReporte.SetReporte(rpt);
        //            frmReporte.ShowDialog(this);
        //        }
        //        catch (Exception exception)
        //        {
        //            Helper.MensajeBox(exception.Message, Tipo.Error);
        //        }
        //    }
        //}

        private void BuscarToolStripButton_Click(object sender, EventArgs e)
        {
            PaisFiltrarForm frm = new PaisFiltrarForm();
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                try
                {
                    var nacionalidad = frm.GetPais();
                    lista = servicio.GetNegocios(nacionalidad);
                    MostrarDatosEnGrilla();
                }
                catch (Exception exception)
                {
                    Helper.MensajeBox(exception.Message, Tipo.Error);
                }
            }
        }

        private void ActualizarToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                lista = servicio.GetNegocios();
                MostrarDatosEnGrilla();
            }
            catch (Exception exception)
            {
                Helper.MensajeBox(exception.Message, Tipo.Error);
            }
        }
    }
}
