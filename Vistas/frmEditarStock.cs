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
    public partial class frmEditarStock : Form
    {
        public frmEditarStock(Stock s)
        {
            InitializeComponent();
            cbRevista.DataSource = pRevista.GetAll();
            cbRevista.DisplayMember = "Titulo";
            cbRevista.ValueMember = "Id";


            if (s == null)
                stockBindingSource.DataSource = new Stock();
            else
            {
                //cbPaises.SelectedValue = 0;
                stockBindingSource.DataSource = s;
            }
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            Stock i = (Stock)stockBindingSource.DataSource;
            if (i.Id == 0)
            {
                pStock.Save(i,(Revista)cbRevista.SelectedItem);

            }
            else
                pStock.Update(i, (Revista)cbRevista.SelectedItem);
            Close();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
