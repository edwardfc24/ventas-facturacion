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
    public partial class frmOfertas : Form
    {
        public frmOfertas()
        {
            InitializeComponent();
            tblOfertas.Columns[0].Visible = false;
            this.Text = "Ofertas";
        }

        private void frmOfertas_Load(object sender, EventArgs e)
        {
            this.cargarDatosOfertas();
        }

        private void tblOfertas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.tipoBotonClic(e);
        }

        private void cargarDatosOfertas(){
            tblOfertas.DataSource = OfertaBLL.SelectAll();
        }

        public void tipoBotonClic(DataGridViewCellEventArgs e)
        {
            //si el click es en el boton actualizar
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == btnUpdate.Index)
                {
                    frmInsertarOfertas frm = new frmInsertarOfertas();
                    frm.MdiParent = this.MdiParent;
                    frm.WindowState = FormWindowState.Maximized;
                    frm.Show();
                    frm.TipoInsercion = 1;
                    frm.PkOfertas = Convert.ToString(tblOfertas.Rows[e.RowIndex].Cells[0].Value);
                    frm.NombreOferta = Convert.ToString(tblOfertas.Rows[e.RowIndex].Cells[1].Value);
                    frm.FechaInicio = Convert.ToString(tblOfertas.Rows[e.RowIndex].Cells[2].Value);
                    frm.FechaFin = Convert.ToString(tblOfertas.Rows[e.RowIndex].Cells[3].Value);
                    frm.Descripcion = Convert.ToString(tblOfertas.Rows[e.RowIndex].Cells[4].Value);
                    this.Dispose();
                }
                //si el click es en el boton eliminar
                if (e.ColumnIndex == btnEliminar.Index)
                {
                    if (MessageBox.Show("Esta seguro de eliminar este registro?", "Eliminar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (MessageBox.Show("Esta totalmente seguro?", "Eliminar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            int codigo = Convert.ToInt32(tblOfertas.Rows[e.RowIndex].Cells[0].Value);
                            OfertaBLL.DeleteOferta(codigo);
                            MessageBox.Show("Registro eliminado");
                            this.cargarDatosOfertas();
                        }
                    }
                }
            }
        }

    }
}
