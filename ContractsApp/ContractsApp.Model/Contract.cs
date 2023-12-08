using System;
using System.Collections.Generic;

namespace ContractsApp.Model;

public partial class Contract
{
    public int Id { get; set; }

    public string CourseCode { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public bool Estado { get; set; }

    public int CantidadEgresados { get; set; }

    public DateOnly FechaEntrega { get; set; }

    public string? MedioEntrega { get; set; }

    public string? Vendedor { get; set; }

    public string ColegioNivel { get; set; } = null!;

    public string ColegioNombre { get; set; } = null!;

    public string ColegioCurso { get; set; } = null!;

    public string ColegioLocalidad { get; set; } = null!;

    public int Comision { get; set; }

    public decimal Total { get; set; }

    public virtual ICollection<Contractitem> Contractitems { get; set; } = new List<Contractitem>();
}
