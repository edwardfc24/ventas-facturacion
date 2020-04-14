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
    public partial class frmInsertarLlaveFactura : Form
    {
        private LlaveFactura llave;
        public frmInsertarLlaveFactura()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            llave = new LlaveFactura();
            llave.txtNroAutorizacion = txtNroAutorizacion.Text;
            llave.txtLlave = @txtLlave.Text;
            llave.dateFechaLimite = Convert.ToDateTime(dtFechaLimite.Text);
            LlaveFacturaBLL.InsertObjetoLlaveFactura(llave,1);
            MessageBox.Show("El registro se ha inserto correctamente");
            this.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
