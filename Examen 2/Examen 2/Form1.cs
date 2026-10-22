using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Examen_2
{
    public partial class Form1 : Form
    {
        BindingList<Taller> talleres = new BindingList<Taller>();
        BindingList<Reserva> reservas = new BindingList<Reserva>();

        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmbTaller_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTaller.SelectedItem != null)
            {
                Taller tallerSeleccionado = (Taller)cmbTaller.SelectedItem;

                lblDisponibles.Text = "LUGARES DISPONIBLES: " + tallerSeleccionado.CupoMaximo.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

            talleres.Add(new Taller { Nombre = "Programación C#", CupoMaximo = 5 });

            talleres.Add(new Taller { Nombre = "Diseño Web", CupoMaximo = 4 });

            talleres.Add(new Taller { Nombre = "Redes Básicas", CupoMaximo = 6 });

            cmbTaller.DataSource = talleres;

            dgvReservas.DataSource = reservas;

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cmbTaller.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un taller.");
                return;
            }

            if (txtResponsable.Text == "")
            {
                MessageBox.Show("Escribe el nombre del responsable.");
                return;
            }

            if (rbMatutino.Checked == false && rbVespertino.Checked == false)
            {
                MessageBox.Show("Selecciona un turno.");
                return;
            }

            Taller tallerSeleccionado = (Taller)cmbTaller.SelectedItem;

            int cantidad = (int)nudCantidad.Value;

            int ocupados = 0;

            foreach (Reserva reserva in reservas)
            {
                if (reserva.Taller == tallerSeleccionado)
                {
                    ocupados += reserva.Cantidad;
                }
            }

            int disponibles = tallerSeleccionado.CupoMaximo - ocupados;

            if (cantidad > disponibles)
            {
                MessageBox.Show("No hay suficientes lugares disponibles.");
                return;
            }

            string turno = "";

            if (rbMatutino.Checked)
            {
                turno = "Matutino";
            }

            if (rbVespertino.Checked)
            {
                turno = "Vespertino";
            }

            Reserva nuevaReserva = new Reserva();

            nuevaReserva.Responsable = txtResponsable.Text;
            nuevaReserva.Taller = tallerSeleccionado;
            nuevaReserva.Cantidad = cantidad;

            reservas.Add(nuevaReserva);

            lblDisponibles.Text ="LUGARES DISPONIBLES: " + (disponibles - cantidad);

            MessageBox.Show("Reserva registrada.");


            lblDisponibles.Text ="LUGARES DISPONIBLES: " + (disponibles - cantidad);

            int totalOcupados = 0;

            foreach (Reserva reserva in reservas){totalOcupados += reserva.Cantidad;}

            lblReservas.Text ="RESERVAS REGISTRADAS: " + reservas.Count;

            lblOcupados.Text ="LUGARES OCUPADOS: " + totalOcupados;

            MessageBox.Show("Reserva registrada.");

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtResponsable.Text = "";

            nudCantidad.Value = 1;

            rbMatutino.Checked = false;
            rbVespertino.Checked = false;

            chkMaterial.Checked = false;
        }
    }
}