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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            loginBindingSource.DataSource = pLogin.GetAll();
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            frmEditarLogin vamp = new frmEditarLogin(null);
            vamp.ShowDialog();
            loginBindingSource.DataSource = pLogin.GetAll();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            frmEditarLogin vamp = new frmEditarLogin((Login)loginBindingSource.Current);
            vamp.ShowDialog();
            loginBindingSource.DataSource = pStock.GetAll();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Eliminar este Usuario", "¿Esta seguro de eliminar el registro?", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                pLogin.Delete((Login)loginBindingSource.Current);
                loginBindingSource.DataSource = pStock.GetAll();
            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            this.loginBindingSource.DataSource = pLogin.Buscar(txNombre.Text);
        }
    }
}
