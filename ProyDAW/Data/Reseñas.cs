﻿using System;
using System.Collections.Generic;

namespace ProyDAW.Data;

public partial class Reseñas
{
    public int ResenaId { get; set; }

    public int? UsuarioId { get; set; }

    public int? ActividadId { get; set; }

    public string? Comentario { get; set; }

    public int? Valoracion { get; set; }

    public DateTime? FechaResena { get; set; }

    public string? ImagenResena { get; set; }

    public virtual Actividades? Actividad { get; set; }

    public virtual Usuarios? Usuario { get; set; }
}
