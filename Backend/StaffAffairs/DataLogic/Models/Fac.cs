using System;
using System.Collections.Generic;

namespace StaffAffairs.DataLayer.Models;

public partial class Fac
{
    public int Id { get; set; }

    public string? FacName { get; set; }

    public int UnivId { get; set; }

    public int Priority { get; set; }

    public virtual ICollection<Dept> Depts { get; set; } = new List<Dept>();

    public virtual Univ Univ { get; set; } = null!;
}
