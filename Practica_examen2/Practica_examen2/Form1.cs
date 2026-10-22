
using System.ComponentModel;
namespace Practica_examen2
{
    public partial class Form1 : Form
    {
        BindingList<Producto> productos = new BindingList<Producto>();
        BindingList<Pedido> pedidos = new BindingList<Pedido>();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pedidos.Count == 0)
            {
                MessageBox.Show("No hay pedidos para vaciar.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Seguro que quieres vaciar todos los pedidos?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                pedidos.Clear();
                ActualizarTotal();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            productos.Add(new Producto("Cafe", 30));
            productos.Add(new Producto("Té", 25));
            productos.Add(new Producto("Sandwich", 55));
            productos.Add(new Producto("Galletas", 20));

            cmbProductos.DataSource = productos;
            dvgPedidos.DataSource = pedidos;

            cmbProductos.SelectedIndex = -1;



        }

        private void dgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProductos.SelectedItem != null)
            {
                Producto productoSeleccionado = (Producto)cmbProductos.SelectedItem;

                txtPrecio.Text = productoSeleccionado.Precio.ToString("C2");

            }
            else
            {
                txtPrecio.Text = String.Empty;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (cmbProductos.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un producto.");
                return;
            }

            Producto productoSeleccionado = (Producto)cmbProductos.SelectedItem;

            int cantidad = (int)nudCantidad.Value;
            bool paraLlevar = chkParaLlevar.Checked;

            decimal subtotal = productoSeleccionado.Precio * cantidad;

            if (paraLlevar)
            {
                subtotal += 5;
            }

            Pedido nuevoPedido = new Pedido(
                productoSeleccionado,
                cantidad,
                paraLlevar,
                subtotal
            );

            pedidos.Add(nuevoPedido);

            ActualizarTotal();
        }

        private void ActualizarTotal()
        {
            decimal total = 0;

            foreach (Pedido pedido in pedidos)
            {
                total += pedido.Subtotal;
            }

            lblTotal.Text = "Total: " + total.ToString("C2");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (dvgPedidos.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un pedido para eliminar.");
                return;
            }

            Pedido pedidoSeleccionado =
                (Pedido)dvgPedidos.CurrentRow.DataBoundItem;

            pedidos.Remove(pedidoSeleccionado);

            ActualizarTotal();

        }
    }
}

