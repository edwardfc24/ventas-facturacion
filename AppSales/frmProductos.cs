using AppSales.BLL;
using AppSales.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSales
{
    public partial class frmProductos : Form
    {

        private int imprimir = 0;
        private Font printFont;
        private StreamReader streamToPrint;
        private string savePath = "";
        public frmProductos()
        {
            InitializeComponent();
            this.cargarDatosProductos();
            this.Text = "Productos";
            this.tblProductos.Columns[0].Visible = false;
            this.tblProductos.Columns[1].Visible = false;
            this.tblProductos.Columns[2].Visible = false;
            this.tblProductos.Columns[3].Visible = false;
            this.tblProductos.Columns[4].Visible = false;
            this.tblProductos.Columns[11].Visible = false;
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            this.cargarCheckBox();
            for (int i = 0; i < tblProductos.RowCount; i++)
            {
                if (Convert.ToInt16(tblProductos.Rows[i].Cells[11].Value) == 0)
                {
                    tblProductos.Rows[i].Cells[12].Value = "Niño";
                }
                else
                {
                    tblProductos.Rows[i].Cells[12].Value = "Niña";
                }
            }
        }

        private void tblProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.tipoBotonClic(e);

        }

        private void tblProductos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            this.seleccionarTodosLosProductos(e);
        }

        private void btnImprimirBarCode_Click(object sender, EventArgs e)
        {
            if (hayImpresion())
            {
                //MessageBox.Show("hay para imprmir");
                this.cargarImpresora();
                imprimir = 0;
            }
        }

        public void cargarDatosProductos()
        {
            tblProductos.DataSource = ProductoBLL.SelectAll();
        }

        public void tipoBotonClic(DataGridViewCellEventArgs e)
        {
            //si el click es en el boton actualizar
            if (e.ColumnIndex == btnUpdate.Index)
            {
                if (e.RowIndex >= 0)
                {

                    frmInsertarProductos frm = new frmInsertarProductos();
                    frm.MdiParent = this.MdiParent;
                    frm.WindowState = FormWindowState.Maximized;
                    frm.Show();
                    frm.TipoInsercion = 1;
                    frm.BoxProveedor.SelectedValue = tblProductos.Rows[e.RowIndex].Cells[0].Value;
                    frm.BoxMarca.SelectedValue = tblProductos.Rows[e.RowIndex].Cells[1].Value;
                    frm.BoxModelo.SelectedValue = tblProductos.Rows[e.RowIndex].Cells[2].Value;
                    frm.BoxTalla.SelectedValue = tblProductos.Rows[e.RowIndex].Cells[3].Value;
                    frm.CodProducto = Convert.ToString(tblProductos.Rows[e.RowIndex].Cells[4].Value);
                    frm.TxtCodigo.Text = Convert.ToString(tblProductos.Rows[e.RowIndex].Cells[5].Value);
                    frm.TxtNombre.Text = Convert.ToString(tblProductos.Rows[e.RowIndex].Cells[6].Value);
                    frm.TxtDescripcion.Text = Convert.ToString(tblProductos.Rows[e.RowIndex].Cells[7].Value);
                    frm.TxtCantidad.Text = Convert.ToString(tblProductos.Rows[e.RowIndex].Cells[8].Value);
                    frm.TxtValorCompra.Text = Convert.ToString(tblProductos.Rows[e.RowIndex].Cells[9].Value);
                    frm.CantidadAuxiliar = Convert.ToInt16(tblProductos.Rows[e.RowIndex].Cells[8].Value);
                    frm.DecValorCompraAuxiliar = Convert.ToInt16(tblProductos.Rows[e.RowIndex].Cells[9].Value);
                    frm.TxtValorVenta.Text = Convert.ToString(tblProductos.Rows[e.RowIndex].Cells[10].Value);
                    if (Convert.ToInt16(tblProductos.Rows[e.RowIndex].Cells[11].Value) == 0)
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
                            int codigo = Convert.ToInt32(tblProductos.Rows[e.RowIndex].Cells[4].Value);
                            ProductoBLL.DeleteProducto(codigo);
                            MessageBox.Show("Registro eliminado");
                            this.cargarDatosProductos();
                        }
                    }
                }
            }
        }

        public void seleccionarTodosLosProductos(DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == chkImprimir.Index)
            {
                tblProductos.EndEdit();  //Stop editing of cell.
                for (int i = 0; i < tblProductos.RowCount; i++)
                {
                    tblProductos.Rows[i].Cells[19].Value = true;

                }
            }

        }

        public void cargarCheckBox()
        {
            tblProductos.EndEdit();  //Stop editing of cell.
            for (int i = 0; i < tblProductos.RowCount; i++)
            {
                tblProductos.Rows[i].Cells[19].Value = false;

            }
        }

        public Boolean hayImpresion()
        {
            FolderBrowserDialog sf = new FolderBrowserDialog();
            // Feed the dummy name to the save dialog
            DialogResult result = sf.ShowDialog();
            if (result == DialogResult.OK)
            {
                savePath = sf.SelectedPath + "\\Etiquetas.txt";
                using (StreamWriter writer = new StreamWriter(savePath, false))
                {
                    for (int i = 0; i < tblProductos.RowCount; i++)
                    {
                        tblProductos.EndEdit();
                        if ((bool)tblProductos.Rows[i].Cells[19].Value)
                        {
                            imprimir++;
                            writer.WriteLine("*" + tblProductos.Rows[i].Cells[5].Value + "*" + "\n");
                            writer.WriteLine("*" + tblProductos.Rows[i].Cells[5].Value + "*" + "\n");
                        }
                    }
                }
            }
            if (imprimir >= 1)
            {
                return true;
            }
            return false;
        }

        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            float linesPerPage = 0;
            int count = 0;
            int posX = 0;
            int posXNumber = 20;
            int posY = 0;
            int posYNumber = 30;
            string line = null;

            // Calculate the number of lines per page.
            linesPerPage = ev.MarginBounds.Height /
               printFont.GetHeight(ev.Graphics);

            // Print each line of the file. 
            while (count < linesPerPage &&
               ((line = streamToPrint.ReadLine()) != null))
            {
                if (count % 2 == 0)
                {
                ev.Graphics.DrawString(line, printFont, Brushes.Black,
                   posX, posY, new StringFormat());
                ev.Graphics.DrawString(line, new Font("Arial", 14), Brushes.Black, posXNumber, posYNumber, new StringFormat());
                }
                else
                {
                    ev.Graphics.DrawString(line, new Font("Arial", 14), Brushes.Black, posXNumber, posYNumber, new StringFormat());
                }
                count++;

                posX += 100;
                posXNumber += 100;
                if (posX == 500)
                {
                    posY += 100;
                    posYNumber += 100;
                    posX = -100;
                    posXNumber = -80;
                }

            }

            // If more lines exist, print another page. 
            if (line != null)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;
        }

        public void cargarImpresora()
        {
            try
            {
                streamToPrint = new StreamReader(savePath);
                try
                {
                    printFont = new Font("Bar-Code 39", 18);
                    PrintDocument pd = new PrintDocument();
                    pd.PrintPage += new PrintPageEventHandler
                       (this.pd_PrintPage);
                    pd.Print();
                }
                finally
                {
                    streamToPrint.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
