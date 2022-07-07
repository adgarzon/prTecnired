using capaEntidades;
using capaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace capaDiseño
{
    public partial class formConCliente : Form
    {
        public formConCliente()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            bool error = false;
            try
            {
                Convert.ToInt64(txtCedula.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("la cedula debe ser valor numerico");
                error = true;
            }
            var cadena = txtCedula.Text;
            if (cadena.Length < 5)
            {
                MessageBox.Show("La cedula debe ser mayor a 4 numeros");
                error = true;
            }
            if (error == false)
            {
                DataTable tabla = logicaPrograma.buscarCliente(txtCedula.Text);
                if (tabla.Rows.Count != 0)
                {
                    dgvConsulta.DataSource = tabla;

                }
                else
                {
                    MessageBox.Show("No existe este cliente");
                }
            }

            limpiar();
        }
        private void limpiar()
        {
            txtCedula.Text = "";
            txtPnombre.Text = "";
            txtSnombre.Text = "";
            txtPapellido.Text = "";
            txtSapellido.Text = "";
            txtDireccion.Text = "";
            txtCelular.Text = "";

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvConsulta.DataSource = logicaPrograma.listarCliente();
        }

        private void dgvConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n != -1)
            {
                txtCedula.Text = Convert.ToString(dgvConsulta.Rows[n].Cells[0].Value);
                txtPnombre.Text = Convert.ToString(dgvConsulta.Rows[n].Cells[1].Value);
                txtSnombre.Text = Convert.ToString(dgvConsulta.Rows[n].Cells[2].Value);
                txtPapellido.Text = Convert.ToString(dgvConsulta.Rows[n].Cells[3].Value);
                txtSapellido.Text = Convert.ToString(dgvConsulta.Rows[n].Cells[4].Value);
                txtDireccion.Text = Convert.ToString(dgvConsulta.Rows[n].Cells[5].Value);
                txtCelular.Text = Convert.ToString(dgvConsulta.Rows[n].Cells[6].Value);
            }
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            txtCedula.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            txtCedula.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            clsCliente cliente = new clsCliente();
            bool error = false;
            try
            {
                Convert.ToInt64(txtCedula.Text);
                Convert.ToInt64(txtCelular.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("El campo celular debe ser numerico");
                error = true;
            }
            if (txtPnombre.Text == "" ||
                txtPapellido.Text == "" ||
                txtSapellido.Text == ""
                )
            {
                MessageBox.Show("Los campos primer nombre, primer apellido y segundo apellido no pueden estar vacios");
                error = true;
            }
            var cad = txtCelular.Text;
            var error2 = false;
            if (cad.Length < 7)
            {
                error2 = true;
                if (cad.Length == 0) { error2 = false; }
            }
            if (error2 == true)
            {
                MessageBox.Show("El campo celular debe ser mayor a 6 numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }
            if (error == false)
            {
                cliente.Cedula = txtCedula.Text;
                cliente.PNombre = txtPnombre.Text;
                cliente.SNombre = txtSnombre.Text;
                cliente.PApellido = txtPapellido.Text;
                cliente.SApellido = txtSapellido.Text;
                cliente.Direccion = txtDireccion.Text;
                cliente.Celular = txtCelular.Text;

                bool res = logicaPrograma.modificarCliente(cliente);
                limpiar();
                dgvConsulta.DataSource = logicaPrograma.listarCliente();
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                txtCedula.Enabled = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            logicaPrograma.eliminarCliente(txtCedula.Text);
            MessageBox.Show("Cliente eliminado");
            dgvConsulta.DataSource = logicaPrograma.listarCliente();
            limpiar();
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            txtCedula.Enabled = true;
        }
    }
}
