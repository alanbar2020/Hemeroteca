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
    public partial class frmFacultad : Form
    {
        int s = 2;
        public frmFacultad()
        {
            InitializeComponent();
            //facultadBindingSource.DataSource = pFacultad.GetAll();
            foreach (Facultad f in pFacultad.GetAll())
            {
                facultadDataGridView.Rows.Add(f.Id, s+1);
                
                    }


        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            frmEditarFacultad vamp = new frmEditarFacultad(null);
            vamp.ShowDialog();
            facultadBindingSource.DataSource = pFacultad.GetAll();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            frmEditarFacultad vamp = new frmEditarFacultad((Facultad)facultadBindingSource.Current);
            vamp.ShowDialog();
            facultadBindingSource.DataSource = pFacultad.GetAll();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Eliminar esta Facultad", "¿Esta seguro de eliminar el registro?", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                pFacultad.Delete((Facultad)facultadBindingSource.Current);
                facultadBindingSource.DataSource = pFacultad.GetAll();
            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            this.facultadBindingSource.DataSource = pFacultad.Buscar(txNombre.Text);
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
