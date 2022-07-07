
namespace capaDiseño
{
    partial class formFactura
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvFactura = new System.Windows.Forms.DataGridView();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtVtotal = new System.Windows.Forms.TextBox();
            this.txtpCompra = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnVender = new System.Windows.Forms.Button();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.btnBuscarEmpleado = new System.Windows.Forms.Button();
            this.txtCodProducto = new System.Windows.Forms.TextBox();
            this.txtCedCliente = new System.Windows.Forms.TextBox();
            this.txtCedEmpleado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnCalcular);
            this.panel1.Controls.Add(this.txtEmpleado);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.dgvFactura);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txtVtotal);
            this.panel1.Controls.Add(this.txtpCompra);
            this.panel1.Controls.Add(this.txtCantidad);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.txtProducto);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.dtFecha);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnVender);
            this.panel1.Controls.Add(this.txtCelular);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnBuscarCliente);
            this.panel1.Controls.Add(this.btnBuscarProducto);
            this.panel1.Controls.Add(this.btnBuscarEmpleado);
            this.panel1.Controls.Add(this.txtCodProducto);
            this.panel1.Controls.Add(this.txtCedCliente);
            this.panel1.Controls.Add(this.txtCedEmpleado);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1150, 788);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(600, 447);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 38);
            this.btnEliminar.TabIndex = 64;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(733, 407);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 63;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Enabled = false;
            this.txtEmpleado.Location = new System.Drawing.Point(609, 59);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(267, 23);
            this.txtEmpleado.TabIndex = 62;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(481, 62);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(120, 15);
            this.label16.TabIndex = 61;
            this.label16.Text = "NOMBRE EMPLEADO";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(493, 447);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(86, 38);
            this.btnAgregar.TabIndex = 60;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvFactura
            // 
            this.dgvFactura.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cantidad,
            this.producto,
            this.descripcion,
            this.vUnitario,
            this.subtotal});
            this.dgvFactura.Location = new System.Drawing.Point(324, 491);
            this.dgvFactura.Name = "dgvFactura";
            this.dgvFactura.RowTemplate.Height = 25;
            this.dgvFactura.Size = new System.Drawing.Size(542, 285);
            this.dgvFactura.TabIndex = 59;
            this.dgvFactura.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFactura_CellClick);
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "CANTIDAD";
            this.cantidad.Name = "cantidad";
            // 
            // producto
            // 
            this.producto.HeaderText = "PRODUCTO";
            this.producto.Name = "producto";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "DESCRIPCION";
            this.descripcion.Name = "descripcion";
            // 
            // vUnitario
            // 
            this.vUnitario.HeaderText = "VALOR UNITARIO";
            this.vUnitario.Name = "vUnitario";
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "SUBTOTAL";
            this.subtotal.Name = "subtotal";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(924, 339);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(108, 23);
            this.txtTotal.TabIndex = 58;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(933, 309);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 15);
            this.label15.TabIndex = 57;
            this.label15.Text = "TOTAL A PAGAR";
            // 
            // txtVtotal
            // 
            this.txtVtotal.Enabled = false;
            this.txtVtotal.Location = new System.Drawing.Point(619, 407);
            this.txtVtotal.Name = "txtVtotal";
            this.txtVtotal.Size = new System.Drawing.Size(108, 23);
            this.txtVtotal.TabIndex = 56;
            // 
            // txtpCompra
            // 
            this.txtpCompra.Enabled = false;
            this.txtpCompra.Location = new System.Drawing.Point(619, 377);
            this.txtpCompra.Name = "txtpCompra";
            this.txtpCompra.Size = new System.Drawing.Size(108, 23);
            this.txtpCompra.TabIndex = 55;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(619, 344);
            this.txtCantidad.MaxLength = 3;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(53, 23);
            this.txtCantidad.TabIndex = 54;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(619, 309);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(173, 23);
            this.txtDescripcion.TabIndex = 53;
            // 
            // txtProducto
            // 
            this.txtProducto.Enabled = false;
            this.txtProducto.Location = new System.Drawing.Point(619, 273);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(173, 23);
            this.txtProducto.TabIndex = 52;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(481, 407);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 15);
            this.label14.TabIndex = 51;
            this.label14.Text = "VALOR TOTAL";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(481, 347);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 15);
            this.label13.TabIndex = 50;
            this.label13.Text = "CANTIDAD";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(481, 377);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 15);
            this.label12.TabIndex = 49;
            this.label12.Text = "VALOR UNITARIO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(481, 317);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 15);
            this.label11.TabIndex = 48;
            this.label11.Text = "DESCRIPCION";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(481, 282);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 15);
            this.label10.TabIndex = 47;
            this.label10.Text = "NOMBRE PRODUCTO";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // dtFecha
            // 
            this.dtFecha.Enabled = false;
            this.dtFecha.Location = new System.Drawing.Point(609, 219);
            this.dtFecha.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtFecha.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(221, 23);
            this.dtFecha.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(481, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 15);
            this.label9.TabIndex = 45;
            this.label9.Text = "FECHA";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(933, 174);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 29);
            this.btnCancelar.TabIndex = 44;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(910, 121);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(132, 41);
            this.btnVender.TabIndex = 43;
            this.btnVender.Text = "REALIZAR FACTURA";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // txtCelular
            // 
            this.txtCelular.Enabled = false;
            this.txtCelular.Location = new System.Drawing.Point(609, 174);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(267, 23);
            this.txtCelular.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(481, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 15);
            this.label8.TabIndex = 40;
            this.label8.Text = "CELULAR";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Location = new System.Drawing.Point(609, 131);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(267, 23);
            this.txtDireccion.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(481, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 15);
            this.label7.TabIndex = 38;
            this.label7.Text = "DIRECCION CLIENTE";
            // 
            // txtCodigo
            // 
            this.txtCodigo.AutoSize = true;
            this.txtCodigo.Location = new System.Drawing.Point(1044, 95);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(0, 15);
            this.txtCodigo.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(910, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 15);
            this.label6.TabIndex = 36;
            this.label6.Text = "CODIGO DE FACTURA";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(609, 92);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(267, 23);
            this.txtNombre.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(481, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 15);
            this.label5.TabIndex = 34;
            this.label5.Text = "NOMBRE CLIENTE";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuscarCliente.Location = new System.Drawing.Point(312, 118);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(78, 25);
            this.btnBuscarCliente.TabIndex = 33;
            this.btnBuscarCliente.Text = "BUSCAR";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuscarProducto.Location = new System.Drawing.Point(312, 185);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(78, 25);
            this.btnBuscarProducto.TabIndex = 32;
            this.btnBuscarProducto.Text = "BUSCAR";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // btnBuscarEmpleado
            // 
            this.btnBuscarEmpleado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuscarEmpleado.Location = new System.Drawing.Point(312, 56);
            this.btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            this.btnBuscarEmpleado.Size = new System.Drawing.Size(78, 25);
            this.btnBuscarEmpleado.TabIndex = 31;
            this.btnBuscarEmpleado.Text = "BUSCAR";
            this.btnBuscarEmpleado.UseVisualStyleBackColor = true;
            this.btnBuscarEmpleado.Click += new System.EventHandler(this.btnBuscarEmpleado_Click);
            // 
            // txtCodProducto
            // 
            this.txtCodProducto.Location = new System.Drawing.Point(152, 185);
            this.txtCodProducto.MaxLength = 5;
            this.txtCodProducto.Name = "txtCodProducto";
            this.txtCodProducto.Size = new System.Drawing.Size(154, 23);
            this.txtCodProducto.TabIndex = 9;
            this.txtCodProducto.TextChanged += new System.EventHandler(this.txtCodProducto_TextChanged);
            this.txtCodProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodProducto_KeyPress);
            // 
            // txtCedCliente
            // 
            this.txtCedCliente.Location = new System.Drawing.Point(152, 118);
            this.txtCedCliente.MaxLength = 10;
            this.txtCedCliente.Name = "txtCedCliente";
            this.txtCedCliente.Size = new System.Drawing.Size(154, 23);
            this.txtCedCliente.TabIndex = 8;
            this.txtCedCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedCliente_KeyPress);
            // 
            // txtCedEmpleado
            // 
            this.txtCedEmpleado.Location = new System.Drawing.Point(152, 56);
            this.txtCedEmpleado.MaxLength = 10;
            this.txtCedEmpleado.Name = "txtCedEmpleado";
            this.txtCedEmpleado.Size = new System.Drawing.Size(154, 23);
            this.txtCedEmpleado.TabIndex = 7;
            this.txtCedEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedEmpleado_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "CODIGO DEL PRODUCTO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "CEDULA CLIENTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "CEDULA EMPLEADO";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(444, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "FACTURA DE VENTA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // formFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 788);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formFactura";
            this.Text = "formFactura";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodProducto;
        private System.Windows.Forms.TextBox txtCedCliente;
        private System.Windows.Forms.TextBox txtCedEmpleado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtCodigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Button btnBuscarEmpleado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtVtotal;
        private System.Windows.Forms.TextBox txtpCompra;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvFactura;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn vUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.Button btnEliminar;
    }
}