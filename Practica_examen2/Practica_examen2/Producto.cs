using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_examen2
{
    public class Producto
    {

     public String Nombre { get; set; }
     public int Precio { get; set; }


        public Producto(string nombre, int precio)
        {
            this.Nombre = nombre;
            this.Precio = precio;

        }


        public override string ToString()
        {
            return Nombre;
        }


    }

    
    }
