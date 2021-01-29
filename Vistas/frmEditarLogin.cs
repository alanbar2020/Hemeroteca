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
    public partial class frmEditarLogin : Form
    {
        public frmEditarLogin(Login s)
        {
            InitializeComponent();
            if (s == null)
                loginBindingSource.DataSource = new Login();
            else
            {
                //cbPaises.SelectedValue = 0;
                loginBindingSource.DataSource = s;
            }
        }

        private void frmEditarLogin_Load(object sender, EventArgs e)
        {

        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            Login i = (Login)loginBindingSource.DataSource;
            if (i.Id == 0)
            {
                pLogin.Save(i);

            }
            else
                pLogin.Update(i);
            Close();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
