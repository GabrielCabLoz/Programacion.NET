namespace Practica_examen2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbProductos = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            chkParaLlevar = new CheckBox();
            dvgPedidos = new DataGridView();
            txtPrecio = new TextBox();
            lblTotal = new Label();
            label5 = new Label();
            nudCantidad = new NumericUpDown();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnVaciar = new Button();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dvgPedidos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // cmbProductos
            // 
            cmbProductos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProductos.FormattingEnabled = true;
            cmbProductos.Location = new Point(133, 12);
            cmbProductos.Name = "cmbProductos";
            cmbProductos.Size = new Size(151, 28);
            cmbProductos.TabIndex = 0;
            cmbProductos.SelectedIndexChanged += cmbProductos_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 20);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 1;
            label1.Text = "Producto";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 165);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 2;
            label2.Text = "Cantidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 82);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 3;
            label3.Text = "Precio unitario";
            // 
            // chkParaLlevar
            // 
            chkParaLlevar.AutoSize = true;
            chkParaLlevar.Location = new Point(8, 234);
            chkParaLlevar.Name = "chkParaLlevar";
            chkParaLlevar.Size = new Size(214, 24);
            chkParaLlevar.TabIndex = 4;
            chkParaLlevar.Text = "Para llevar(+$5 por pedido)";
            chkParaLlevar.UseVisualStyleBackColor = true;
            // 
            // dvgPedidos
            // 
            dvgPedidos.AccessibleRole = AccessibleRole.RowHeader;
            dvgPedidos.AllowUserToAddRows = false;
            dvgPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgPedidos.Location = new Point(418, 57);
            dvgPedidos.Name = "dvgPedidos";
            dvgPedidos.ReadOnly = true;
            dvgPedidos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dvgPedidos.RowHeadersWidth = 51;
            dvgPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgPedidos.Size = new Size(503, 198);
            dvgPedidos.TabIndex = 5;
            dvgPedidos.CellContentClick += dgvPedidos_CellContentClick;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(132, 75);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.ReadOnly = true;
            txtPrecio.Size = new Size(151, 27);
            txtPrecio.TabIndex = 6;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(760, 272);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(49, 20);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "Total :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(408, 20);
            label5.Name = "label5";
            label5.Size = new Size(139, 20);
            label5.TabIndex = 9;
            label5.Text = "Pedidos registrados";
            label5.Click += label5_Click;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(133, 158);
            nudCantidad.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(150, 27);
            nudCantidad.TabIndex = 10;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(8, 301);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(128, 301);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnVaciar
            // 
            btnVaciar.Location = new Point(252, 301);
            btnVaciar.Name = "btnVaciar";
            btnVaciar.Size = new Size(94, 29);
            btnVaciar.TabIndex = 13;
            btnVaciar.Text = "Vaciar";
            btnVaciar.UseVisualStyleBackColor = true;
            btnVaciar.Click += button3_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnVaciar);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(nudCantidad);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(chkParaLlevar);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbProductos);
            groupBox1.Location = new Point(4, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(380, 359);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 592);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(lblTotal);
            Controls.Add(dvgPedidos);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dvgPedidos).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbProductos;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox chkParaLlevar;
        private DataGridView dvgPedidos;
        private TextBox txtPrecio;
        private Label lblTotal;
        private Label label5;
        private NumericUpDown nudCantidad;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnVaciar;
        private GroupBox groupBox1;
    }
}
