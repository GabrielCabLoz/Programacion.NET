
using System;
using System.Collections.Generic;
using System.Text;

namespace Examen_2
{
    internal class Reserva
    {

    public string Responsable { get; set; } = "";
    public Taller Taller { get; set; } = new();
     public int Cantidad { get; set; } = 0;
    
    public String turno { get; set; } = "";

    public bool material { get; set; } = false;

    }
}
