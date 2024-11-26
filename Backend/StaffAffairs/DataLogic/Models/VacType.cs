using System;
using System.Collections.Generic;

namespace StaffAffairs.DataLayer.Models;

public partial class VacType
{
    public int Id { get; set; }

    public string? VacName { get; set; }

    public virtual ICollection<StaffVac> StaffVacs { get; set; } = new List<StaffVac>();
}
