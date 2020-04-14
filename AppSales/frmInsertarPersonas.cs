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
    public partial class frmInsertarPersonas : Form
    {

        private Persona persona;
        private Administrador administrador;
        private Empleado empleado;
        private Cliente cliente;
        private Proveedor proveedor;
        private Validaciones validacion;
        private int tipoPersona = -1;
        private int tipoInsercion = 0;

        public frmInsertarPersonas()
        {
            InitializeComponent();
            validacion = new Validaciones();
            txtFkGlobal.Visible = false;
            txtFkPersonas.Visible = false;
            this.Text = "Insertar Persona";
        }

        #region Get-Set

        public int TipoInsercion
        {
            get { return tipoInsercion; }
            set { tipoInsercion = value; }
        }

        public TextBox TxtFkPersonas
        {
            get { return txtFkPersonas; }
            set { txtFkPersonas = value; }
        }

        public TextBox TxtFkGlobal
        {
            get { return txtFkGlobal; }
            set { txtFkGlobal = value; }
        }

        public TextBox TxtNit
        {
            get { return txtNit; }
            set { txtNit = value; }
        }

        public TextBox TxtNombre
        {
            get { return txtNombre; }
            set { txtNombre = value; }
        }


        public TextBox TxtDireccion
        {
            get { return txtDireccion; }
            set { txtDireccion = value; }
        }

        public TextBox TxtTelefono
        {
            get { return txtTelefono; }
            set { txtTelefono = value; }
        }

        public TextBox TxtCelular
        {
            get { return txtCelular; }
            set { txtCelular = value; }
        }

        public TextBox TxtCorreo
        {
            get { return txtCorreo; }
            set { txtCorreo = value; }
        }

        public TextBox TxtPassword
        {
            get { return txtPassword; }
            set { txtPassword = value; }
        }

        public TextBox TxtDescripcion
        {
            get { return txtDescripcion; }
            set { txtDescripcion = value; }
        }

        public ComboBox BoxTipoPersona
        {
            get { return boxTipoPersona; }
            set { boxTipoPersona = value; }
        }

        public ComboBox BoxTipoCliente
        {
            get { return boxTipoCliente; }
            set { boxTipoCliente = value; }
        }

        #endregion

        #region metodosC#


        private void frmInsertarPersonas_Load(object sender, EventArgs e)
        {

        }

        private void boxTipoPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.seleccionarBox();
        }

        private void btnGuardarRegistro_Click(object sender, EventArgs e)
        {
            if (validacion.nulos(TxtNit) && validacion.nulos(txtNombre) && validacion.nulos(txtTelefono)
                && validacion.nulos(txtCelular) && validacion.logitud(txtNit))
            {
                this.insertarRegistro();
            }
            else
            {
                MessageBox.Show("Hay errores en los campos porfavor verifique");
            }
        }

        private void frmInsertarPersonas_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtNit_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloNumeros(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloLetras(e);
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloLetras(e);
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloNumeros(e);
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloNumeros(e);
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtIdUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        #endregion

        #region misMetodos
        public void insertarRegistro()
        {
            if (tipoPersona >= 0)
            {
                persona = new Persona();
                persona.txtNit = txtNit.Text;
                persona.txtNombreCompleto = txtNombre.Text;
                persona.txtDireccion = txtDireccion.Text;
                persona.txtTelefono = txtTelefono.Text;
                persona.txtCelular = txtCelular.Text;
                persona.txtCorreo = txtCorreo.Text;
                persona.intIdUsuairo = IdUsuario.IdUsuarioConectado;
                if (tipoPersona == 0)
                {
                    cliente = new Cliente();

                    if (tipoInsercion == 0)
                    {
                        cliente.fkPersona = PersonaBLL.InsertObjetoPersona(persona);
                        cliente.fkParametroCliente = Convert.ToInt32(boxTipoCliente.SelectedValue);
                        ClienteBLL.InsertObjetoCliente(cliente);
                        MessageBox.Show("El registro se agrego correctamente");
                        this.borrarDatos();
                    }

                    if (tipoInsercion == 1)
                    {
                        persona.pkPersona = Convert.ToInt32(txtFkPersonas.Text);
                        PersonaBLL.UpdatePersona(persona);
                        cliente.fkPersona = Convert.ToInt32(txtFkPersonas.Text);
                        cliente.fkParametroCliente = Convert.ToInt32(boxTipoCliente.SelectedValue);
                        ClienteBLL.UpdateCliente(cliente);
                        MessageBox.Show("El registro se ha actualizado correctamente");
                        frmClientes frm = new frmClientes();
                        frm.MdiParent = this.MdiParent;
                        frm.WindowState = FormWindowState.Maximized;
                        frm.Show();
                        this.Dispose();
                    }

                }

                if (tipoPersona == 1)
                {
                    empleado = new Empleado();

                    if (tipoInsercion == 0)
                    {
                        if (validacion.nulos(txtPassword))
                        {
                            empleado.fkPersona = PersonaBLL.InsertObjetoPersona(persona);
                            empleado.txtContraseña = txtPassword.Text;
                            EmpleadoBLL.InsertObjetoEmpleado(empleado);
                            MessageBox.Show("El registro se agrego correctamente");
                            this.borrarDatos();
                        }
                        else
                        {
                            MessageBox.Show("Usted no ha ingresado una contrasena");
                        }
                    }

                    if (tipoInsercion == 1)
                    {
                        if (validacion.nulos(txtPassword))
                        {
                            persona.pkPersona = Convert.ToInt32(txtFkPersonas.Text);
                            PersonaBLL.UpdatePersona(persona);
                            empleado.fkPersona = Convert.ToInt32(txtFkPersonas.Text);
                            empleado.txtContraseña = txtPassword.Text;
                            EmpleadoBLL.UpdateEmpleado(empleado);
                            MessageBox.Show("El registro se ha actualizado correctamente");
                            frmEmpleados frm = new frmEmpleados();
                            frm.MdiParent = this.MdiParent;
                            frm.WindowState = FormWindowState.Maximized;
                            frm.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Usted no ha ingresado una contrasena");
                        }
                    }
                }

                if (tipoPersona == 2)
                {
                    proveedor = new Proveedor();

                    if (tipoInsercion == 0)
                    {
                        if (validacion.nulos(txtDescripcion))
                        {
                            proveedor.fkPersona = PersonaBLL.InsertObjetoPersona(persona);
                            proveedor.txtDescripcion = TxtDescripcion.Text;
                            ProveedorBLL.InsertObjetoProveedor(proveedor);
                            MessageBox.Show("El registro se agrego correctamente");
                            this.borrarDatos();
                        }
                        else
                        {
                            MessageBox.Show("Usted no ha ingresado una descripcion");
                        }
                    }

                    if (tipoInsercion == 1)
                    {
                        if (validacion.nulos(txtDescripcion))
                        {
                            persona.pkPersona = Convert.ToInt32(txtFkPersonas.Text);
                            PersonaBLL.UpdatePersona(persona);
                            proveedor.fkPersona = Convert.ToInt32(txtFkPersonas.Text);
                            proveedor.txtDescripcion = TxtDescripcion.Text;
                            ProveedorBLL.UpdateProveedor(proveedor);
                            MessageBox.Show("El registro se ha actualizado correctamente");
                            frmProveedores frm = new frmProveedores();
                            frm.MdiParent = this.MdiParent;
                            frm.WindowState = FormWindowState.Maximized;
                            frm.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Usted no ha ingresado una descripcion");
                        }
                    }
                }
                if (tipoPersona == 3)
                {
                    administrador = new Administrador();

                    if (tipoInsercion == 0)
                    {
                        if (validacion.nulos(txtPassword))
                        {
                            administrador.fkPersona = PersonaBLL.InsertObjetoPersona(persona);
                            administrador.txtContraseña = txtPassword.Text;
                            AdministradorBLL.InsertObjetoAdministrador(administrador);
                            MessageBox.Show("El registro se agrego correctamente");
                            this.borrarDatos();
                        }
                        else
                        {
                            MessageBox.Show("Usted no ha ingresado una contrasena");
                        }
                    }

                    if (tipoInsercion == 1)
                    {
                        if (validacion.nulos(txtPassword))
                        {
                            persona.pkPersona = Convert.ToInt32(txtFkPersonas.Text);
                            PersonaBLL.UpdatePersona(persona);
                            administrador.fkPersona = Convert.ToInt32(txtFkPersonas.Text);
                            administrador.txtContraseña = txtPassword.Text;
                            AdministradorBLL.UpdateAdministrador(administrador);
                            MessageBox.Show("El registro se ha actualizado correctamente");
                            frmEmpleados frm = new frmEmpleados();
                            frm.MdiParent = this.MdiParent;
                            frm.WindowState = FormWindowState.Maximized;
                            frm.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Usted no ha ingresado una contrasena");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Usted no ha seleccionado el tipo de persona");
            }
        }

        public void seleccionarBox()
        {
            if (boxTipoPersona.SelectedItem.ToString() == "Cliente")
            {
                lblContraseña.Visible = false;
                txtPassword.Visible = false;
                lblDescripcion.Visible = false;
                txtDescripcion.Visible = false;
                lblParametroCliente.Visible = true;
                boxTipoCliente.Visible = true;
                boxTipoCliente.DataSource = ParametroClienteBLL.SelectAll();
                boxTipoCliente.ValueMember = "pkParametroCliente";
                boxTipoCliente.DisplayMember = "txtDescripcion";
                tipoPersona = 0;
            }

            if (boxTipoPersona.SelectedItem.ToString() == "Empleado")
            {
                lblParametroCliente.Visible = false;
                boxTipoCliente.Visible = false;
                lblDescripcion.Visible = false;
                txtDescripcion.Visible = false;
                lblContraseña.Visible = true;
                txtPassword.Visible = true;
                tipoPersona = 1;
            }

            if (boxTipoPersona.SelectedItem.ToString() == "Proveedor")
            {
                lblContraseña.Visible = false;
                txtPassword.Visible = false;
                lblParametroCliente.Visible = false;
                boxTipoCliente.Visible = false;
                lblDescripcion.Visible = true;
                txtDescripcion.Visible = true;
                tipoPersona = 2;
            }

            if (boxTipoPersona.SelectedItem.ToString() == "Administrador")
            {
                lblParametroCliente.Visible = false;
                boxTipoCliente.Visible = false;
                lblDescripcion.Visible = false;
                txtDescripcion.Visible = false;
                lblContraseña.Visible = true;
                txtPassword.Visible = true;
                tipoPersona = 3;
            }
        }

        public void borrarDatos()
        {
            txtNit.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtCelular.Text = "";
            txtCorreo.Text = "";
            txtDescripcion.Text = "";
            txtPassword.Text = "";
            persona = new Persona();
            administrador = new Administrador();
            cliente = new Cliente();
            proveedor = new Proveedor();
            empleado = new Empleado();
        }

        public void DisposeAllButThis(Form form)
        {
            foreach (Form frm in this.MdiParent.MdiChildren)
            {
                if (frm.GetType() != form.GetType() || frm.GetType() == form.GetType())
                {
                    frm.Close();
                }
            }
        }

        #endregion




    }
}
