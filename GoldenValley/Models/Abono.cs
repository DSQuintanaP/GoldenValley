using System;
using System.Collections.Generic;

namespace GoldenValley.Models;

public partial class Abono
{
    public int IdAbono { get; set; }

    public int IdReserva { get; set; }

    public DateTime FechaAbono { get; set; }

    public decimal Subtotal { get; set; }

    public decimal Iva { get; set; }

    public decimal Total { get; set; }

    public bool Estado { get; set; }

    public string Documento { get; set; } = null!;

    public virtual Reserva IdReservaNavigation { get; set; } = null!;

    public virtual ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();
}
