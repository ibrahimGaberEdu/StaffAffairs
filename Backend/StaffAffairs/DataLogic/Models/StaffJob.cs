using System;
using System.Collections.Generic;

namespace StaffAffairs.DataLayer.Models;

public partial class StaffJob
{
    public int Id { get; set; }

    public string StaffMemberNationalId { get; set; } = null!;

    public int JobId { get; set; }

    public string? JobDecisionNum { get; set; }

    public DateTime? JobDecisionDate { get; set; }

    public string? Description { get; set; }

    public DateTime? JobStartDate { get; set; }

    public DateTime? JobEndtDate { get; set; }

    public bool? IsCurrentJob { get; set; }

    public bool? InChargeOf { get; set; }

    public int? UnivId { get; set; }

    public int? FacId { get; set; }

    public int? DeptId { get; set; }

    public string? Notes { get; set; }

    public int EntedabType { get; set; }

    public string? EntedabGehaName { get; set; }

    public virtual Job Job { get; set; } = null!;

    public virtual StaffMember StaffMemberNational { get; set; } = null!;
}
