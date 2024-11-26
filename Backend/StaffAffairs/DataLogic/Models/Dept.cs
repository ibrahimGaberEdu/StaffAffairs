using System;
using System.Collections.Generic;

namespace StaffAffairs.DataLayer.Models;
public partial class Dept
{
    public int Id { get; set; }

    public string? DeptName { get; set; }

    public int FacId { get; set; }

    public virtual Fac Fac { get; set; } = null!;

    public virtual ICollection<Specialisation> Specialisations { get; set; } = new List<Specialisation>();
}
