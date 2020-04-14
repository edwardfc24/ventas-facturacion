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
    public partial class frmInsertarDescuentos : Form
    {
        private Descuento descuentos;
        private int tipoInsercion = 0;
        private Validaciones validacion;

        public frmInsertarDescuentos()
        {
            InitializeComponent();
            txtPkDescuento.Visible = false;
            validacion = new Validaciones();
            this.Text = "Insertar Descuento";
        }

        public int TipoInsercion
        {
            get { return tipoInsercion; }
            set { tipoInsercion = value; }
        }

        public string pkDescuento
        {
            get { return txtPkDescuento.Text; }
            set { txtPkDescuento.Text = value; }
        }
        public string Nombre{
            get{return txtNombre.Text;}
            set{txtNombre.Text=value;}
        }

        public string FechaInicio
        {
            get { return txtFechaInicio.Text; }
            set { txtFechaInicio.Text = value; }
        }

        public string FechaFin
        {
            get { return txtFechaFin.Text; }
            set { txtFechaFin.Text = value; }
        }

        public string Descuento
        {
            get { return txtDescuento.Text; }
            set { txtDescuento.Text = value; }
        }

        public string Descripcion
        {
            get { return txtDescripcion.Text; }
            set { txtDescripcion.Text = value; }
        }

        private void btnGuardarRegistro_Click(object sender, EventArgs e)
        {
            if (validacion.nulos(txtNombre) && validacion.nulos(txtDescuento) && validacion.nulos(txtDescripcion))
            {
                this.insertarDescuentos();
                this.vaciarCampos();
            }
            else
            {
                MessageBox.Show("Por favor Verfique que los campos de texto esten correctos");
            }
        }

        public void insertarDescuentos()
        {
             descuentos = new Descuento();
             descuentos.txtNombre = txtNombre.Text;
             descuentos.dateFechaInicio = Convert.ToDateTime(txtFechaInicio.Text);
             descuentos.dateFechaFin = Convert.ToDateTime(txtFechaFin.Text);
             descuentos.descuento = Convert.ToInt16(txtDescuento.Text);
             descuentos.descripcion = txtDescripcion.Text;
             descuentos.intIdUsuarioCreacion = IdUsuario.IdUsuarioConectado;
             if (tipoInsercion == 0) {
                 DescuentoBLL.InsertObjetoDescuento(descuentos);
                 MessageBox.Show("El registro se ha guardado correctamente");
             }

             if (tipoInsercion == 1)
             {
                 descuentos.pkDescuento = Convert.ToInt16(txtPkDescuento.Text);
                 DescuentoBLL.UpdateDescuento(descuentos);
                 MessageBox.Show("El registro se ha actualizado correctamente");
                 frmDescuentos frm = new frmDescuentos();
                 frm.MdiParent = this.MdiParent;
                 frm.WindowState = FormWindowState.Maximized;
                 frm.Show();
                 this.Dispose();
             }
             

        }

        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloNumeros(e);
        }

        public void vaciarCampos()
        {
            txtDescripcion.Text = "";
            txtDescuento.Text = "";
            txtNombre.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
