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
    public partial class frmStock : Form
    {
        public frmStock()
        {
            InitializeComponent();
            stockBindingSource.DataSource = pStock.GetAll();
            
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            frmEditarStock vamp = new frmEditarStock(null);
            vamp.ShowDialog();
            stockBindingSource.DataSource = pStock.GetAll();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            frmEditarStock vamp = new frmEditarStock((Stock)stockBindingSource.Current);
            vamp.ShowDialog();
            stockBindingSource.DataSource = pStock.GetAll();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Eliminar registro de Stock", "¿Esta seguro de eliminar el registro?", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                pStock.Delete((Stock)stockBindingSource.Current);
                stockBindingSource.DataSource = pStock.GetAll();
            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            this.stockBindingSource.DataSource = pStock.Buscar(txNombre.Text);
        }
    }
}
