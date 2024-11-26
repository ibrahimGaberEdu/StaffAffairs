using System;
using System.Collections.Generic;

namespace StaffAffairs.DataLayer.Models;

public partial class PunishType
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Sort { get; set; }

    public virtual ICollection<StaffPunish> StaffPunishes { get; set; } = new List<StaffPunish>();
}
