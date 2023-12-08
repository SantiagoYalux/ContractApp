using System;
using System.Collections.Generic;

namespace ContractsApp.Model;

public partial class Item
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public decimal Precio { get; set; }

    public virtual ICollection<Contractitem> Contractitems { get; set; } = new List<Contractitem>();
}
