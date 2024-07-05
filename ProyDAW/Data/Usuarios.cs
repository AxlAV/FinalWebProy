using System;
using System.Collections.Generic;

namespace ProyDAW.Data;

public partial class Usuarios
{
    public int UsuarioId { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string CorreoElectronico { get; set; } = null!;

    public string Contraseña { get; set; } = null!;

    public DateTime? FechaRegistro { get; set; }

    public string? ImagenUsuario { get; set; }

    public virtual ICollection<Reservas> Reservas { get; set; } = new List<Reservas>();

    public virtual ICollection<Reseñas> Reseñas { get; set; } = new List<Reseñas>();
}
