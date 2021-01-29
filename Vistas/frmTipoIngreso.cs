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
    public partial class frmTipoIngreso : Form
    {
        public frmTipoIngreso()
        {
            InitializeComponent();
            tipoIngresoBindingSource.DataSource = pTipoIngreso.GetAll();
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            frmEditarTipoIngreso vamp = new frmEditarTipoIngreso(null);
            vamp.ShowDialog();
            tipoIngresoBindingSource.DataSource = pTipoIngreso.GetAll();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            frmEditarTipoIngreso vamp = new frmEditarTipoIngreso((TipoIngreso)tipoIngresoBindingSource.Current);
            vamp.ShowDialog();
            tipoIngresoBindingSource.DataSource = pTipoIngreso.GetAll();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Eliminar Tipo de Ingreso", "¿Esta seguro de eliminar el registro?", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                pTipoIngreso.Delete((TipoIngreso)tipoIngresoBindingSource.Current);
                tipoIngresoBindingSource.DataSource = pIngreso.GetAll();
            }
        }

        private void txNombre_TextChanged(object sender, EventArgs e)
        {
            this.tipoIngresoBindingSource.DataSource = pTipoIngreso.Buscar(txNombre.Text);
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            this.tipoIngresoBindingSource.DataSource = pTipoIngreso.Buscar(txNombre.Text);
        }
    }
}
