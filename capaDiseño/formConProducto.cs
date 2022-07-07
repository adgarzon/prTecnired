using capaEntidades;
using capaLogica;
using System;
using System.Data;
using System.Windows.Forms;

namespace capaDiseño
{
    public partial class formConProducto : Form
    {
        public formConProducto()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            bool error = false;
            try
            {
                Convert.ToInt64(txtId.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("el Id debe ser numerico");
                error = true;
            }
            if (error == false)
            {
                DataTable tabla = logicaPrograma.buscarProducto(txtId.Text);
                if (tabla.Rows.Count != 0)
                {
                    dgvConsulta.DataSource = tabla;

                }
                else
                {
                    MessageBox.Show("No existe este producto");
                }
            }
            limpiar();
        }
        private void limpiar()
        {
            txtId.Text = "";
            txtDesc.Text = "";
            txtNombre.Text = "";
            txtCantidad.Text = "";
            txtPcompra.Text = "";
            txtPventa.Text = "";
        }
        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvConsulta.DataSource = logicaPrograma.listarProducto();
        }
        string id;
        private void dgvConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n != -1)
            {
                txtNombre.Text = Convert.ToString(dgvConsulta.Rows[n].Cells[1].Value);
                txtDesc.Text = Convert.ToString(dgvConsulta.Rows[n].Cells[2].Value);
                txtPcompra.Text = Convert.ToString(dgvConsulta.Rows[n].Cells[3].Value);
                txtPventa.Text = Convert.ToString(dgvConsulta.Rows[n].Cells[4].Value);
                txtCantidad.Text = Convert.ToString(dgvConsulta.Rows[n].Cells[5].Value);
                txtId.Text = Convert.ToString(dgvConsulta.Rows[n].Cells[0].Value);
                id = txtId.Text;
            }
            txtId.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }
        
        private void btnModificar_Click(object sender, EventArgs e)
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
            if (txtNombre.Text == "" ||
                txtPcompra.Text == "" ||
                txtPventa.Text == "" ||
                txtCantidad.Text == ""
                )
            {
                MessageBox.Show("Los campos nombre, precio de compra, precion de venta y cantidad no pueden estar vacios");
                error = true;
            }
            if (error == false) {
                if (Convert.ToInt64(txtPcompra.Text) < 0)
                {
                    MessageBox.Show("el campo precio de compra no puede ser menor a cero");
                    error = true;
                }
                else if (Convert.ToInt64(txtPventa.Text) < 0)
                {
                    MessageBox.Show("el campo precio de venta no puede ser menor a cero");
                    error = true;
                }
                else if (Convert.ToInt64(txtCantidad.Text) < 0)
                {
                    MessageBox.Show("el campo cantidad no puede ser menor a cero");
                    error = true;
                }
            }
            
            if (error == false)
            {
                producto.Id = txtId.Text;
                producto.Nombre = txtNombre.Text;
                producto.Descripcion = txtDesc.Text;
                producto.PCompra = txtPcompra.Text;
                producto.PVenta = txtPventa.Text;
                producto.Cantidad = txtCantidad.Text;

                bool res = logicaPrograma.modificarProducto(producto.Id, producto);
                limpiar();
                dgvConsulta.DataSource = logicaPrograma.listarProducto();
                txtId.Enabled = true;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            logicaPrograma.eliminarProducto(txtId.Text);
            MessageBox.Show("Producto eliminado");
            dgvConsulta.DataSource = logicaPrograma.listarProducto();
            limpiar();
            txtId.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }



        private void dgvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
