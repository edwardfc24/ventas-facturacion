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
    public partial class frmInsertarOfertas : Form
    {
        private Oferta oferta;
        private Validaciones validacion;
        private int tipoInsercion=0;

        #region Setter-Getter
        public string PkOfertas
        {
            get { return txtPkOfertas.Text; }
            set { txtPkOfertas.Text = value; }
        }

        public int TipoInsercion
        {
            get { return tipoInsercion; }
            set { tipoInsercion = value; }
        }

        public string NombreOferta
        {
            get { return txtNombreOferta.Text; }
            set { txtNombreOferta.Text = value; }
        }

        public string FechaInicio
        {
            get { return dtFechaInicio.Text; }
            set { dtFechaInicio.Text = value; }
        }

        public string FechaFin
        {
            get { return dtFechaFin.Text; }
            set { dtFechaFin.Text = value; }
        }

        public string Descripcion
        {
            get { return txtDescripcion.Text; }
            set { txtDescripcion.Text = value; }
        }
        #endregion

        public frmInsertarOfertas()
        {
            InitializeComponent();
            validacion = new Validaciones();
            this.txtPkOfertas.Visible = false;
            this.Text = "Insertar Oferta";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validacion.nulos(txtNombreOferta) && validacion.nulos(txtDescripcion))
            {
                this.insertarRegistro();
                this.vaciarCampos();
            }
            else
            {
                MessageBox.Show("Por favor revise si todos los campos estan correctos");
            }
           
        }

        private void insertarRegistro()
        {
            oferta = new Oferta();
            oferta.nombre = txtNombreOferta.Text;
            oferta.fechaInicio = Convert.ToDateTime(dtFechaInicio.Text);
            oferta.fechaFin = Convert.ToDateTime(dtFechaFin.Text);
            oferta.descripcion = txtDescripcion.Text;
            oferta.intIdUsuarioCreacion = IdUsuario.IdUsuarioConectado;
            if (tipoInsercion == 0)
            {
                OfertaBLL.InsertObjetoOferta(oferta);
                MessageBox.Show("El registro se agrego correctamente");
            }

            if (tipoInsercion == 1)
            {
                oferta.id_Ofertas = Convert.ToInt16(txtPkOfertas.Text);
                OfertaBLL.UpdateOferta(oferta);
                MessageBox.Show("El registro se ha actualizado correctamente");
                frmOfertas frm = new frmOfertas();
                frm.MdiParent = this.MdiParent;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
                this.Dispose();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtNombreOferta_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloLetras(e);
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        public void vaciarCampos()
        {
            txtDescripcion.Text = "";
            txtNombreOferta.Text = "";
        }
    }
}
