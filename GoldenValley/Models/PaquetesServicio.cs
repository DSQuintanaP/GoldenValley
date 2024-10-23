using System;
using System.Collections.Generic;

namespace GoldenValley.Models;

public partial class PaquetesServicio
{
    public int IdPaqueteServicio { get; set; }

    public int? IdPaquete { get; set; }

    public int? IdServicio { get; set; }

    public virtual Servicio? IdServicioNavigation { get; set; }

    public virtual ICollection<PaquetePrincipal> PaquetePrincipals { get; set; } = new List<PaquetePrincipal>();
}
