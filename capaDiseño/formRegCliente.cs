using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using capaEntidades;
using capaLogica;

namespace capaDiseño
{
    public partial class formRegCliente : Form
    {
        public formRegCliente()
        {
            InitializeComponent();
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnRegEmpleado_Click(object sender, EventArgs e)
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
                MessageBox.Show("Los campos cedula, salario y celular deben ser numericos");
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
            if (error == false)
            {
                cliente.Cedula = txtCedula.Text;
                cliente.PNombre = txtPnombre.Text;
                cliente.SNombre = txtSnombre.Text;
                cliente.PApellido = txtPapellido.Text;
                cliente.SApellido = txtSapellido.Text;
                cliente.Direccion = txtDireccion.Text;
                cliente.Celular = txtCelular.Text;

                logicaPrograma.guardarCliente(cliente);

                adicionarDgv();
                limpiar();
            }

        }
        private void adicionarDgv()
        {
            int n = dgvListaClientes.Rows.Add();

            dgvListaClientes.Rows[n].Cells[0].Value = txtCedula.Text;
            dgvListaClientes.Rows[n].Cells[1].Value = txtPnombre.Text;
            dgvListaClientes.Rows[n].Cells[2].Value = txtSnombre.Text;
            dgvListaClientes.Rows[n].Cells[3].Value = txtPapellido.Text;
            dgvListaClientes.Rows[n].Cells[4].Value = txtSapellido.Text;
            dgvListaClientes.Rows[n].Cells[5].Value = txtDireccion.Text;
            dgvListaClientes.Rows[n].Cells[6].Value = txtCelular.Text;
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

            txtCedula.Focus();
        }

        private void txtPnombre_Click(object sender, EventArgs e)
        {
            bool error = false;

            try
            {
                Convert.ToInt64(txtCedula.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("El campo cedula debe ser numerico");
                txtCedula.Text = "";
                txtCedula.Focus();
                error = true;
            }
            if (!error)
            {
                DataTable tabla = logicaPrograma.buscarCliente(txtCedula.Text);
                if (tabla.Rows.Count != 0)
                {
                    MessageBox.Show("Este cliente ya existe");
                    txtCedula.Text = "";
                }
                else
                {
                    txtSnombre.Enabled = true;
                    txtPapellido.Enabled = true;
                    txtSapellido.Enabled = true;
                    txtDireccion.Enabled = true;
                    txtCelular.Enabled = true;
                }
            }
            
        }
    }
}
