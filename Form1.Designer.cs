namespace Calculadora
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
            txtPantalla = new TextBox();
            LBNResultado = new Label();
            btnCE = new Button();
            btnC = new Button();
            btnBorrar = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btnDivicion = new Button();
            btn9 = new Button();
            btnMultiplicacion = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnMenos = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnMas = new Button();
            btnPunto = new Button();
            btn0 = new Button();
            btnMasMenos = new Button();
            btnIgual = new Button();
            SuspendLayout();
            // 
            // txtPantalla
            // 
            txtPantalla.Location = new Point(12, 54);
            txtPantalla.Multiline = true;
            txtPantalla.Name = "txtPantalla";
            txtPantalla.Size = new Size(418, 51);
            txtPantalla.TabIndex = 0;
            txtPantalla.TextAlign = HorizontalAlignment.Right;
            // 
            // LBNResultado
            // 
            LBNResultado.AutoSize = true;
            LBNResultado.Location = new Point(330, 36);
            LBNResultado.Name = "LBNResultado";
            LBNResultado.Size = new Size(0, 15);
            LBNResultado.TabIndex = 1;
            LBNResultado.TextAlign = ContentAlignment.TopRight;
            // 
            // btnCE
            // 
            btnCE.Location = new Point(12, 111);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(100, 100);
            btnCE.TabIndex = 2;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = true;
            // 
            // btnC
            // 
            btnC.Location = new Point(118, 111);
            btnC.Name = "btnC";
            btnC.Size = new Size(100, 100);
            btnC.TabIndex = 2;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(224, 111);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(100, 100);
            btnBorrar.TabIndex = 2;
            btnBorrar.Text = "⌫";
            btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            btn7.Location = new Point(12, 217);
            btn7.Name = "btn7";
            btn7.Size = new Size(100, 100);
            btn7.TabIndex = 2;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += numero_click;
            // 
            // btn8
            // 
            btn8.Location = new Point(118, 217);
            btn8.Name = "btn8";
            btn8.Size = new Size(100, 100);
            btn8.TabIndex = 2;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += numero_click;
            // 
            // btnDivicion
            // 
            btnDivicion.Location = new Point(330, 111);
            btnDivicion.Name = "btnDivicion";
            btnDivicion.Size = new Size(100, 100);
            btnDivicion.TabIndex = 2;
            btnDivicion.Text = "/";
            btnDivicion.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            btn9.Location = new Point(224, 217);
            btn9.Name = "btn9";
            btn9.Size = new Size(100, 100);
            btn9.TabIndex = 2;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += numero_click;
            // 
            // btnMultiplicacion
            // 
            btnMultiplicacion.Location = new Point(330, 217);
            btnMultiplicacion.Name = "btnMultiplicacion";
            btnMultiplicacion.Size = new Size(100, 100);
            btnMultiplicacion.TabIndex = 2;
            btnMultiplicacion.Text = "*";
            btnMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            btn4.Location = new Point(12, 323);
            btn4.Name = "btn4";
            btn4.Size = new Size(100, 100);
            btn4.TabIndex = 2;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += numero_click;
            // 
            // btn5
            // 
            btn5.Location = new Point(118, 323);
            btn5.Name = "btn5";
            btn5.Size = new Size(100, 100);
            btn5.TabIndex = 2;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += numero_click;
            // 
            // btn6
            // 
            btn6.Location = new Point(224, 323);
            btn6.Name = "btn6";
            btn6.Size = new Size(100, 100);
            btn6.TabIndex = 2;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += numero_click;
            // 
            // btnMenos
            // 
            btnMenos.Location = new Point(330, 323);
            btnMenos.Name = "btnMenos";
            btnMenos.Size = new Size(100, 100);
            btnMenos.TabIndex = 2;
            btnMenos.Text = "-";
            btnMenos.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            btn1.Location = new Point(12, 429);
            btn1.Name = "btn1";
            btn1.Size = new Size(100, 100);
            btn1.TabIndex = 2;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += numero_click;
            // 
            // btn2
            // 
            btn2.Location = new Point(118, 429);
            btn2.Name = "btn2";
            btn2.Size = new Size(100, 100);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += numero_click;
            // 
            // btn3
            // 
            btn3.Location = new Point(224, 429);
            btn3.Name = "btn3";
            btn3.Size = new Size(100, 100);
            btn3.TabIndex = 2;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += numero_click;
            // 
            // btnMas
            // 
            btnMas.Location = new Point(330, 429);
            btnMas.Name = "btnMas";
            btnMas.Size = new Size(100, 100);
            btnMas.TabIndex = 2;
            btnMas.Text = "+";
            btnMas.UseVisualStyleBackColor = true;
            // 
            // btnPunto
            // 
            btnPunto.Location = new Point(12, 535);
            btnPunto.Name = "btnPunto";
            btnPunto.Size = new Size(100, 100);
            btnPunto.TabIndex = 2;
            btnPunto.Text = ".";
            btnPunto.UseVisualStyleBackColor = true;
            btnPunto.Click += numero_click;
            // 
            // btn0
            // 
            btn0.Location = new Point(118, 535);
            btn0.Name = "btn0";
            btn0.Size = new Size(100, 100);
            btn0.TabIndex = 2;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += numero_click;
            // 
            // btnMasMenos
            // 
            btnMasMenos.Location = new Point(224, 535);
            btnMasMenos.Name = "btnMasMenos";
            btnMasMenos.Size = new Size(100, 100);
            btnMasMenos.TabIndex = 2;
            btnMasMenos.Text = "+/-";
            btnMasMenos.UseVisualStyleBackColor = true;
            btnMasMenos.Click += signo_click;
            // 
            // btnIgual
            // 
            btnIgual.Location = new Point(330, 535);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(100, 100);
            btnIgual.TabIndex = 2;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 661);
            Controls.Add(btnIgual);
            Controls.Add(btnMas);
            Controls.Add(btnMasMenos);
            Controls.Add(btn3);
            Controls.Add(btnMenos);
            Controls.Add(btn6);
            Controls.Add(btn0);
            Controls.Add(btn2);
            Controls.Add(btnMultiplicacion);
            Controls.Add(btn5);
            Controls.Add(btnPunto);
            Controls.Add(btn1);
            Controls.Add(btn9);
            Controls.Add(btn4);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnDivicion);
            Controls.Add(btnBorrar);
            Controls.Add(btnC);
            Controls.Add(btnCE);
            Controls.Add(LBNResultado);
            Controls.Add(txtPantalla);
            Name = "Form1";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPantalla;
        private Label LBNResultado;
        private Button btnCE;
        private Button btnC;
        private Button btnBorrar;
        private Button btn7;
        private Button btn8;
        private Button btnDivicion;
        private Button btn9;
        private Button btnMultiplicacion;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnMenos;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnMas;
        private Button btnPunto;
        private Button btn0;
        private Button btnMasMenos;
        private Button btnIgual;
    }
}
