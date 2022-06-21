using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaDiseño
{
    public partial class formPrincipal : Form
    {
        public formPrincipal()
        {
            InitializeComponent();
        }
        private void ocultarSubmenu()
        {
            if (pnlSubClientes.Visible == true)
                pnlSubClientes.Visible = false;
            if (pnlSubEmpleado.Visible == true)
                pnlSubEmpleado.Visible = false;
            if (pnlSubProducto.Visible == true)
                pnlSubProducto.Visible = false;
            if (pnlSubVentas.Visible == true)
                pnlSubVentas.Visible = false;
        }
        private void mostrarSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                ocultarSubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }
        private Form forActivo = null;
        private void abrirForHijos(Form forHijo)
        {
            if (forActivo != null)
            {
                forActivo.Close();
            }
            forActivo = forHijo;
            forHijo.TopLevel = false;
            forHijo.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(forHijo);
            pnlContenedor.Tag = forHijo;
            forHijo.BringToFront();
            forHijo.Show();
        }
        private void formPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(pnlSubEmpleado);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(pnlSubClientes);
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(pnlSubProducto);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(pnlSubVentas);
        }

        private void imagen_Click(object sender, EventArgs e)
        {

        }

        private void pnlLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegEmpleados_Click(object sender, EventArgs e)
        {
            abrirForHijos(new formRegEmpleados());
        }

        private void btnConEmpleados_Click(object sender, EventArgs e)
        {
            abrirForHijos(new formConEmpleados());
        }

        private void btnRegVentas_Click(object sender, EventArgs e)
        {
            abrirForHijos(new formFactura());
        }

        private void btnRegClientes_Click(object sender, EventArgs e)
        {
            abrirForHijos(new formRegCliente());
        }

        private void btnConClientes_Click(object sender, EventArgs e)
        {
            abrirForHijos(new formConCliente());
        }

        private void btnRegProductos_Click(object sender, EventArgs e)
        {
            abrirForHijos(new formRegProducto());
        }

        private void btnConProductos_Click(object sender, EventArgs e)
        {
            abrirForHijos(new formConProducto());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
