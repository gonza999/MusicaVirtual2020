namespace MusicaVirtual2020.Windows
{
    partial class AlbumAEForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.comboInterprete = new System.Windows.Forms.ComboBox();
            this.comboEstilo = new System.Windows.Forms.ComboBox();
            this.comboSoporte = new System.Windows.Forms.ComboBox();
            this.btnAgregarInterprete = new System.Windows.Forms.Button();
            this.btnAgregarEstilo = new System.Windows.Forms.Button();
            this.btnAgregarSoporte = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAgregaTemas = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboNegocio = new System.Windows.Forms.ComboBox();
            this.btnAgregaNegocio = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAnioComprado = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.dgvDatosTemas = new System.Windows.Forms.DataGridView();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.pistasNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmnNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnTema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnDuracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cmnBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosTemas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pistasNumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 31);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Album";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titulo :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Interprete :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Estilo :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 130);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Soporte :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(373, 72);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Pistas :";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(100, 43);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(333, 22);
            this.txtTitulo.TabIndex = 0;
            // 
            // comboInterprete
            // 
            this.comboInterprete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboInterprete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboInterprete.FormattingEnabled = true;
            this.comboInterprete.Location = new System.Drawing.Point(100, 72);
            this.comboInterprete.Margin = new System.Windows.Forms.Padding(2);
            this.comboInterprete.Name = "comboInterprete";
            this.comboInterprete.Size = new System.Drawing.Size(191, 24);
            this.comboInterprete.TabIndex = 1;
            // 
            // comboEstilo
            // 
            this.comboEstilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEstilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEstilo.FormattingEnabled = true;
            this.comboEstilo.Location = new System.Drawing.Point(100, 102);
            this.comboEstilo.Margin = new System.Windows.Forms.Padding(2);
            this.comboEstilo.Name = "comboEstilo";
            this.comboEstilo.Size = new System.Drawing.Size(191, 24);
            this.comboEstilo.TabIndex = 2;
            // 
            // comboSoporte
            // 
            this.comboSoporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSoporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSoporte.FormattingEnabled = true;
            this.comboSoporte.Location = new System.Drawing.Point(100, 130);
            this.comboSoporte.Margin = new System.Windows.Forms.Padding(2);
            this.comboSoporte.Name = "comboSoporte";
            this.comboSoporte.Size = new System.Drawing.Size(191, 24);
            this.comboSoporte.TabIndex = 3;
            // 
            // btnAgregarInterprete
            // 
            this.btnAgregarInterprete.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarInterprete.Image = global::MusicaVirtual2020.Windows.Properties.Resources.AgregarAE;
            this.btnAgregarInterprete.Location = new System.Drawing.Point(306, 74);
            this.btnAgregarInterprete.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarInterprete.Name = "btnAgregarInterprete";
            this.btnAgregarInterprete.Size = new System.Drawing.Size(32, 26);
            this.btnAgregarInterprete.TabIndex = 7;
            this.btnAgregarInterprete.UseVisualStyleBackColor = false;
            // 
            // btnAgregarEstilo
            // 
            this.btnAgregarEstilo.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarEstilo.Image = global::MusicaVirtual2020.Windows.Properties.Resources.AgregarAE;
            this.btnAgregarEstilo.Location = new System.Drawing.Point(306, 103);
            this.btnAgregarEstilo.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarEstilo.Name = "btnAgregarEstilo";
            this.btnAgregarEstilo.Size = new System.Drawing.Size(33, 24);
            this.btnAgregarEstilo.TabIndex = 7;
            this.btnAgregarEstilo.UseVisualStyleBackColor = false;
            // 
            // btnAgregarSoporte
            // 
            this.btnAgregarSoporte.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarSoporte.Image = global::MusicaVirtual2020.Windows.Properties.Resources.AgregarAE;
            this.btnAgregarSoporte.Location = new System.Drawing.Point(306, 131);
            this.btnAgregarSoporte.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarSoporte.Name = "btnAgregarSoporte";
            this.btnAgregarSoporte.Size = new System.Drawing.Size(33, 24);
            this.btnAgregarSoporte.TabIndex = 7;
            this.btnAgregarSoporte.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.btnAgregaTemas);
            this.panel2.Location = new System.Drawing.Point(-128, 178);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(993, 321);
            this.panel2.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(159, 20);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "Temas";
            // 
            // btnAgregaTemas
            // 
            this.btnAgregaTemas.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregaTemas.Enabled = false;
            this.btnAgregaTemas.Image = global::MusicaVirtual2020.Windows.Properties.Resources.AgregarAE;
            this.btnAgregaTemas.Location = new System.Drawing.Point(767, 12);
            this.btnAgregaTemas.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregaTemas.Name = "btnAgregaTemas";
            this.btnAgregaTemas.Size = new System.Drawing.Size(35, 37);
            this.btnAgregaTemas.TabIndex = 0;
            this.btnAgregaTemas.UseVisualStyleBackColor = false;
            this.btnAgregaTemas.Click += new System.EventHandler(this.btnAgregaTemas_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(360, 98);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Negocio :";
            // 
            // comboNegocio
            // 
            this.comboNegocio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNegocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboNegocio.FormattingEnabled = true;
            this.comboNegocio.Location = new System.Drawing.Point(439, 98);
            this.comboNegocio.Margin = new System.Windows.Forms.Padding(2);
            this.comboNegocio.Name = "comboNegocio";
            this.comboNegocio.Size = new System.Drawing.Size(191, 24);
            this.comboNegocio.TabIndex = 5;
            // 
            // btnAgregaNegocio
            // 
            this.btnAgregaNegocio.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregaNegocio.Image = global::MusicaVirtual2020.Windows.Properties.Resources.AgregarAE;
            this.btnAgregaNegocio.Location = new System.Drawing.Point(646, 90);
            this.btnAgregaNegocio.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregaNegocio.Name = "btnAgregaNegocio";
            this.btnAgregaNegocio.Size = new System.Drawing.Size(32, 39);
            this.btnAgregaNegocio.TabIndex = 7;
            this.btnAgregaNegocio.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(405, 126);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Año Comprado  :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(474, 150);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Costo :";
            // 
            // txtAnioComprado
            // 
            this.txtAnioComprado.Location = new System.Drawing.Point(537, 126);
            this.txtAnioComprado.Margin = new System.Windows.Forms.Padding(2);
            this.txtAnioComprado.Name = "txtAnioComprado";
            this.txtAnioComprado.Size = new System.Drawing.Size(68, 22);
            this.txtAnioComprado.TabIndex = 6;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(537, 150);
            this.txtCosto.Margin = new System.Windows.Forms.Padding(2);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(68, 22);
            this.txtCosto.TabIndex = 7;
            this.txtCosto.Text = "0";
            // 
            // dgvDatosTemas
            // 
            this.dgvDatosTemas.AllowUserToAddRows = false;
            this.dgvDatosTemas.AllowUserToDeleteRows = false;
            this.dgvDatosTemas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosTemas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmnNro,
            this.cmnTema,
            this.cmnDuracion,
            this.CmnEditar,
            this.cmnBorrar});
            this.dgvDatosTemas.Location = new System.Drawing.Point(0, 237);
            this.dgvDatosTemas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDatosTemas.MultiSelect = false;
            this.dgvDatosTemas.Name = "dgvDatosTemas";
            this.dgvDatosTemas.ReadOnly = true;
            this.dgvDatosTemas.RowHeadersVisible = false;
            this.dgvDatosTemas.Size = new System.Drawing.Size(685, 217);
            this.dgvDatosTemas.TabIndex = 10;
            // 
            // CancelButton
            // 
            this.CancelButton.Image = global::MusicaVirtual2020.Windows.Properties.Resources.Cancelar;
            this.CancelButton.Location = new System.Drawing.Point(447, 458);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(105, 33);
            this.CancelButton.TabIndex = 9;
            this.CancelButton.Text = "Cancelar";
            this.CancelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Image = global::MusicaVirtual2020.Windows.Properties.Resources.Aceptar;
            this.OkButton.Location = new System.Drawing.Point(184, 458);
            this.OkButton.Margin = new System.Windows.Forms.Padding(2);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(107, 33);
            this.OkButton.TabIndex = 8;
            this.OkButton.Text = "OK";
            this.OkButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // pistasNumericUpDown1
            // 
            this.pistasNumericUpDown1.Location = new System.Drawing.Point(439, 70);
            this.pistasNumericUpDown1.Name = "pistasNumericUpDown1";
            this.pistasNumericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.pistasNumericUpDown1.TabIndex = 4;
            this.pistasNumericUpDown1.ValueChanged += new System.EventHandler(this.pistasNumericUpDown1_ValueChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cmnNro
            // 
            this.cmnNro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnNro.HeaderText = "Nro";
            this.cmnNro.Name = "cmnNro";
            this.cmnNro.ReadOnly = true;
            // 
            // cmnTema
            // 
            this.cmnTema.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnTema.HeaderText = "Tema";
            this.cmnTema.Name = "cmnTema";
            this.cmnTema.ReadOnly = true;
            // 
            // cmnDuracion
            // 
            this.cmnDuracion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnDuracion.HeaderText = "Duración";
            this.cmnDuracion.Name = "cmnDuracion";
            this.cmnDuracion.ReadOnly = true;
            // 
            // CmnEditar
            // 
            this.CmnEditar.HeaderText = "";
            this.CmnEditar.Name = "CmnEditar";
            this.CmnEditar.ReadOnly = true;
            // 
            // cmnBorrar
            // 
            this.cmnBorrar.HeaderText = "";
            this.cmnBorrar.Name = "cmnBorrar";
            this.cmnBorrar.ReadOnly = true;
            // 
            // AlbumAEForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 499);
            this.ControlBox = false;
            this.Controls.Add(this.pistasNumericUpDown1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.dgvDatosTemas);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.txtAnioComprado);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnAgregaNegocio);
            this.Controls.Add(this.btnAgregarSoporte);
            this.Controls.Add(this.btnAgregarEstilo);
            this.Controls.Add(this.comboNegocio);
            this.Controls.Add(this.btnAgregarInterprete);
            this.Controls.Add(this.comboSoporte);
            this.Controls.Add(this.comboEstilo);
            this.Controls.Add(this.comboInterprete);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AlbumAEForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlbumAEForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosTemas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pistasNumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.ComboBox comboInterprete;
        private System.Windows.Forms.ComboBox comboEstilo;
        private System.Windows.Forms.ComboBox comboSoporte;
        private System.Windows.Forms.Button btnAgregarInterprete;
        private System.Windows.Forms.Button btnAgregarEstilo;
        private System.Windows.Forms.Button btnAgregarSoporte;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAgregaTemas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboNegocio;
        private System.Windows.Forms.Button btnAgregaNegocio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAnioComprado;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.DataGridView dgvDatosTemas;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.NumericUpDown pistasNumericUpDown1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnTema;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnDuracion;
        private System.Windows.Forms.DataGridViewButtonColumn CmnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn cmnBorrar;
    }
}