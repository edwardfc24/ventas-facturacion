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
    public partial class frmDescuentos : Form
    {
        public frmDescuentos()
        {
            InitializeComponent();
            tblDescuentos.Columns[0].Visible = false;
            this.Text = "Descuentos";
        }

        private void frmDescuentos_Load(object sender, EventArgs e)
        {
            this.cargarDatos();
        }

        private void tblDescuentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.tipoBoton(e);
        }

        public void cargarDatos()
        {
            tblDescuentos.DataSource = DescuentoBLL.SelectAll();
        }

        public void tipoBoton(DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == btnUpdate.Index)
            {
                frmInsertarDescuentos frm = new frmInsertarDescuentos();
                frm.MdiParent = this.MdiParent;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
                frm.TipoInsercion = 1;
                frm.pkDescuento = tblDescuentos.Rows[e.RowIndex].Cells[0].Value.ToString();
                frm.Nombre = tblDescuentos.Rows[e.RowIndex].Cells[1].Value.ToString();
                frm.FechaInicio = tblDescuentos.Rows[e.RowIndex].Cells[2].Value.ToString();
                frm.FechaFin = tblDescuentos.Rows[e.RowIndex].Cells[3].Value.ToString();
                frm.Descuento = tblDescuentos.Rows[e.RowIndex].Cells[4].Value.ToString();
                frm.Descripcion = tblDescuentos.Rows[e.RowIndex].Cells[5].Value.ToString();
                this.Dispose();
            }

            if (e.ColumnIndex == btnEliminar.Index)
            {
                if (MessageBox.Show("Esta seguro de eliminar este registro?", "Eliminar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (MessageBox.Show("Esta totalmente seguro?", "Eliminar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int pkDescuento = Convert.ToInt16(tblDescuentos.Rows[e.RowIndex].Cells[0].Value.ToString());
                        DescuentoBLL.DeleteDescuento(pkDescuento);
                        MessageBox.Show("Registro eliminado satisfactoriamente");
                        this.cargarDatos();
                    }
                }
            }
        }
    }
}
