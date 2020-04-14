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
    public partial class frmInsertarMarcas : Form
    {
        private Validaciones validacion;
        private int tipoInserccion = 0;
        public frmInsertarMarcas()
        {
            InitializeComponent();
            validacion = new Validaciones();
            txtPk.Visible = false;
            tblMarcas.Columns[0].Visible = false;
        }

        private void frmInsertarMarcas_Load(object sender, EventArgs e)
        {
            this.inicializarDatos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.insertar();
            this.limpiarCampos();

        }

        private void tblMarcas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.tipoClic(e);
        }

        public void inicializarDatos()
        {
            tblMarcas.DataSource = MarcaBLL.SelectAll();
        }

        public void tipoClic(DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == btnUpdate.Index)
            {
                txtPk.Text = tblMarcas.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtMarca.Text = tblMarcas.Rows[e.RowIndex].Cells[1].Value.ToString();
                btnGuardar.Text = "Actualizar";
                tipoInserccion = 1;
            }

            if (e.ColumnIndex == btnEliminar.Index)
            {
                if (MessageBox.Show("Esta seguro de eliminar este registro?", "Eliminar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (MessageBox.Show("Esta totalmente seguro?", "Eliminar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int codigo = Convert.ToInt32(tblMarcas.Rows[e.RowIndex].Cells[0].Value);
                        MarcaBLL.DeleteMarca(codigo);
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
                if (validacion.nulos(txtMarca))
                {
                    string marca = txtMarca.Text;
                    int usuario = IdUsuario.IdUsuarioConectado;
                    MarcaBLL.InsertarMarca(0, marca, usuario);
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
                string nombre = txtMarca.Text;
                int usuarioModificacion = IdUsuario.IdUsuarioConectado;
                btnGuardar.Text = "Actualizar";
                if (validacion.nulos(txtMarca))
                {
                    MarcaBLL.UpdateMarca(pk, nombre, usuarioModificacion);
                    MessageBox.Show("Registro actualizado satisfactoriamente");
                    this.inicializarDatos();
                    this.tipoInserccion = 0;
                    btnGuardar.Text="Guardar";
                }
                else
                {
                    MessageBox.Show("Por favor verifique que el campo este correcto");
                }
            }
        }

        public void limpiarCampos()
        {
            txtPk.Text="";
            txtMarca.Text="";
        }
    }
}
