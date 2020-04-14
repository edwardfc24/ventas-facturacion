using AppSales.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSales
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
            this.cargarDatosClientes();
            this.tblClientes.Columns[0].Visible = false;
            this.tblClientes.Columns[1].Visible = false;
            this.Text = "Clientes";
        }


        private void Clientes_Load(object sender, EventArgs e)
        {
            this.DisposeAllButThis(MdiParent);
        }

        private void tblClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.tipoBotonClic(e);
        }

        public void cargarDatosClientes()
        {
            tblClientes.DataSource = ClienteBLL.SelectAll();
        }

        public void tipoBotonClic(DataGridViewCellEventArgs e)
        {
            //si el click es en el boton actualizar
            if (e.RowIndex >=0)
            {
                if (e.ColumnIndex == btnUpdate.Index)
                {
                    frmInsertarPersonas frm = new frmInsertarPersonas();
                    frm.MdiParent = this.MdiParent;
                    frm.WindowState = FormWindowState.Maximized;
                    frm.Show();
                    frm.BoxTipoPersona.SelectedItem = "Cliente";
                    frm.BoxTipoPersona.Enabled = false;
                    frm.TipoInsercion = 1;
                    frm.TxtFkPersonas.Text = Convert.ToString(tblClientes.Rows[e.RowIndex].Cells[0].Value);
                    frm.TxtFkGlobal.Text = Convert.ToString(tblClientes.Rows[e.RowIndex].Cells[1].Value);
                    frm.TxtNit.Text = Convert.ToString(tblClientes.Rows[e.RowIndex].Cells[2].Value);
                    frm.TxtNombre.Text = Convert.ToString(tblClientes.Rows[e.RowIndex].Cells[3].Value);
                    frm.TxtDireccion.Text = Convert.ToString(tblClientes.Rows[e.RowIndex].Cells[4].Value);
                    frm.TxtTelefono.Text = Convert.ToString(tblClientes.Rows[e.RowIndex].Cells[5].Value);
                    frm.TxtCelular.Text = Convert.ToString(tblClientes.Rows[e.RowIndex].Cells[6].Value);
                    frm.TxtCorreo.Text = Convert.ToString(tblClientes.Rows[e.RowIndex].Cells[7].Value);
                    frm.BoxTipoCliente.Text = Convert.ToString(tblClientes.Rows[e.RowIndex].Cells[8].Value);
                    this.Dispose();
                }
                //si el click es en el boton eliminar
                if (e.ColumnIndex == btnEliminar.Index)
                {
                    if (MessageBox.Show("Esta seguro de eliminar este registro?", "Eliminar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (MessageBox.Show("Esta totalmente seguro?", "Eliminar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            int codigo = Convert.ToInt32(tblClientes.Rows[e.RowIndex].Cells[0].Value);
                            ClienteBLL.DeleteCliente(codigo);
                            MessageBox.Show("Registro eliminado");
                            this.cargarDatosClientes();
                        }
                    }
                }
            }
        }

        public void DisposeAllButThis(Form form)
        {
            foreach (Form frm in this.MdiParent.MdiChildren)
            {
                if (frm.GetType() == form.GetType() && frm != form)
                {
                    frm.Close();
                }
            }
        }

    }
}
