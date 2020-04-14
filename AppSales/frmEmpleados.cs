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
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
            this.cargarDatosEmpleados();
            this.tblEmpleados.Columns[0].Visible = false;
            this.tblEmpleados.Columns[1].Visible = false;
            this.tblEmpleados.Columns[8].Visible = false;
            this.Text = "Empleados";
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            this.DisposeAllButThis(this);
        }

        public void cargarDatosEmpleados()
        {
            tblEmpleados.DataSource = EmpleadoBLL.SelectAll();
        }

        private void tblEmpleados_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            this.tipoBotonClic(e);
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
                    frm.BoxTipoPersona.SelectedItem = "Empleado";
                    frm.BoxTipoPersona.Enabled = false;
                    frm.TipoInsercion = 1;
                    frm.TxtFkPersonas.Text = Convert.ToString(tblEmpleados.Rows[e.RowIndex].Cells[0].Value);
                    frm.TxtFkGlobal.Text = Convert.ToString(tblEmpleados.Rows[e.RowIndex].Cells[1].Value);
                    frm.TxtNit.Text = Convert.ToString(tblEmpleados.Rows[e.RowIndex].Cells[2].Value);
                    frm.TxtNombre.Text = Convert.ToString(tblEmpleados.Rows[e.RowIndex].Cells[3].Value);
                    frm.TxtDireccion.Text = Convert.ToString(tblEmpleados.Rows[e.RowIndex].Cells[4].Value);
                    frm.TxtTelefono.Text = Convert.ToString(tblEmpleados.Rows[e.RowIndex].Cells[5].Value);
                    frm.TxtCelular.Text = Convert.ToString(tblEmpleados.Rows[e.RowIndex].Cells[6].Value);
                    frm.TxtCorreo.Text = Convert.ToString(tblEmpleados.Rows[e.RowIndex].Cells[7].Value);
                    frm.TxtPassword.Text = Convert.ToString(tblEmpleados.Rows[e.RowIndex].Cells[8].Value);
                }
                //si el click es en el boton eliminar
                if (e.ColumnIndex == btnEliminar.Index)
                {
                    if (MessageBox.Show("Esta seguro de eliminar este registro?", "Eliminar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (MessageBox.Show("Esta totalmente seguro?", "Eliminar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            int codigo = Convert.ToInt32(tblEmpleados.Rows[e.RowIndex].Cells[0].Value);
                            EmpleadoBLL.DeleteEmpleado(codigo);
                            MessageBox.Show("Registro eliminado");
                            this.cargarDatosEmpleados();
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
