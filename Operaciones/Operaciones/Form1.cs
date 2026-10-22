using System.Diagnostics.CodeAnalysis;

namespace Operaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {ñ

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)

        {

            this.cmbOperaciones.Items.Add("Suma");
            this.cmbOperaciones.Items.Add("Resta");
            this.cmbOperaciones.Items.Add("Multiplicación");
            this.cmbOperaciones.Items.Add("División");

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int resultado=0;
            String Operacion = this.cmbOperaciones.SelectedItem.ToString();
            switch (Operacion)
            {


                case "Suma":
                    resultado = int.Parse(this.txtNum1.Text) + int.Parse(this.txtNum2.Text);
                    break;

                case "Resta":
                    resultado = int.Parse(this.txtNum1.Text) - int.Parse(this.txtNum2.Text);
                    break;

                case "Multiplicación":
                    resultado = int.Parse(this.txtNum1.Text) * int.Parse(this.txtNum2.Text);
                    break;

                case "División":
                    resultado = int.Parse(this.txtNum1.Text) / int.Parse(this.txtNum2.Text);
                    break;

            }
            this.txtResultado.Text = resultado.ToString();



        }


    }
}
