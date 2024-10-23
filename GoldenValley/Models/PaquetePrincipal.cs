using System;
using System.Collections.Generic;

namespace GoldenValley.Models;

public partial class PaquetePrincipal
{
    public int IdPaquete { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public decimal PrecioTotal { get; set; }

    public int Duracion { get; set; }

    public int IdPaqueteHabitacion { get; set; }

    public int IdPaqueteServicio { get; set; }

    public virtual ICollection<DetallePaquete> DetallePaquetes { get; set; } = new List<DetallePaquete>();

    public virtual PaquetesHabitacione IdPaqueteHabitacionNavigation { get; set; } = null!;

    public virtual PaquetesServicio IdPaqueteServicioNavigation { get; set; } = null!;
}
