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
    public partial class frmEditarTipoIngreso : Form
    {
        AtributosIngreso ai = new AtributosIngreso();
        public frmEditarTipoIngreso(TipoIngreso tp)
        {
            InitializeComponent();
            if (tp == null)
                tipoIngresoBindingSource.DataSource = new Ingreso();
            else
            {
                //cbPaises.SelectedValue = 0;
                tipoIngresoBindingSource.DataSource = tp;
            }
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            TipoIngreso i = (TipoIngreso)tipoIngresoBindingSource.DataSource;
            if (i.Id == 0)
            {
                    pTipoIngreso.Save(i);
              
            }
            else
                pTipoIngreso.Update(i);
            Close();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
