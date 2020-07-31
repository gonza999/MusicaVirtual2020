namespace MusicaVirtual2020.Windows
{
    partial class AlbumesPorInterpretes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.datosDataGridView = new System.Windows.Forms.DataGridView();
            this.cmnInterprete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CerrarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.datosDataGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.CerrarButton);
            this.splitContainer1.Size = new System.Drawing.Size(579, 437);
            this.splitContainer1.SplitterDistance = 379;
            this.splitContainer1.TabIndex = 0;
            // 
            // datosDataGridView
            // 
            this.datosDataGridView.AllowUserToAddRows = false;
            this.datosDataGridView.AllowUserToDeleteRows = false;
            this.datosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmnInterprete,
            this.cmnCantidad});
            this.datosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datosDataGridView.Location = new System.Drawing.Point(0, 0);
            this.datosDataGridView.MultiSelect = false;
            this.datosDataGridView.Name = "datosDataGridView";
            this.datosDataGridView.ReadOnly = true;
            this.datosDataGridView.RowHeadersVisible = false;
            this.datosDataGridView.Size = new System.Drawing.Size(579, 379);
            this.datosDataGridView.TabIndex = 0;
            // 
            // cmnInterprete
            // 
            this.cmnInterprete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnInterprete.HeaderText = "Interprete";
            this.cmnInterprete.Name = "cmnInterprete";
            this.cmnInterprete.ReadOnly = true;
            // 
            // cmnCantidad
            // 
            this.cmnCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnCantidad.HeaderText = "Cantidad";
            this.cmnCantidad.Name = "cmnCantidad";
            this.cmnCantidad.ReadOnly = true;
            // 
            // CerrarButton
            // 
            this.CerrarButton.Image = global::MusicaVirtual2020.Windows.Properties.Resources.Cancelar;
            this.CerrarButton.Location = new System.Drawing.Point(485, 5);
            this.CerrarButton.Margin = new System.Windows.Forms.Padding(2);
            this.CerrarButton.Name = "CerrarButton";
            this.CerrarButton.Size = new System.Drawing.Size(83, 43);
            this.CerrarButton.TabIndex = 11;
            this.CerrarButton.Text = "Cerrar";
            this.CerrarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CerrarButton.UseVisualStyleBackColor = true;
            this.CerrarButton.Click += new System.EventHandler(this.CerrarButton_Click);
            // 
            // AlbumesPorInterpretes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 437);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Name = "AlbumesPorInterpretes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlbumesPorInterpretes";
            this.Load += new System.EventHandler(this.AlbumesPorInterpretes_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datosDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView datosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnInterprete;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnCantidad;
        private System.Windows.Forms.Button CerrarButton;
    }
}