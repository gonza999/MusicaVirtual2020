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
    public partial class MenuPrincipalForm : Form
    {
        public MenuPrincipalForm()
        {
            InitializeComponent();
        }
        #region ToolStripMenuItem_Click
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void PaisesToolStripButton_Click(object sender, EventArgs e)
        {
            ManejarPaises();
        }
        private void paisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManejarPaises();
        }
        private void EstilosToolStripButton_Click(object sender, EventArgs e)
        {
            ManejarEstilos(); 
        }
        private void estilosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManejarEstilos();
        }
        private void InterpretesToolStripButton_Click(object sender, EventArgs e)
        {
            ManejarInterpretes();        
        }   
        private void intérpretesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManejarInterpretes();
        }
        private void soporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManejarSoportes();
        }
        private void SoportesToolStripButton_Click(object sender, EventArgs e)
        {
            ManejarSoportes();       
        }
        private void NegociosToolStripButton_Click(object sender, EventArgs e)
        {
            ManejarNegocios();         
        }
        private void negociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManejarNegocios();
        }
        private void AlbumesToolStripButton_Click(object sender, EventArgs e)
        {
            ManejarAlbumes();
        }   
        private void albumesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManejarAlbumes();
        }
#endregion


        #region Manejadores
        private void ManejarAlbumes()
        {
            AlbumesForm frm = AlbumesForm.GetInstancia();

            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Dock = DockStyle.Fill;


            frm.Show();
        }

        private void ManejarNegocios()
        {
            NegociosForm frm = NegociosForm.GetInstancia();

            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Dock = DockStyle.Fill;


            frm.Show();
        }
        private void ManejarSoportes()
        {
            SoportesForm frm = SoportesForm.GetInstancia();

            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Dock = DockStyle.Fill;


            frm.Show();
        }
        private void ManejarInterpretes()
        {
            InterpretesForm frm = InterpretesForm.GetInstancia();

            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Dock = DockStyle.Fill;


            frm.Show();
        }

        private void ManejarEstilos()
        {
            EstilosForm frm = EstilosForm.GetInstancia();

            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Dock = DockStyle.Fill;


            frm.Show();
        }

        private void ManejarPaises()
        {
            var frm = PaisesForm.GetInstancia();

            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Dock = DockStyle.Fill;

            frm.Show();
        }


        #endregion

        private void cantidadXInterpretesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlbumesPorInterpretes frm = new AlbumesPorInterpretes();
            frm.Text = "Cantidad de Albumes por Interpretes";
            frm.ShowDialog(this);
        }
    }
}
