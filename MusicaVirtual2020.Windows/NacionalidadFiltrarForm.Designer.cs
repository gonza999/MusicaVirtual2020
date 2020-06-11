namespace MusicaVirtual2020.Windows
{
    partial class NacionalidadFiltrarForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboNacionalidad = new System.Windows.Forms.ComboBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nacionalidad : ";
            // 
            // comboNacionalidad
            // 
            this.comboNacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNacionalidad.FormattingEnabled = true;
            this.comboNacionalidad.Location = new System.Drawing.Point(128, 84);
            this.comboNacionalidad.Name = "comboNacionalidad";
            this.comboNacionalidad.Size = new System.Drawing.Size(256, 21);
            this.comboNacionalidad.TabIndex = 1;
            // 
            // CancelButton
            // 
            this.CancelButton.Image = global::MusicaVirtual2020.Windows.Properties.Resources.Cancelar;
            this.CancelButton.Location = new System.Drawing.Point(300, 160);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(94, 53);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancelar";
            this.CancelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Image = global::MusicaVirtual2020.Windows.Properties.Resources.Aceptar;
            this.OkButton.Location = new System.Drawing.Point(59, 160);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(94, 53);
            this.OkButton.TabIndex = 4;
            this.OkButton.Text = "OK";
            this.OkButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 41);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccionar Nacionalidad";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // NacionalidadFiltrarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 278);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.comboNacionalidad);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(458, 278);
            this.MinimumSize = new System.Drawing.Size(458, 278);
            this.Name = "NacionalidadFiltrarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NacionalidadFiltrarForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboNacionalidad;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}