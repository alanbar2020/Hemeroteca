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
    public partial class frmEditarFacultad : Form
    {
        public frmEditarFacultad(Facultad s)
        {
            InitializeComponent();
            if (s == null)
                facultadBindingSource.DataSource = new Facultad();
            else
            {
                //cbPaises.SelectedValue = 0;
                facultadBindingSource.DataSource = s;
            }

        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            Facultad i = (Facultad)facultadBindingSource.DataSource;
            if (i.Id == 0)
            {
                pFacultad.Save(i);

            }
            else
                pFacultad.Update(i);
            Close();

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
