namespace Hemeroteca.Vistas
{
    partial class frmEditarStock
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
            System.Windows.Forms.Label cantidadExhibidaLabel;
            System.Windows.Forms.Label cantidadGuardadaLabel;
            this.btCancelar = new System.Windows.Forms.Button();
            this.btAceptar = new System.Windows.Forms.Button();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cantidadExhibidaTextBox = new System.Windows.Forms.TextBox();
            this.cantidadGuardadaTextBox = new System.Windows.Forms.TextBox();
            this.revistaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cbRevista = new System.Windows.Forms.ComboBox();
            cantidadExhibidaLabel = new System.Windows.Forms.Label();
            cantidadGuardadaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.revistaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cantidadExhibidaLabel
            // 
            cantidadExhibidaLabel.AutoSize = true;
            cantidadExhibidaLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cantidadExhibidaLabel.ForeColor = System.Drawing.SystemColors.Control;
            cantidadExhibidaLabel.Location = new System.Drawing.Point(84, 101);
            cantidadExhibidaLabel.Name = "cantidadExhibidaLabel";
            cantidadExhibidaLabel.Size = new System.Drawing.Size(122, 19);
            cantidadExhibidaLabel.TabIndex = 19;
            cantidadExhibidaLabel.Text = "Cantidad Exhibida:";
            // 
            // cantidadGuardadaLabel
            // 
            cantidadGuardadaLabel.AutoSize = true;
            cantidadGuardadaLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cantidadGuardadaLabel.ForeColor = System.Drawing.SystemColors.Control;
            cantidadGuardadaLabel.Location = new System.Drawing.Point(84, 127);
            cantidadGuardadaLabel.Name = "cantidadGuardadaLabel";
            cantidadGuardadaLabel.Size = new System.Drawing.Size(131, 19);
            cantidadGuardadaLabel.TabIndex = 21;
            cantidadGuardadaLabel.Text = "Cantidad Guardada:";
            // 
            // btCancelar
            // 
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(315, 296);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(118, 44);
            this.btCancelar.TabIndex = 18;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btAceptar
            // 
            this.btAceptar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAceptar.Location = new System.Drawing.Point(88, 296);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(118, 44);
            this.btAceptar.TabIndex = 17;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataSource = typeof(Hemeroteca.Entidades.Stock);
            // 
            // cantidadExhibidaTextBox
            // 
            this.cantidadExhibidaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockBindingSource, "CantidadExhibida", true));
            this.cantidadExhibidaTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadExhibidaTextBox.Location = new System.Drawing.Point(221, 101);
            this.cantidadExhibidaTextBox.Name = "cantidadExhibidaTextBox";
            this.cantidadExhibidaTextBox.Size = new System.Drawing.Size(168, 25);
            this.cantidadExhibidaTextBox.TabIndex = 20;
            // 
            // cantidadGuardadaTextBox
            // 
            this.cantidadGuardadaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockBindingSource, "CantidadGuardada", true));
            this.cantidadGuardadaTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadGuardadaTextBox.Location = new System.Drawing.Point(221, 130);
            this.cantidadGuardadaTextBox.Name = "cantidadGuardadaTextBox";
            this.cantidadGuardadaTextBox.Size = new System.Drawing.Size(168, 25);
            this.cantidadGuardadaTextBox.TabIndex = 22;
            // 
            // revistaBindingSource
            // 
            this.revistaBindingSource.DataSource = typeof(Hemeroteca.Entidades.Revista);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(87, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "Revista:";
            // 
            // cbRevista
            // 
            this.cbRevista.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRevista.FormattingEnabled = true;
            this.cbRevista.Location = new System.Drawing.Point(221, 159);
            this.cbRevista.Name = "cbRevista";
            this.cbRevista.Size = new System.Drawing.Size(168, 27);
            this.cbRevista.TabIndex = 24;
            // 
            // frmEditarStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.ClientSize = new System.Drawing.Size(484, 436);
            this.Controls.Add(this.cbRevista);
            this.Controls.Add(this.label1);
            this.Controls.Add(cantidadExhibidaLabel);
            this.Controls.Add(this.cantidadExhibidaTextBox);
            this.Controls.Add(cantidadGuardadaLabel);
            this.Controls.Add(this.cantidadGuardadaTextBox);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Name = "frmEditarStock";
            this.Text = "frmEditarStock";
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.revistaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private System.Windows.Forms.TextBox cantidadExhibidaTextBox;
        private System.Windows.Forms.TextBox cantidadGuardadaTextBox;
        private System.Windows.Forms.BindingSource revistaBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbRevista;
    }
}