using System;
using System.Collections.Generic;

namespace GoldenValley.Models;

public partial class PaquetesHabitacione
{
    public int IdPaqueteHabitacion { get; set; }

    public int? IdPaquete { get; set; }

    public int? IdHabitacion { get; set; }

    public virtual Habitacione? IdHabitacionNavigation { get; set; }

    public virtual ICollection<PaquetePrincipal> PaquetePrincipals { get; set; } = new List<PaquetePrincipal>();
}
