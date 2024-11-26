using System;
using System.Collections.Generic;

namespace StaffAffairs.DataLayer.Models;

public partial class StaffPunish
{
    public int Id { get; set; }

    public string? StaffMemberNationalId { get; set; }

    public int PunishtypeId { get; set; }

    public string? PunishDetails { get; set; }

    public DateTime? PunishStartDate { get; set; }

    public DateTime? PunishEndDate { get; set; }

    public string? DescisionNum { get; set; }

    public DateTime? DecisionDate { get; set; }

    public string? Notes { get; set; }

    public bool? RemovePunish { get; set; }

    public string? CauseOfRemove { get; set; }

    public string? RemoveDecisionNum { get; set; }

    public DateTime? RemoveDecisionDate { get; set; }

    public virtual PunishType Punishtype { get; set; } = null!;

    public virtual StaffMember? StaffMemberNational { get; set; }
}
