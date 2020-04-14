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
    public partial class frmInsertarModelos : Form
    {
        private Validaciones validacion;
        private int tipoInserccion = 0;
        public frmInsertarModelos()
        {
            InitializeComponent();
            validacion = new Validaciones();
            txtPk.Visible = false;
            tblModelos.Columns[0].Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.insertar();
            this.limpiarCampos();
        }

        private void frmInsertarModelos_Load(object sender, EventArgs e)
        {
            this.inicializarDatos();
        }

        private void tblModelos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.tipoClic(e);
        }

        public void inicializarDatos()
        {
            tblModelos.DataSource = ModeloBLL.SelectAll();
        }

        public void tipoClic(DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == btnUpdate.Index)
            {
                txtPk.Text = tblModelos.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtModelo.Text = tblModelos.Rows[e.RowIndex].Cells[1].Value.ToString();
                btnGuardar.Text = "Actualizar";
                tipoInserccion = 1;
            }

            if (e.ColumnIndex == btnEliminar.Index)
            {
                if (MessageBox.Show("Esta seguro de eliminar este registro?", "Eliminar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (MessageBox.Show("Esta totalmente seguro?", "Eliminar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int codigo = Convert.ToInt32(tblModelos.Rows[e.RowIndex].Cells[0].Value);
                        ModeloBLL.DeleteModelo(codigo);
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
                if (validacion.nulos(txtModelo))
                {
                    string modelo = txtModelo.Text;
                    int usuario = IdUsuario.IdUsuarioConectado;
                    ModeloBLL.InsertarModelo(0, modelo, usuario);
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
                string nombre = txtModelo.Text;
                int usuarioModificacion = IdUsuario.IdUsuarioConectado;
                btnGuardar.Text = "Actualizar";
                if (validacion.nulos(txtModelo))
                {
                    ModeloBLL.UpdateModelo(pk, nombre, usuarioModificacion);
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
            txtModelo.Text = "";
        }
    }
}
