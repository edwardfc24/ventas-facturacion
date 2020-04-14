using AppSales.BLL;
using AppSales.DTO;
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
    public partial class frmBuscarProducto : Form
    {
        public frmBuscarProducto()
        {
            InitializeComponent();
        }

        private void optMark_CheckedChanged(object sender, EventArgs e)
        {
            if (optMark.Checked)
            {
                boxOpciones.DataSource = MarcaBLL.SelectAll();
                boxOpciones.DisplayMember = "txtNombre";
                boxOpciones.ValueMember = "pkMarca";
                boxOpciones.Enabled = true;
            }
            else
            {
                boxOpciones.Enabled = false;
            }
        }

        private void optModel_CheckedChanged(object sender, EventArgs e)
        {
            if (optModel.Checked)
            {
                boxOpciones.DataSource = ModeloBLL.SelectAll();
                boxOpciones.DisplayMember = "txtNombre";
                boxOpciones.ValueMember = "pkModelo";
                boxOpciones.Enabled = true;
            }
            else
            {
                boxOpciones.Enabled = false;
            }
        }

        private void optSize_CheckedChanged(object sender, EventArgs e)
        {
            if (optSize.Checked)
            {
                boxOpciones.DataSource = TallaBLL.SelectAll();
                boxOpciones.DisplayMember = "txtNombre";
                boxOpciones.ValueMember = "pkTalla";
                boxOpciones.Enabled = true;
            }
            else
            {
                boxOpciones.Enabled = false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (optID.Checked && txtBuscado.Text != "")
            {
                int idProd;
                if (int.TryParse(txtBuscado.Text, out idProd))
                {
                    Producto aux = ProductoBLL.GetProductById(idProd);
                    if (aux != null)
                    {
                        limpiarTabla();
                        dgvEncontrados.Refresh();
                        dgvEncontrados.Rows.Add(aux.pkProducto, aux.txtNombre, aux.txtCodigo, aux.txtNombreMarca, aux.txtNombreModelo, aux.txtNombreTalla);
                        dgvEncontrados.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningun producto con ese ID");
                    }
                }
                else
                {
                    MessageBox.Show("El ID debe ser un número entero positivo");
                }
            }
            if (optName.Checked && txtBuscado.Text != "")
            {
                List<Producto> auxLista = ProductoBLL.GetProductsByName(txtBuscado.Text);
                if (auxLista.Count > 0)
                {
                    limpiarTabla();
                    dgvEncontrados.Refresh();
                    foreach (Producto aux in auxLista)
                    {
                        dgvEncontrados.Rows.Add(aux.pkProducto, aux.txtNombre, aux.txtCodigo, aux.txtNombreMarca, aux.txtNombreModelo, aux.txtNombreTalla);
                    }
                    dgvEncontrados.Refresh();
                }
                else
                {
                    MessageBox.Show("No se encontró ningun producto con ese nombre");
                }
            }
            if (optCode.Checked && txtBuscado.Text != "")
            {
                Producto aux = ProductoBLL.GetProductByCode(txtBuscado.Text);
                if (aux != null)
                {
                    limpiarTabla();
                    dgvEncontrados.Refresh();
                    dgvEncontrados.Rows.Add(aux.pkProducto, aux.txtNombre, aux.txtCodigo, aux.txtNombreMarca, aux.txtNombreModelo, aux.txtNombreTalla);
                    dgvEncontrados.Refresh();
                }
                else
                {
                    MessageBox.Show("No se encontró ningun producto con ese Código");
                }
            }
            if (optMark.Checked)
            {
                int idAux = Convert.ToInt32(boxOpciones.SelectedValue);
                List<Producto> auxLista = ProductoBLL.GetProductsByMark(idAux);
                if (auxLista.Count > 0)
                {
                    limpiarTabla();
                    dgvEncontrados.Refresh();
                    foreach (Producto aux in auxLista)
                    {
                        dgvEncontrados.Rows.Add(aux.pkProducto, aux.txtNombre, aux.txtCodigo, aux.txtNombreMarca, aux.txtNombreModelo, aux.txtNombreTalla);
                    }
                    dgvEncontrados.Refresh();
                }
                else
                {
                    MessageBox.Show("No se encontró ningun producto con esa Marca");
                    limpiarTabla();
                    dgvEncontrados.Refresh();
                }
            }
            if (optModel.Checked)
            {
                int idAux = Convert.ToInt32(boxOpciones.SelectedValue);
                List<Producto> auxLista = ProductoBLL.GetProductsByModel(idAux);
                if (auxLista.Count > 0)
                {
                    limpiarTabla();
                    dgvEncontrados.Refresh();
                    foreach (Producto aux in auxLista)
                    {
                        dgvEncontrados.Rows.Add(aux.pkProducto, aux.txtNombre, aux.txtCodigo, aux.txtNombreMarca, aux.txtNombreModelo, aux.txtNombreTalla);
                    }
                    dgvEncontrados.Refresh();
                }
                else
                {
                    MessageBox.Show("No se encontró ningun producto con esa Modelo");
                    limpiarTabla();
                    dgvEncontrados.Refresh();
                }
            }
            if (optSize.Checked)
            {
                int idAux = Convert.ToInt32(boxOpciones.SelectedValue);
                List<Producto> auxLista = ProductoBLL.GetProductsBySize(idAux);
                if (auxLista.Count > 0)
                {
                    limpiarTabla();
                    dgvEncontrados.Refresh();
                    foreach (Producto aux in auxLista)
                    {
                        dgvEncontrados.Rows.Add(aux.pkProducto, aux.txtNombre, aux.txtCodigo, aux.txtNombreMarca, aux.txtNombreModelo, aux.txtNombreTalla);
                    }
                    dgvEncontrados.Refresh();
                }
                else
                {
                    MessageBox.Show("No se encontró ningun producto con esa Talla");
                    limpiarTabla();
                    dgvEncontrados.Refresh();
                }
            }
        }

        private void dgvEncontrados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == btnUpdate.Index)
            {
                if (e.RowIndex >= 0)
                {

                    frmInsertarProductos frm = new frmInsertarProductos();
                    frm.MdiParent = this.MdiParent;
                    frm.WindowState = FormWindowState.Maximized;
                    frm.Show();
                    frm.TipoInsercion = 1;
                    int idP = Convert.ToInt32(dgvEncontrados.Rows[e.RowIndex].Cells[0].Value);
                    Producto aux = ProductoBLL.GetProductById(idP);
                    frm.BoxProveedor.SelectedValue = aux.fkProveedor;
                    frm.BoxMarca.SelectedValue = aux.fkMarca;
                    frm.BoxModelo.SelectedValue = aux.fkModelo;
                    frm.BoxTalla.SelectedValue = aux.fkTalla;
                    frm.CodProducto = aux.pkProducto + "";
                    frm.TxtCodigo.Text = aux.txtCodigo;
                    frm.TxtNombre.Text = aux.txtNombre;
                    frm.TxtDescripcion.Text = aux.txtDescripcion;
                    frm.TxtCantidad.Text = aux.intCantidad + "";
                    frm.TxtValorCompra.Text = aux.decValorCompra + "";
                    frm.TxtValorVenta.Text = aux.decValorVenta + "";
                    if (aux.intGenero == 0)
                    {
                        frm.BoxGenero.SelectedIndex = 1;
                    }
                    else
                    {
                        frm.BoxGenero.SelectedIndex = 2;
                    }

                    this.Dispose();
                }
            }
            if (e.ColumnIndex == btnEliminar.Index)
            {
                if (e.RowIndex >= 0)
                {
                    if (MessageBox.Show("Esta seguro de eliminar este producto?", "Eliminar Producto", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (MessageBox.Show("Esta totalmente seguro?", "Eliminar Producto", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            int codigo = Convert.ToInt32(dgvEncontrados.Rows[e.RowIndex].Cells[0].Value);
                            ProductoBLL.DeleteProducto(codigo);
                            MessageBox.Show("Registro eliminado");
                            dgvEncontrados.Rows.RemoveAt(e.RowIndex);
                            dgvEncontrados.Refresh();
                        }
                    }
                }
            }
        }
        public void limpiarTabla()
        {
            do
            {
                foreach (DataGridViewRow row in dgvEncontrados.Rows)
                {
                    try
                    {
                        dgvEncontrados.Rows.Remove(row);
                    }
                    catch (Exception) { }
                }
            } while (dgvEncontrados.Rows.Count > 1);
        }
    }
}
