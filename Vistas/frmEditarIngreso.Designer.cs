namespace Hemeroteca.Vistas
{
    partial class frmEditarIngreso
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
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label idLabel;
            this.ingresoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTipoIngreso = new System.Windows.Forms.ComboBox();
            this.cbRevista = new System.Windows.Forms.ComboBox();
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.lbCarga = new System.Windows.Forms.Label();
            this.btcargar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            cantidadLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ingresoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.BackColor = System.Drawing.Color.Transparent;
            cantidadLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cantidadLabel.ForeColor = System.Drawing.SystemColors.Control;
            cantidadLabel.Location = new System.Drawing.Point(35, 88);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(67, 19);
            cantidadLabel.TabIndex = 1;
            cantidadLabel.Text = "Cantidad:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.BackColor = System.Drawing.Color.Transparent;
            fechaLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaLabel.ForeColor = System.Drawing.SystemColors.Control;
            fechaLabel.Location = new System.Drawing.Point(35, 60);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(48, 19);
            fechaLabel.TabIndex = 3;
            fechaLabel.Text = "Fecha:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.BackColor = System.Drawing.Color.Transparent;
            idLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.ForeColor = System.Drawing.SystemColors.Control;
            idLabel.Location = new System.Drawing.Point(35, 31);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(24, 19);
            idLabel.TabIndex = 5;
            idLabel.Text = "Id:";
            // 
            // ingresoBindingSource
            // 
            this.ingresoBindingSource.DataSource = typeof(Hemeroteca.Entidades.Ingreso);
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ingresoBindingSource, "Cantidad", true));
            this.cantidadTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadTextBox.Location = new System.Drawing.Point(127, 88);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(336, 22);
            this.cantidadTextBox.TabIndex = 2;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ingresoBindingSource, "Fecha", true));
            this.fechaDateTimePicker.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(127, 59);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(336, 22);
            this.fechaDateTimePicker.TabIndex = 4;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ingresoBindingSource, "Id", true));
            this.idTextBox.Enabled = false;
            this.idTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(127, 31);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(336, 22);
            this.idTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(35, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tipo Ingreso:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(35, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Revista:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(35, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Proveedor:";
            // 
            // cbTipoIngreso
            // 
            this.cbTipoIngreso.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoIngreso.FormattingEnabled = true;
            this.cbTipoIngreso.Location = new System.Drawing.Point(127, 116);
            this.cbTipoIngreso.Name = "cbTipoIngreso";
            this.cbTipoIngreso.Size = new System.Drawing.Size(336, 24);
            this.cbTipoIngreso.TabIndex = 10;
            // 
            // cbRevista
            // 
            this.cbRevista.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRevista.FormattingEnabled = true;
            this.cbRevista.Location = new System.Drawing.Point(127, 146);
            this.cbRevista.Name = "cbRevista";
            this.cbRevista.Size = new System.Drawing.Size(336, 24);
            this.cbRevista.TabIndex = 11;
            // 
            // cbProveedor
            // 
            this.cbProveedor.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.Location = new System.Drawing.Point(127, 176);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(336, 24);
            this.cbProveedor.TabIndex = 12;
            // 
            // btAceptar
            // 
            this.btAceptar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAceptar.Location = new System.Drawing.Point(72, 281);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(118, 44);
            this.btAceptar.TabIndex = 13;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(299, 281);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(118, 44);
            this.btCancelar.TabIndex = 14;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // lbCarga
            // 
            this.lbCarga.AutoSize = true;
            this.lbCarga.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCarga.ForeColor = System.Drawing.SystemColors.Control;
            this.lbCarga.Location = new System.Drawing.Point(254, 212);
            this.lbCarga.Name = "lbCarga";
            this.lbCarga.Size = new System.Drawing.Size(73, 19);
            this.lbCarga.TabIndex = 27;
            this.lbCarga.Text = "Sin Cargar";
            // 
            // btcargar
            // 
            this.btcargar.Location = new System.Drawing.Point(216, 234);
            this.btcargar.Name = "btcargar";
            this.btcargar.Size = new System.Drawing.Size(149, 23);
            this.btcargar.TabIndex = 26;
            this.btcargar.Text = "Seleccionar";
            this.btcargar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(34, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 19);
            this.label4.TabIndex = 25;
            this.label4.Text = "Atributo de Ingreso:";
            // 
            // frmEditarIngreso
            // 
            this.AcceptButton = this.btAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.CancelButton = this.btCancelar;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.lbCarga);
            this.Controls.Add(this.btcargar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.cbProveedor);
            this.Controls.Add(this.cbRevista);
            this.Controls.Add(this.cbTipoIngreso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(cantidadLabel);
            this.Controls.Add(this.cantidadTextBox);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Name = "frmEditarIngreso";
            this.Text = "EditarIngreso";
            ((System.ComponentModel.ISupportInitialize)(this.ingresoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource ingresoBindingSource;
        private System.Windows.Forms.TextBox cantidadTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTipoIngreso;
        private System.Windows.Forms.ComboBox cbRevista;
        private System.Windows.Forms.ComboBox cbProveedor;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label lbCarga;
        private System.Windows.Forms.Button btcargar;
        private System.Windows.Forms.Label label4;
    }
}