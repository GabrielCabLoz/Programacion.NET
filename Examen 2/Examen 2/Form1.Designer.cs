namespace Examen_2
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
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtResponsable = new TextBox();
            nudCantidad = new NumericUpDown();
            txtCantidad = new Label();
            dgvReservas = new DataGridView();
            cmbTaller = new ComboBox();
            lblDisponibles = new Label();
            btnRegistrar = new Button();
            btnLimpiar = new Button();
            btnCancelar = new Button();
            lblReservas = new Label();
            lblOcupados = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label3 = new Label();
            label8 = new Label();
            chkMaterial = new CheckBox();
            rbMatutino = new RadioButton();
            groupBox3 = new GroupBox();
            rbVespertino = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvReservas).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 22);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(174, 18);
            label1.TabIndex = 0;
            label1.Text = "1 sELECCION DE TALLER";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 9F);
            label2.Location = new Point(51, 30);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(177, 18);
            label2.TabIndex = 1;
            label2.Text = "2 DATOS DE LA RESERVA";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 187);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(74, 100);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 66);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(44, 20);
            label6.TabIndex = 5;
            label6.Text = "Taller";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(63, 80);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(93, 20);
            label7.TabIndex = 6;
            label7.Text = "Responsable";
            label7.Click += label7_Click;
            // 
            // txtResponsable
            // 
            txtResponsable.Location = new Point(63, 112);
            txtResponsable.Margin = new Padding(2);
            txtResponsable.Name = "txtResponsable";
            txtResponsable.Size = new Size(200, 27);
            txtResponsable.TabIndex = 11;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(180, 167);
            nudCantidad.Margin = new Padding(2);
            nudCantidad.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(82, 27);
            nudCantidad.TabIndex = 12;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtCantidad
            // 
            txtCantidad.AutoSize = true;
            txtCantidad.Location = new Point(39, 171);
            txtCantidad.Margin = new Padding(2, 0, 2, 0);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(142, 20);
            txtCantidad.TabIndex = 13;
            txtCantidad.Text = "Cantidad de lugares";
            txtCantidad.Click += label9_Click;
            // 
            // dgvReservas
            // 
            dgvReservas.AllowUserToAddRows = false;
            dgvReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservas.Location = new Point(-6, 292);
            dgvReservas.Margin = new Padding(2);
            dgvReservas.Name = "dgvReservas";
            dgvReservas.ReadOnly = true;
            dgvReservas.RowHeadersWidth = 62;
            dgvReservas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReservas.Size = new Size(838, 158);
            dgvReservas.TabIndex = 14;
            // 
            // cmbTaller
            // 
            cmbTaller.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTaller.FormattingEnabled = true;
            cmbTaller.Location = new Point(30, 102);
            cmbTaller.Margin = new Padding(2);
            cmbTaller.Name = "cmbTaller";
            cmbTaller.Size = new Size(181, 28);
            cmbTaller.TabIndex = 15;
            cmbTaller.SelectedIndexChanged += cmbTaller_SelectedIndexChanged;
            // 
            // lblDisponibles
            // 
            lblDisponibles.AutoSize = true;
            lblDisponibles.Font = new Font("Showcard Gothic", 9F);
            lblDisponibles.Location = new Point(30, 163);
            lblDisponibles.Margin = new Padding(2, 0, 2, 0);
            lblDisponibles.Name = "lblDisponibles";
            lblDisponibles.Size = new Size(179, 18);
            lblDisponibles.TabIndex = 16;
            lblDisponibles.Text = "Lugares disponibles :";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(23, 248);
            btnRegistrar.Margin = new Padding(2);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(139, 27);
            btnRegistrar.TabIndex = 17;
            btnRegistrar.Text = "Registrar reserva";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(358, 248);
            btnLimpiar.Margin = new Padding(2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(130, 27);
            btnLimpiar.TabIndex = 18;
            btnLimpiar.Text = "Limpiar captura ";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(176, 248);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(164, 27);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "Cancelar selecciones";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblReservas
            // 
            lblReservas.AutoSize = true;
            lblReservas.Font = new Font("Showcard Gothic", 9F);
            lblReservas.Location = new Point(10, 468);
            lblReservas.Margin = new Padding(2, 0, 2, 0);
            lblReservas.Name = "lblReservas";
            lblReservas.Size = new Size(190, 18);
            lblReservas.TabIndex = 20;
            lblReservas.Text = "RESERVAS REGISTRADAS :";
            // 
            // lblOcupados
            // 
            lblOcupados.AutoSize = true;
            lblOcupados.Font = new Font("Showcard Gothic", 9F);
            lblOcupados.Location = new Point(290, 468);
            lblOcupados.Margin = new Padding(2, 0, 2, 0);
            lblOcupados.Name = "lblOcupados";
            lblOcupados.Size = new Size(164, 18);
            lblOcupados.TabIndex = 21;
            lblOcupados.Text = "LUGARES OCUPADOS :";
            lblOcupados.Click += label12_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblDisponibles);
            groupBox1.Controls.Add(cmbTaller);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(1, 16);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(254, 206);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtCantidad);
            groupBox2.Controls.Add(nudCantidad);
            groupBox2.Controls.Add(txtResponsable);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(266, 7);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(294, 212);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 9F);
            label3.Location = new Point(67, 35);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(124, 18);
            label3.TabIndex = 2;
            label3.Text = "3 PREFERENCIAS";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(106, 80);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(47, 20);
            label8.TabIndex = 7;
            label8.Text = "Turno";
            label8.Click += label8_Click;
            // 
            // chkMaterial
            // 
            chkMaterial.AutoSize = true;
            chkMaterial.Location = new Point(77, 189);
            chkMaterial.Margin = new Padding(2);
            chkMaterial.Name = "chkMaterial";
            chkMaterial.Size = new Size(149, 24);
            chkMaterial.TabIndex = 8;
            chkMaterial.Text = "Requiere material";
            chkMaterial.UseVisualStyleBackColor = true;
            // 
            // rbMatutino
            // 
            rbMatutino.AutoSize = true;
            rbMatutino.Location = new Point(30, 136);
            rbMatutino.Margin = new Padding(2);
            rbMatutino.Name = "rbMatutino";
            rbMatutino.Size = new Size(90, 24);
            rbMatutino.TabIndex = 10;
            rbMatutino.TabStop = true;
            rbMatutino.Text = "Matutino";
            rbMatutino.UseVisualStyleBackColor = true;
            rbMatutino.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rbVespertino);
            groupBox3.Controls.Add(rbMatutino);
            groupBox3.Controls.Add(chkMaterial);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new Point(575, 7);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(291, 227);
            groupBox3.TabIndex = 24;
            groupBox3.TabStop = false;
            groupBox3.Enter += groupBox3_Enter;
            // 
            // rbVespertino
            // 
            rbVespertino.AutoSize = true;
            rbVespertino.Location = new Point(141, 136);
            rbVespertino.Margin = new Padding(2);
            rbVespertino.Name = "rbVespertino";
            rbVespertino.Size = new Size(100, 24);
            rbVespertino.TabIndex = 11;
            rbVespertino.TabStop = true;
            rbVespertino.Text = "Vespertino";
            rbVespertino.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(842, 495);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblOcupados);
            Controls.Add(lblReservas);
            Controls.Add(btnCancelar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnRegistrar);
            Controls.Add(dgvReservas);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvReservas).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtResponsable;
        private NumericUpDown nudCantidad;
        private Label txtCantidad;
        private DataGridView dgvReservas;
        private ComboBox cmbTaller;
        private Label lblDisponibles;
        private Button btnRegistrar;
        private Button btnLimpiar;
        private Button btnCancelar;
        private Label lblReservas;
        private Label lblOcupados;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private RadioButton rbMatutino;
        private CheckBox chkMaterial;
        private Label label8;
        private Label label3;
        private RadioButton rbVespertino;
    }
}
