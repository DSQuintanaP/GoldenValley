using System;
using System.Collections.Generic;

namespace GoldenValley.Models;

public partial class MetodoPago
{
    public int IdMetodoPago { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Estado { get; set; }

    public virtual ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();
}
