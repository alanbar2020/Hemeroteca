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
    public partial class frmEditarIngreso : Form
    {
        AtributosIngreso ai = new AtributosIngreso();
        public frmEditarIngreso(Ingreso i)
        {
            InitializeComponent();

            cbProveedor.DataSource = pProveedor.GetAll();
            cbProveedor.DisplayMember = "Nombre";
            cbProveedor.ValueMember = "Id";
            cbTipoIngreso.DataSource = pTipoIngreso.GetAll();
            cbTipoIngreso.DisplayMember = "Nombre";
            cbTipoIngreso.ValueMember = "Id";
            cbRevista.DataSource = pRevista.GetAll();
            cbRevista.DisplayMember = "Titulo";
            cbRevista.ValueMember = "Id";

            if (i == null)
                ingresoBindingSource.DataSource = new Ingreso();
            else
            {
                //cbPaises.SelectedValue = 0;
                ingresoBindingSource.DataSource = i;
            }
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {      
             Ingreso i = (Ingreso)ingresoBindingSource.DataSource;
            if (i.Id == 0)
                if (ai != null)
                {
                    pIngreso.Save(i, ai, (Revista)cbRevista.SelectedItem, (Proveedor)cbProveedor.SelectedItem);
                }
                else
                {
                    MessageBox.Show("Primero debe cargar un Atributo de Ingreso", "Error..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            else
                pIngreso.Update(i, ai, (Revista)cbRevista.SelectedItem, (Proveedor)cbProveedor.SelectedItem);
            Close();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btcargar_Click(object sender, EventArgs e)
        {
            carga();
        }

        private AtributosIngreso carga()
        {

            //ai = frmAtributosIngreso.Carga();
            if (ai == null)
            {
                lbCarga.Text = "Sin cargar";
            }
            else
            {
                lbCarga.Text = "Datos cargados";
                btcargar.Enabled = false;

            }
            return ai;

        }
    }
}
