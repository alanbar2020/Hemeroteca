using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hemeroteca.Controladores;
using Hemeroteca.Entidades;
using System.Data.SQLite;

namespace Hemeroteca.Vistas
{
    public partial class frmIngreso : Form
    {
        public frmIngreso()
        {
            InitializeComponent();
            ingresoBindingSource.DataSource = pIngreso.GetAll();
        }


        private void Ingreso_Load(object sender, EventArgs e)
        {

        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            frmEditarIngreso vamp = new frmEditarIngreso(null);
            vamp.ShowDialog();
            ingresoBindingSource.DataSource = pIngreso.GetAll();

        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            frmEditarIngreso vamp = new frmEditarIngreso((Ingreso)ingresoBindingSource.Current);
            vamp.ShowDialog();
            ingresoBindingSource.DataSource = pIngreso.GetAll();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Eliminar Ingreso", "¿Esta seguro de eliminar el registro?", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                pIngreso.Delete((Ingreso)ingresoBindingSource.Current);
                ingresoBindingSource.DataSource = pIngreso.GetAll();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            this.ingresoBindingSource.DataSource = pIngreso.Buscar(Convert.ToString(cbFecha.Value));
        }
    }
}
