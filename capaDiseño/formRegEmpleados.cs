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
    public partial class formRegEmpleados : Form
    {
        public formRegEmpleados()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            clsEmpleado empleado = new clsEmpleado();
            bool error = false;
            try
            {
                Convert.ToInt64(txtSalario.Text);
                Convert.ToInt64(txtCelular.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Los salario y celular deben ser numericos");
                error = true;
            }
            if (txtPnombre.Text == "" || 
                txtPapellido.Text=="" ||
                txtSapellido.Text==""
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

                logicaPrograma.guardarEmpleado(empleado);

                adicionarDgv();
                limpiar();
            }
            
            
        }
        private void adicionarDgv()
        {
            int n = dgvListaEmpleados.Rows.Add();

            dgvListaEmpleados.Rows[n].Cells[0].Value = txtCedula.Text;
            dgvListaEmpleados.Rows[n].Cells[1].Value = txtPnombre.Text;
            dgvListaEmpleados.Rows[n].Cells[2].Value = txtSnombre.Text;
            dgvListaEmpleados.Rows[n].Cells[3].Value = txtPapellido.Text;
            dgvListaEmpleados.Rows[n].Cells[4].Value = txtSapellido.Text;
            dgvListaEmpleados.Rows[n].Cells[5].Value = txtSalario.Text;
            dgvListaEmpleados.Rows[n].Cells[6].Value = txtCelular.Text;
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

            txtCedula.Focus();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

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
                DataTable tabla = logicaPrograma.buscarEmpleado(txtCedula.Text);
                if (tabla.Rows.Count != 0)
                {
                    MessageBox.Show("Este empleado ya existe");
                    txtCedula.Text = "";
                }
                else
                {
                    txtSnombre.Enabled = true;
                    txtPapellido.Enabled = true;
                    txtSapellido.Enabled = true;
                    txtSalario.Enabled = true;
                    txtCelular.Enabled = true;
                }
            }
            
        }
    }
}
