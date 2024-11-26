using System;
using System.Collections.Generic;

namespace StaffAffairs.DataLayer.Models;

public partial class Specialisation
{
    public int Id { get; set; }

    public string? SpecialiseName { get; set; }

    public int DeptId { get; set; }

    public virtual Dept Dept { get; set; } = null!;
}
