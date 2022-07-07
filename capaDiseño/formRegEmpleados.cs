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
        
        public void button1_Click(object sender, EventArgs e)
        {

            registrarEmpleado();
            
        }
        public respuesta registrarEmpleado()
        {
            
            clsEmpleado empleado = new clsEmpleado();
            respuesta respuesta = new respuesta();
            bool error =  false;
            try
            {
                Convert.ToInt64(txtSalario.Text);
                Convert.ToInt64(txtCelular.Text);
            }
            catch (System.FormatException)
            {
                respuesta = new respuesta() { Code = 400, Message = "Campo salario y celular deben ser numericos" };
                MessageBox.Show(respuesta.Message);
                error = true;
                //return respuesta;
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
                empleado.Cedula = txtCedula.Text;
                empleado.PNombre = txtPnombre.Text;
                empleado.SNombre = txtSnombre.Text;
                empleado.PApellido = txtPapellido.Text;
                empleado.SApellido = txtSapellido.Text;
                empleado.Salario = txtSalario.Text;
                empleado.Celular = txtCelular.Text;

                logicaPrograma.guardarEmpleado(empleado);
                respuesta = new respuesta() { Code = 200, Message = "registro exitoso" };
                adicionarDgv();
                limpiar();
            }
            return respuesta;
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
            var cadena = txtCedula.Text;
            if (cadena.Length < 5)
            {
                MessageBox.Show("La cedula debe ser mayor a 4 numeros");
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
