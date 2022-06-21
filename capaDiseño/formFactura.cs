using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using capaEntidades;
using capaLogica;
using System.Collections;

namespace capaDiseño
{
    public partial class formFactura : Form
    {
        public formFactura()
        {
            InitializeComponent();
            actualizarCodigo();
            txtTotal.Text = "0";
            txtCantidad.Text = "0";
            txtVtotal.Text = "0";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            DataTable tabla = logicaPrograma.buscarEmpleado(txtCedEmpleado.Text);
            if (tabla.Rows.Count != 0)
            {
                txtEmpleado.Text = Convert.ToString(tabla.Rows[0][1] + " " + tabla.Rows[0][2] + " " + tabla.Rows[0][3] + " " + tabla.Rows[0][4]);
                
            }
            else
            {
                MessageBox.Show("No existe este empleado");
            }
        }

        private void txtCedEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("debe ser numerico");
                txtCedEmpleado.Text = "";
                e.Handled = true;
            }
        }
        private void limpiar()
        {
            txtCedEmpleado.Text = "";
            txtCedCliente.Text = "";
            txtCodProducto.Text = "";
            txtEmpleado.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtCelular.Text = "";
            txtProducto.Text = "";
            txtDescripcion.Text = "";
            txtCantidad.Text = "";
            txtpCompra.Text = "";
            txtVtotal.Text = "";
            txtTotal.Text = "";
            dgvFactura.Rows.Clear();

        }

        private void txtCedCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("debe ser numerico");
                txtCedEmpleado.Text = "";
                e.Handled = true;
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            DataTable tabla = logicaPrograma.buscarCliente(txtCedCliente.Text);
            if (tabla.Rows.Count != 0)
            {
                txtNombre.Text = Convert.ToString(tabla.Rows[0][1] + " " + tabla.Rows[0][2] + " " + tabla.Rows[0][3] + " " + tabla.Rows[0][4]);
                txtDireccion.Text = Convert.ToString(tabla.Rows[0][5]);
                txtCelular.Text = Convert.ToString(tabla.Rows[0][6]);
            }
            else
            {
                MessageBox.Show("No existe este cliente");
            }
        }

        private void txtCodProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("debe ser numerico");
                txtCedEmpleado.Text = "";
                e.Handled = true;
            }
        }
        ArrayList productoId = new ArrayList();
        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            DataTable tabla = logicaPrograma.buscarProducto(txtCodProducto.Text);
            productoId.Add(txtCodProducto.Text);
            if (tabla.Rows.Count != 0)
            {
                txtProducto.Text = Convert.ToString(tabla.Rows[0][1]);
                txtDescripcion.Text = Convert.ToString(tabla.Rows[0][2]);
                txtpCompra.Text = Convert.ToString(tabla.Rows[0][3]);
            }
            else
            {
                MessageBox.Show("No existe este producto");
            }
        }
        private void calcularSubtotal()
        {
            double subtotal = Convert.ToDouble(txtCantidad.Text) * Convert.ToDouble(txtpCompra.Text);
            txtVtotal.Text = subtotal.ToString();
        }
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("debe ser numerico");
                txtCedEmpleado.Text = "";
                e.Handled = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            adicionarDgv();
            calcularTotal();

            txtProducto.Text = "";
            txtDescripcion.Text = "";
            txtCantidad.Text = "";
            txtpCompra.Text = "";
            txtVtotal.Text = "";
        }
        private void calcularTotal()
        {
            double total = Convert.ToDouble(txtVtotal.Text) + Convert.ToDouble(txtTotal.Text);
            txtTotal.Text = total.ToString();
        }
        private void adicionarDgv()
        {
            int n = dgvFactura.Rows.Add();

            dgvFactura.Rows[n].Cells[0].Value = txtCantidad.Text;
            dgvFactura.Rows[n].Cells[1].Value = txtProducto.Text;
            dgvFactura.Rows[n].Cells[2].Value = txtDescripcion.Text;
            dgvFactura.Rows[n].Cells[3].Value = txtpCompra.Text;
            dgvFactura.Rows[n].Cells[4].Value = txtVtotal.Text;
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            calcularSubtotal();
        }
        public void actualizarCodigo()
        {
            List<clsFactura> l = logicaPrograma.listarFactura();
            int indice = l.Count - 1;

            txtCodigo.Text = l[indice].Codigo;
        }

        private void dgvFactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n != -1)
            {
                txtCantidad.Text = Convert.ToString(dgvFactura.Rows[n].Cells[1].Value);
                txtProducto.Text = Convert.ToString(dgvFactura.Rows[n].Cells[2].Value);
                txtDescripcion.Text = Convert.ToString(dgvFactura.Rows[n].Cells[3].Value);
                txtpCompra.Text = Convert.ToString(dgvFactura.Rows[n].Cells[4].Value);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dgvFactura.Rows.Remove(dgvFactura.CurrentRow);
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            clsFactura f = new clsFactura();

            
            f.Fecha = dtFecha.Text;
            f.Cliente = txtCedCliente.Text;
            f.Empleado = txtCedEmpleado.Text;
            f.Total = txtTotal.Text;

            logicaPrograma.guardarFactura(f);
            actualizarCodigo();
            limpiar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
