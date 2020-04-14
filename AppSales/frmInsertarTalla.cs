using AppSales.BLL;
using AppSales.DTO;
using AppSales.Validacion;
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
    public partial class frmInsertarTalla : Form
    {
        private Validaciones validacion;
        private int tipoInserccion = 0;
        public frmInsertarTalla()
        {
            InitializeComponent();
            validacion = new Validaciones();
            txtPk.Visible = false;
            tblTalla.Columns[0].Visible = false;
        }

        private void frmInsertarTalla_Load(object sender, EventArgs e)
        {
            this.inicializarDatos();
        }

        private void tblTalla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.tipoClic(e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.insertar();
        }

        public void inicializarDatos()
        {
            tblTalla.DataSource = TallaBLL.SelectAll();
        }

        public void tipoClic(DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == btnUpdate.Index)
            {
                txtPk.Text = tblTalla.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTalla.Text = tblTalla.Rows[e.RowIndex].Cells[1].Value.ToString();
                btnGuardar.Text = "Actualizar";
                tipoInserccion = 1;
            }

            if (e.ColumnIndex == btnEliminar.Index)
            {
                if (MessageBox.Show("Esta seguro de eliminar este registro?", "Eliminar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (MessageBox.Show("Esta totalmente seguro?", "Eliminar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int codigo = Convert.ToInt32(tblTalla.Rows[e.RowIndex].Cells[0].Value);
                        TallaBLL.DeleteTalla(codigo);
                        MessageBox.Show("Registro eliminado");
                        this.inicializarDatos();
                    }
                }
            }
        }

        public void insertar()
        {
            if (tipoInserccion == 0)
            {
                if (validacion.nulos(txtTalla))
                {
                    string talla = txtTalla.Text;
                    int usuario = IdUsuario.IdUsuarioConectado;
                    TallaBLL.InsertarTalla(0, talla, usuario);
                    MessageBox.Show("Registro guardado satisfactoriamente");
                    this.inicializarDatos();
                }
                else
                {
                    MessageBox.Show("Por favor algunos campos son incorrectos");
                }
            }

            if (tipoInserccion == 1)
            {
                int pk = Convert.ToInt16(txtPk.Text);
                string nombre = txtTalla.Text;
                int usuarioModificacion = IdUsuario.IdUsuarioConectado;
                btnGuardar.Text = "Actualizar";
                if (validacion.nulos(txtTalla))
                {
                    TallaBLL.UpdateTalla(pk, nombre, usuarioModificacion);
                    MessageBox.Show("Registro actualizado satisfactoriamente");
                    this.inicializarDatos();
                    this.tipoInserccion = 0;
                    btnGuardar.Text = "Guardar";
                }
                else
                {
                    MessageBox.Show("Por favor verifique que el campo este correcto");
                }
            }
        }

        public void limpiarCampos()
        {
            txtPk.Text = "";
            txtTalla.Text = "";
        }
    }
}
