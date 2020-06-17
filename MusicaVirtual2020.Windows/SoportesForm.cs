﻿using MusicaVirtual2020.Entidades;
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
    public partial class SoportesForm : Form
    {
        private static SoportesForm instancia = null;
        private SoportesForm()
        {
            InitializeComponent();
        }

        public static SoportesForm GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new SoportesForm();
                instancia.FormClosed += form_Close;
            }

            return instancia;
        }

        private static void form_Close(object sender, FormClosedEventArgs e)
        {
            instancia = null;
        }

        private void CerrarToolStripButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private ServicioSoporte servicio;
        private List<Soporte> lista;

        private void SoportesForm_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            try
            {
                servicio = new ServicioSoporte();
                lista = servicio.GetLista();
                MostrarDatosEnGrilla();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarDatosEnGrilla()
        {
            DatosDataGridView.Rows.Clear();
            foreach (var soporte in lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, soporte);
                AgregarFila(r);

            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            DatosDataGridView.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Soporte soporte)
        {
            r.Cells[cmnSoporte.Index].Value = soporte.Nombre;

            r.Tag = soporte;
        }

        private DataGridViewRow ConstruirFila()
        {
            var r = new DataGridViewRow();
            r.CreateCells(DatosDataGridView);
            return r;
        }

        private void NuevoToolStripButton_Click(object sender, EventArgs e)
        {
            SoportesAEForm frm = new SoportesAEForm();
            frm.Text = "Agregar Soporte";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                try
                {
                    Soporte soporte = frm.GetSoporte();
                    if (!servicio.Existe(soporte))
                    {
                        servicio.Agregar(soporte);
                        var r = ConstruirFila();
                        SetearFila(r, soporte);
                        AgregarFila(r);
                        MessageBox.Show("Registro agregado", "Mensaje",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Registro Duplicado... Alta denegada", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                catch (Exception exception)
                {

                    MessageBox.Show(exception.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void BorrarToolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count > 0)
            {
                var r = DatosDataGridView.SelectedRows[0];
                Soporte soporte = (Soporte)r.Tag;
                DialogResult dr = MessageBox.Show($"¿Desea borrar de la lista a {soporte.Nombre}?",
                    "Confirmar Baja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {

                        if (!servicio.EstaRelacionado(soporte))
                        {
                            servicio.Borrar(soporte);
                            DatosDataGridView.Rows.Remove(r);
                            MessageBox.Show("Registro Borrado", "Mensaje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Registro relacionado...\nBaja denegada",
                                "Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                        }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                    }
                }
            }
        }

        private void EditarToolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count > 0)
            {
                var r = DatosDataGridView.SelectedRows[0];
                Soporte s = (Soporte)r.Tag;
                Soporte sCopia = (Soporte)s.Clone();
                SoportesAEForm frm = new SoportesAEForm();
                frm.Text = "Editar Soporte";
                frm.SetSoporte(s);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        s = frm.GetSoporte();
                        if (!servicio.Existe(s))
                        {
                            servicio.Editar(s);
                            SetearFila(r, s);
                            MessageBox.Show("Registro editado", "Mensaje", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Registro duplicado...\nEdición denegada", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            SetearFila(r, sCopia);
                        }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //private void ImprimirToolStripButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        lista = servicio.GetLista();
        //        var manejadorReportes = new ManejadorDeReportes();

        //        SoportesReporte rpt = manejadorReportes.GetSoportesReporte(lista);
        //        ReportesForm frm = new ReportesForm();
        //        frm.SetReporte(rpt);
        //        frm.ShowDialog(this);
        //    }
        //    catch (Exception exception)
        //    {
        //        Console.WriteLine(exception);
        //        throw;
        //    }
        //}
    }
}

