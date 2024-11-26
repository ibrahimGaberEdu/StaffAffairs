using System;
using System.Collections.Generic;

namespace StaffAffairs.DataLayer.Models;

public partial class Univ
{
    public int Id { get; set; }

    public string? UnivName { get; set; }

    public bool? ForeignUniversity { get; set; }

    public virtual ICollection<Fac> Facs { get; set; } = new List<Fac>();
}
