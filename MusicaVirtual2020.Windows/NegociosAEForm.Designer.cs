namespace MusicaVirtual2020.Windows
{
    partial class NegociosAEForm
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
            this.PaisComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.negocioTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AgregarNacionalidadButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // PaisComboBox
            // 
            this.PaisComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaisComboBox.FormattingEnabled = true;
            this.PaisComboBox.Location = new System.Drawing.Point(106, 81);
            this.PaisComboBox.Name = "PaisComboBox";
            this.PaisComboBox.Size = new System.Drawing.Size(332, 21);
            this.PaisComboBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Pais :";
            // 
            // negocioTextBox
            // 
            this.negocioTextBox.Location = new System.Drawing.Point(106, 28);
            this.negocioTextBox.MaxLength = 50;
            this.negocioTextBox.Name = "negocioTextBox";
            this.negocioTextBox.Size = new System.Drawing.Size(421, 20);
            this.negocioTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Negocio : ";
            // 
            // AgregarNacionalidadButton
            // 
            this.AgregarNacionalidadButton.BackColor = System.Drawing.Color.Transparent;
            this.AgregarNacionalidadButton.Image = global::MusicaVirtual2020.Windows.Properties.Resources.AgregarAE;
            this.AgregarNacionalidadButton.Location = new System.Drawing.Point(457, 74);
            this.AgregarNacionalidadButton.Name = "AgregarNacionalidadButton";
            this.AgregarNacionalidadButton.Size = new System.Drawing.Size(34, 32);
            this.AgregarNacionalidadButton.TabIndex = 13;
            this.AgregarNacionalidadButton.UseVisualStyleBackColor = false;
            // 
            // CancelButton
            // 
            this.CancelButton.Image = global::MusicaVirtual2020.Windows.Properties.Resources.Cancelar;
            this.CancelButton.Location = new System.Drawing.Point(433, 156);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(94, 53);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Cancelar";
            this.CancelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Image = global::MusicaVirtual2020.Windows.Properties.Resources.Aceptar;
            this.OkButton.Location = new System.Drawing.Point(48, 156);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(94, 53);
            this.OkButton.TabIndex = 12;
            this.OkButton.Text = "OK";
            this.OkButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // NegociosAEForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 271);
            this.ControlBox = false;
            this.Controls.Add(this.AgregarNacionalidadButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.PaisComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.negocioTextBox);
            this.Controls.Add(this.label1);
            this.Name = "NegociosAEForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NegociosAEForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AgregarNacionalidadButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.ComboBox PaisComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox negocioTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}