
namespace capaDiseño
{
    partial class formConEmpleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCanEmpleado = new System.Windows.Forms.Button();
            this.btnEliminarEmpleado = new System.Windows.Forms.Button();
            this.btnModEmpleado = new System.Windows.Forms.Button();
            this.btnListarEmpleados = new System.Windows.Forms.Button();
            this.btnBuscarEmpleado = new System.Windows.Forms.Button();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.txtPnombre = new System.Windows.Forms.TextBox();
            this.txtSnombre = new System.Windows.Forms.TextBox();
            this.txtPapellido = new System.Windows.Forms.TextBox();
            this.txtSapellido = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.btnCanEmpleado);
            this.panel1.Controls.Add(this.btnEliminarEmpleado);
            this.panel1.Controls.Add(this.btnModEmpleado);
            this.panel1.Controls.Add(this.btnListarEmpleados);
            this.panel1.Controls.Add(this.btnBuscarEmpleado);
            this.panel1.Controls.Add(this.dgvConsulta);
            this.panel1.Controls.Add(this.txtPnombre);
            this.panel1.Controls.Add(this.txtSnombre);
            this.panel1.Controls.Add(this.txtPapellido);
            this.panel1.Controls.Add(this.txtSapellido);
            this.panel1.Controls.Add(this.txtCelular);
            this.panel1.Controls.Add(this.txtSalario);
            this.panel1.Controls.Add(this.txtCedula);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1150, 519);
            this.panel1.TabIndex = 0;
            // 
            // btnCanEmpleado
            // 
            this.btnCanEmpleado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCanEmpleado.Location = new System.Drawing.Point(1020, 379);
            this.btnCanEmpleado.Name = "btnCanEmpleado";
            this.btnCanEmpleado.Size = new System.Drawing.Size(117, 48);
            this.btnCanEmpleado.TabIndex = 34;
            this.btnCanEmpleado.Text = "CANCELAR";
            this.btnCanEmpleado.UseVisualStyleBackColor = true;
            this.btnCanEmpleado.Click += new System.EventHandler(this.btnCanEmpleado_Click);
            // 
            // btnEliminarEmpleado
            // 
            this.btnEliminarEmpleado.Enabled = false;
            this.btnEliminarEmpleado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarEmpleado.Location = new System.Drawing.Point(1020, 319);
            this.btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            this.btnEliminarEmpleado.Size = new System.Drawing.Size(117, 48);
            this.btnEliminarEmpleado.TabIndex = 33;
            this.btnEliminarEmpleado.Text = "ELIMINAR";
            this.btnEliminarEmpleado.UseVisualStyleBackColor = true;
            this.btnEliminarEmpleado.Click += new System.EventHandler(this.btnEliminarEmpleado_Click);
            // 
            // btnModEmpleado
            // 
            this.btnModEmpleado.Enabled = false;
            this.btnModEmpleado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModEmpleado.Location = new System.Drawing.Point(1020, 256);
            this.btnModEmpleado.Name = "btnModEmpleado";
            this.btnModEmpleado.Size = new System.Drawing.Size(117, 48);
            this.btnModEmpleado.TabIndex = 32;
            this.btnModEmpleado.Text = "MODIFICAR";
            this.btnModEmpleado.UseVisualStyleBackColor = true;
            this.btnModEmpleado.Click += new System.EventHandler(this.btnModEmpleado_Click);
            // 
            // btnListarEmpleados
            // 
            this.btnListarEmpleados.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListarEmpleados.Location = new System.Drawing.Point(184, 125);
            this.btnListarEmpleados.Name = "btnListarEmpleados";
            this.btnListarEmpleados.Size = new System.Drawing.Size(217, 48);
            this.btnListarEmpleados.TabIndex = 31;
            this.btnListarEmpleados.Text = "CONSULTAR TODOS";
            this.btnListarEmpleados.UseVisualStyleBackColor = true;
            this.btnListarEmpleados.Click += new System.EventHandler(this.btnListarEmpleados_Click);
            // 
            // btnBuscarEmpleado
            // 
            this.btnBuscarEmpleado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuscarEmpleado.Location = new System.Drawing.Point(41, 125);
            this.btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            this.btnBuscarEmpleado.Size = new System.Drawing.Size(117, 48);
            this.btnBuscarEmpleado.TabIndex = 30;
            this.btnBuscarEmpleado.Text = "BUSCAR";
            this.btnBuscarEmpleado.UseVisualStyleBackColor = true;
            this.btnBuscarEmpleado.Click += new System.EventHandler(this.btnBuscarEmpleado_Click);
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Location = new System.Drawing.Point(41, 188);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.RowTemplate.Height = 25;
            this.dgvConsulta.Size = new System.Drawing.Size(631, 319);
            this.dgvConsulta.TabIndex = 29;
            this.dgvConsulta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsulta_CellClick);
            // 
            // txtPnombre
            // 
            this.txtPnombre.Location = new System.Drawing.Point(829, 213);
            this.txtPnombre.MaxLength = 10;
            this.txtPnombre.Name = "txtPnombre";
            this.txtPnombre.Size = new System.Drawing.Size(164, 23);
            this.txtPnombre.TabIndex = 28;
            // 
            // txtSnombre
            // 
            this.txtSnombre.Location = new System.Drawing.Point(829, 258);
            this.txtSnombre.MaxLength = 10;
            this.txtSnombre.Name = "txtSnombre";
            this.txtSnombre.Size = new System.Drawing.Size(164, 23);
            this.txtSnombre.TabIndex = 27;
            // 
            // txtPapellido
            // 
            this.txtPapellido.Location = new System.Drawing.Point(829, 301);
            this.txtPapellido.MaxLength = 10;
            this.txtPapellido.Name = "txtPapellido";
            this.txtPapellido.Size = new System.Drawing.Size(164, 23);
            this.txtPapellido.TabIndex = 26;
            // 
            // txtSapellido
            // 
            this.txtSapellido.Location = new System.Drawing.Point(829, 344);
            this.txtSapellido.MaxLength = 10;
            this.txtSapellido.Name = "txtSapellido";
            this.txtSapellido.Size = new System.Drawing.Size(164, 23);
            this.txtSapellido.TabIndex = 25;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(829, 389);
            this.txtCelular.MaxLength = 10;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(164, 23);
            this.txtCelular.TabIndex = 24;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(829, 434);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(164, 23);
            this.txtSalario.TabIndex = 23;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(123, 90);
            this.txtCedula.MaxLength = 10;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(178, 23);
            this.txtCedula.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(688, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "SEGUNDO NOMBRE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(685, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "PRIMER APELLIDO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(684, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "SEGUNDO APELLIDO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(685, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "SALARIO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(688, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "CELULAR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(688, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "PRIMER NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "CEDULA";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(418, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "CONSULTAR UN EMPLEADO";
            // 
            // formConEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 519);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formConEmpleados";
            this.Text = "formConEmpleados";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.TextBox txtPnombre;
        private System.Windows.Forms.TextBox txtSnombre;
        private System.Windows.Forms.TextBox txtPapellido;
        private System.Windows.Forms.TextBox txtSapellido;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCanEmpleado;
        private System.Windows.Forms.Button btnEliminarEmpleado;
        private System.Windows.Forms.Button btnModEmpleado;
        private System.Windows.Forms.Button btnListarEmpleados;
        private System.Windows.Forms.Button btnBuscarEmpleado;
    }
}