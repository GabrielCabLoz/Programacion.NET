namespace Calculadora
{
    public partial class Form1 : Form
    {
        private bool nuevaEntrada = true;
        private string? operacionPendiente;
        private decimal acumulador;

        public Form1()
        {
            InitializeComponent();
            txtPantalla.Text = "0";
            btnMultiplicacion.Click += new EventHandler(Operador_Click);
            btnMas.Click += new EventHandler(Operador_Click);
            btnMenos.Click += new EventHandler(Operador_Click);
            btnDivicion.Click += new EventHandler(Operador_Click);
            btnIgual.Click += new EventHandler(Igual_Click);
            btnCE.Click += new EventHandler(Limpiar_Click);
            btnBorrar.Click += new EventHandler(Borrar_Click);
        }

        private void numero_click(object sender, EventArgs e)
        {
            if (sender is not Button boton)
            {
                return;
            }
            // Refactorizar
            AgregarAPantalla(boton.Text);
        }

        private void AgregarAPantalla(string valor)
        {
            if (nuevaEntrada)
            {
                txtPantalla.Text = valor == "." ? "0." : valor;
                nuevaEntrada = false;
                return;
            }
            if (valor == "." && txtPantalla.Text.Contains(".", StringComparison.Ordinal))
            {
                return;
            }
            if ((txtPantalla.Text == "0" || txtPantalla.Text == "-0") && valor != ".")
            {
                txtPantalla.Text = txtPantalla.Text.StartsWith("-", StringComparison.Ordinal) ? $"-{valor}" : $"-{valor}";
                return;
            }
            txtPantalla.Text += valor;
        }
        private void signo_click(object sender, EventArgs e)
        {
            if (sender is not Button buton)
            {
                return;
            }
            if (txtPantalla.Text == "0")
            {
                txtPantalla.Text = "-0";
                return;
            }
            if (txtPantalla.Text == "-0")
            {
                txtPantalla.Text = "0";
                return;
            }
            decimal temp = decimal.Parse(txtPantalla.Text) * -1;
            txtPantalla.Text = temp.ToString();
        }
        private bool ObtenerValorPantalla(out decimal valor)
        {

            return decimal.TryParse(txtPantalla.Text, out valor);
        }
        private void Operador_Click(object sender, EventArgs e)
        {
            if (sender is not Button boton)
            {
                return;
            }
            if (!ObtenerValorPantalla(out var ValorActual))
            {
                return;
            }
            if (operacionPendiente is not null && !nuevaEntrada)
            {
                if (AplicarOperacionPendiente(ValorActual, out var resultadoIntermedio))
                {
                    return;
                }
                acumulador = resultadoIntermedio;
                //txtPantalla.Text = acumulador.ToString();
            }
            else
            {
                acumulador = ValorActual;
            }
            operacionPendiente = boton.Text;
            nuevaEntrada = true;
            LBNResultado.Text = $"{acumulador.ToString()} {operacionPendiente}";
        }

        private bool AplicarOperacionPendiente(decimal valorActual, out decimal resultadoIntermedio)
        {
            resultadoIntermedio = acumulador;
            switch (operacionPendiente)
            {
                case "+":
                    resultadoIntermedio = acumulador + valorActual;
                    return true;

                case "-":
                    resultadoIntermedio = acumulador - valorActual;
                    return true;
                case "*":
                    resultadoIntermedio = acumulador * valorActual;
                    return true;
                case "/":
                    if (valorActual == 0)
                    {
                        MessageBox.Show("No mastiques agua", "Operacion no valida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    resultadoIntermedio = acumulador / valorActual;
                    return true;
                default:
                    return false;
            }
        }
        private void Igual_Click(object sender, EventArgs e)
        {
            if (operacionPendiente is null || !ObtenerValorPantalla(out var Valor))
            {
                return;
            }
            if (nuevaEntrada)
            {
                Valor = acumulador;
            }
            decimal ValorAnterior = acumulador;
            if (!AplicarOperacionPendiente(Valor, out var resultado))
            {
                return;
            }

            txtPantalla.Text = resultado.ToString();
            LBNResultado.Text = $"{ValorAnterior} {operacionPendiente} {Valor} =";
            acumulador = resultado;
            operacionPendiente = null;
            nuevaEntrada = true;
        }
        private void Limpiar_Click(object sender, EventArgs e)
        {
            acumulador = 0;
            operacionPendiente = null;
            txtPantalla.Text = "0";
            LBNResultado.Text = "";
        }
        private void Borrar_Click(object sender, EventArgs e)
        {
            if (nuevaEntrada)
            {
                return;
            }
            if (txtPantalla.Text.Length == 1 || (txtPantalla.Text.Length == 2 && txtPantalla.Text.StartsWith("-")))
            {
                txtPantalla.Text = "0";
                nuevaEntrada = true;
            }
            txtPantalla.Text = txtPantalla.Text[..^1];
        }
    }
}
