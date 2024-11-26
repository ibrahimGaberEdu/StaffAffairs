using System;
using System.Collections.Generic;

namespace StaffAffairs.DataLayer.Models;

public partial class Month
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<StaffQualify> StaffQualifies { get; set; } = new List<StaffQualify>();
}
