using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using capaLogica;
using capaEntidades;

namespace capaDiseño
{
    public partial class formRegProducto : Form
    {
        public formRegProducto()
        {
            InitializeComponent();
            actualizarId();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnRegEmpleado_Click(object sender, EventArgs e)
        {
            clsProducto producto = new clsProducto();
            bool error = false;
            try
            {
                Convert.ToInt64(txtPcompra.Text);
                Convert.ToInt64(txtPventa.Text);
                Convert.ToInt64(txtCantidad.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Los campos precio de compra, precio de venta y cantidad deben ser numericos");
                error = true;
            }
            if (txtNombre.Text == "")
            {
                MessageBox.Show("el campo nombre no pueden estar vacio");
                error = true;
            }
            if (error == false)
            {
                producto.Nombre = txtNombre.Text;
                producto.Descripcion = txtDes.Text;
                producto.PCompra = txtPcompra.Text;
                producto.PVenta = txtPventa.Text;
                producto.Cantidad = txtCantidad.Text;

                logicaPrograma.guardarProducto(producto);

                adicionarDgv();
                limpiar();
                actualizarId();
            }
        }
        private void adicionarDgv()
        {
            int n = dgvProductos.Rows.Add();

            dgvProductos.Rows[n].Cells[0].Value = txtId.Text;
            dgvProductos.Rows[n].Cells[1].Value = txtNombre.Text;
            dgvProductos.Rows[n].Cells[2].Value = txtDes.Text;
            dgvProductos.Rows[n].Cells[3].Value = txtPcompra.Text;
            dgvProductos.Rows[n].Cells[4].Value = txtPventa.Text;
            dgvProductos.Rows[n].Cells[5].Value = txtCantidad.Text;
        }
        private void limpiar()
        {
                txtNombre.Text = "";
                txtDes.Text = "";
                txtPcompra.Text = "";
                txtPventa.Text = "";
                txtCantidad.Text = "";

                txtNombre.Focus();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            actualizarId();
        }
        public void actualizarId()
        {
            List<clsProducto> l = logicaPrograma.listarProducto();
            int indice = l.Count - 1;

            txtId.Text = l[indice].Id;
        }

        private void txtId_Click(object sender, EventArgs e)
        {
            actualizarId();
        }
    }
}
