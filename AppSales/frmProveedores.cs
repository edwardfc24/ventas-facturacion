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
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
            this.cargarDatosProveedor();
            this.tblProveedor.Columns[0].Visible = false;
            this.tblProveedor.Columns[1].Visible = false;
            this.Text = "Proveedores";
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            this.DisposeAllButThis(this);
        }

        private void tblProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.tipoBotonClic(e);
        }

        public void cargarDatosProveedor()
        {
            tblProveedor.DataSource = ProveedorBLL.SelectAll();
        }

        public void tipoBotonClic(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //si el click es en el boton actualizar
                if (e.ColumnIndex == btnUpdate.Index)
                {
                    frmInsertarPersonas frm = new frmInsertarPersonas();
                    frm.MdiParent = this.MdiParent;
                    frm.WindowState = FormWindowState.Maximized;
                    frm.Show();
                    frm.BoxTipoPersona.SelectedItem = "Proveedor";
                    frm.BoxTipoPersona.Enabled = false;
                    frm.TipoInsercion = 1;
                    frm.TxtFkPersonas.Text = Convert.ToString(tblProveedor.Rows[e.RowIndex].Cells[0].Value);
                    frm.TxtFkGlobal.Text = Convert.ToString(tblProveedor.Rows[e.RowIndex].Cells[1].Value);
                    frm.TxtNit.Text = Convert.ToString(tblProveedor.Rows[e.RowIndex].Cells[2].Value);
                    frm.TxtNombre.Text = Convert.ToString(tblProveedor.Rows[e.RowIndex].Cells[3].Value);
                    frm.TxtDireccion.Text = Convert.ToString(tblProveedor.Rows[e.RowIndex].Cells[4].Value);
                    frm.TxtTelefono.Text = Convert.ToString(tblProveedor.Rows[e.RowIndex].Cells[5].Value);
                    frm.TxtCelular.Text = Convert.ToString(tblProveedor.Rows[e.RowIndex].Cells[6].Value);
                    frm.TxtCorreo.Text = Convert.ToString(tblProveedor.Rows[e.RowIndex].Cells[7].Value);
                    frm.TxtDescripcion.Text = Convert.ToString(tblProveedor.Rows[e.RowIndex].Cells[8].Value);
                }
                //si el click es en el boton eliminar
                if (e.ColumnIndex == btnEliminar.Index)
                {
                    if (MessageBox.Show("Esta seguro de eliminar este registro?", "Eliminar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (MessageBox.Show("Esta totalmente seguro?", "Eliminar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            int codigo = Convert.ToInt32(tblProveedor.Rows[e.RowIndex].Cells[0].Value);
                            ProveedorBLL.DeleteProveedor(codigo);
                            MessageBox.Show("Registro eliminado");
                            this.cargarDatosProveedor();
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
