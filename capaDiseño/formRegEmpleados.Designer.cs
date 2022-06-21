
namespace capaDiseño
{
    partial class formRegEmpleados
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
            this.label9 = new System.Windows.Forms.Label();
            this.dgvListaEmpleados = new System.Windows.Forms.DataGridView();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCanEmpleado = new System.Windows.Forms.Button();
            this.btnRegEmpleado = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.dgvListaEmpleados);
            this.panel1.Controls.Add(this.btnCanEmpleado);
            this.panel1.Controls.Add(this.btnRegEmpleado);
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
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(792, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Agregados recientemente";
            // 
            // dgvListaEmpleados
            // 
            this.dgvListaEmpleados.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvListaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cedula,
            this.pNombre,
            this.sNombre,
            this.pApellido,
            this.sApellido,
            this.salario,
            this.celular});
            this.dgvListaEmpleados.Location = new System.Drawing.Point(564, 116);
            this.dgvListaEmpleados.Name = "dgvListaEmpleados";
            this.dgvListaEmpleados.RowTemplate.Height = 25;
            this.dgvListaEmpleados.Size = new System.Drawing.Size(561, 375);
            this.dgvListaEmpleados.TabIndex = 17;
            // 
            // Cedula
            // 
            this.Cedula.HeaderText = "Cedula";
            this.Cedula.Name = "Cedula";
            // 
            // pNombre
            // 
            this.pNombre.HeaderText = "Primer nombre";
            this.pNombre.Name = "pNombre";
            // 
            // sNombre
            // 
            this.sNombre.HeaderText = "Segundo Nombre";
            this.sNombre.Name = "sNombre";
            // 
            // pApellido
            // 
            this.pApellido.HeaderText = "Primer Apellido";
            this.pApellido.Name = "pApellido";
            // 
            // sApellido
            // 
            this.sApellido.HeaderText = "Segundo Apellido";
            this.sApellido.Name = "sApellido";
            // 
            // salario
            // 
            this.salario.HeaderText = "Salario";
            this.salario.Name = "salario";
            // 
            // celular
            // 
            this.celular.HeaderText = "Celular";
            this.celular.Name = "celular";
            // 
            // btnCanEmpleado
            // 
            this.btnCanEmpleado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCanEmpleado.Location = new System.Drawing.Point(430, 272);
            this.btnCanEmpleado.Name = "btnCanEmpleado";
            this.btnCanEmpleado.Size = new System.Drawing.Size(117, 48);
            this.btnCanEmpleado.TabIndex = 16;
            this.btnCanEmpleado.Text = "CANCELAR";
            this.btnCanEmpleado.UseVisualStyleBackColor = true;
            // 
            // btnRegEmpleado
            // 
            this.btnRegEmpleado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegEmpleado.Location = new System.Drawing.Point(430, 196);
            this.btnRegEmpleado.Name = "btnRegEmpleado";
            this.btnRegEmpleado.Size = new System.Drawing.Size(117, 48);
            this.btnRegEmpleado.TabIndex = 15;
            this.btnRegEmpleado.Text = "REGISTRAR";
            this.btnRegEmpleado.UseVisualStyleBackColor = true;
            this.btnRegEmpleado.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPnombre
            // 
            this.txtPnombre.Location = new System.Drawing.Point(233, 151);
            this.txtPnombre.Name = "txtPnombre";
            this.txtPnombre.Size = new System.Drawing.Size(164, 23);
            this.txtPnombre.TabIndex = 14;
            this.txtPnombre.Click += new System.EventHandler(this.txtPnombre_Click);
            // 
            // txtSnombre
            // 
            this.txtSnombre.Enabled = false;
            this.txtSnombre.Location = new System.Drawing.Point(233, 196);
            this.txtSnombre.Name = "txtSnombre";
            this.txtSnombre.Size = new System.Drawing.Size(164, 23);
            this.txtSnombre.TabIndex = 13;
            // 
            // txtPapellido
            // 
            this.txtPapellido.Enabled = false;
            this.txtPapellido.Location = new System.Drawing.Point(233, 239);
            this.txtPapellido.Name = "txtPapellido";
            this.txtPapellido.Size = new System.Drawing.Size(164, 23);
            this.txtPapellido.TabIndex = 12;
            this.txtPapellido.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtSapellido
            // 
            this.txtSapellido.Enabled = false;
            this.txtSapellido.Location = new System.Drawing.Point(233, 282);
            this.txtSapellido.Name = "txtSapellido";
            this.txtSapellido.Size = new System.Drawing.Size(164, 23);
            this.txtSapellido.TabIndex = 11;
            // 
            // txtCelular
            // 
            this.txtCelular.Enabled = false;
            this.txtCelular.Location = new System.Drawing.Point(233, 327);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(164, 23);
            this.txtCelular.TabIndex = 10;
            // 
            // txtSalario
            // 
            this.txtSalario.Enabled = false;
            this.txtSalario.Location = new System.Drawing.Point(233, 372);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(164, 23);
            this.txtSalario.TabIndex = 9;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(233, 113);
            this.txtCedula.MaxLength = 10;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(164, 23);
            this.txtCedula.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(92, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "SEGUNDO NOMBRE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(89, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "PRIMER APELLIDO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "SEGUNDO APELLIDO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "SALARIO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "CELULAR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "PRIMER NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "CEDULA";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(386, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRAR UN EMPLEADO";
            // 
            // formRegEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 519);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formRegEmpleados";
            this.Text = "formRegEmpleados";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegEmpleado;
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvListaEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn pApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn sApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn salario;
        private System.Windows.Forms.DataGridViewTextBoxColumn celular;
    }
}