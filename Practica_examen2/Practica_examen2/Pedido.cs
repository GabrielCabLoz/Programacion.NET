using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_examen2
{
    
        public class Pedido
        {
            public Producto producto { get; set; }
            public int Cantidad { get; set; }
            public bool ParaLlevar { get; set; }
            public decimal Subtotal { get; set; }

            public Pedido(Producto producto, int cantidad, bool paraLlevar, decimal subtotal)
            {
                this.producto = producto;
                Cantidad = cantidad;
                ParaLlevar = paraLlevar;
                Subtotal = subtotal;
            }
        }
    
}
