using System;
using System.Collections.Generic;

namespace StaffAffairs.DataLayer.Models;
public partial class Degree
{
    public int Id { get; set; }

    public string DegreeName { get; set; } = null!;

    public int? DegreeOrder { get; set; }

    public virtual ICollection<StaffDegree> StaffDegrees { get; set; } = new List<StaffDegree>();
}
