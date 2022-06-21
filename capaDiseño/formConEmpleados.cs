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
    public partial class formConEmpleados : Form
    {
        public formConEmpleados()
        {
            InitializeComponent();
        }

        private void btnListarEmpleados_Click(object sender, EventArgs e)
        {
            dgvConsulta.DataSource = logicaPrograma.listarEmpleado();
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            bool error = false;
            try {
                Convert.ToInt64(txtCedula.Text);
            }catch(System.FormatException)
            {
                MessageBox.Show("la cedula debe ser valor numerico");
                error = true;
            }
            if (error == false)
            {
                DataTable tabla = logicaPrograma.buscarEmpleado(txtCedula.Text);
                if (tabla.Rows.Count != 0)
                {
                    dgvConsulta.DataSource = tabla;

                }
                else
                {
                    MessageBox.Show("No existe este empleado");
                }
            }
            
            limpiar();
        }

        private void dgvConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if(n != -1)
            {
                txtCedula.Text = Convert.ToString(dgvConsulta.Rows[n].Cells[0].Value);
                txtPnombre.Text = Convert.ToString(dgvConsulta.Rows[n].Cells[1].Value);
                txtSnombre.Text = Convert.ToString(dgvConsulta.Rows[n].Cells[2].Value);
                txtPapellido.Text = Convert.ToString(dgvConsulta.Rows[n].Cells[3].Value);
                txtSapellido.Text = Convert.ToString(dgvConsulta.Rows[n].Cells[4].Value);
                txtSalario.Text = Convert.ToString(dgvConsulta.Rows[n].Cells[5].Value);
                txtCelular.Text = Convert.ToString(dgvConsulta.Rows[n].Cells[6].Value);
            }
            btnModEmpleado.Enabled = true;
            btnEliminarEmpleado.Enabled = true;
            txtCedula.Enabled = false;
        }
        private void limpiar()
        {
            txtCedula.Text = "";
            txtPnombre.Text = "";
            txtSnombre.Text = "";
            txtPapellido.Text = "";
            txtSapellido.Text = "";
            txtSalario.Text = "";
            txtCelular.Text = "";

        }
        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            logicaPrograma.eliminarEmpleado(txtCedula.Text);
            MessageBox.Show("Empleado eliminado");
            dgvConsulta.DataSource = logicaPrograma.listarEmpleado();
            limpiar();
            btnEliminarEmpleado.Enabled = false;
            btnModEmpleado.Enabled = false;
            txtCedula.Enabled = true;
        }

        private void btnModEmpleado_Click(object sender, EventArgs e)
        {
            clsEmpleado empleado = new clsEmpleado();
            bool error = false;
            try
            {
                Convert.ToInt64(txtCedula.Text);
                Convert.ToInt64(txtSalario.Text);
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
                empleado.Cedula = txtCedula.Text;
                empleado.PNombre = txtPnombre.Text;
                empleado.SNombre = txtSnombre.Text;
                empleado.PApellido = txtPapellido.Text;
                empleado.SApellido = txtSapellido.Text;
                empleado.Salario = txtSalario.Text;
                empleado.Celular = txtCelular.Text;

                bool res = logicaPrograma.modificarEmpleado(empleado);
                limpiar();
                dgvConsulta.DataSource = logicaPrograma.listarEmpleado();
                btnModEmpleado.Enabled = false;
                btnEliminarEmpleado.Enabled = false;
                txtCedula.Enabled = true;
            }
        }

        private void btnCanEmpleado_Click(object sender, EventArgs e)
        {
            limpiar();
            txtCedula.Enabled = true;
            btnModEmpleado.Enabled = false;
            btnEliminarEmpleado.Enabled = false;
        }
    }
}
