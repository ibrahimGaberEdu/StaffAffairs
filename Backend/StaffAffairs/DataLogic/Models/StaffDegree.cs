using System;
using System.Collections.Generic;

namespace StaffAffairs.DataLayer.Models;

public partial class StaffDegree
{
    public int Id { get; set; }

    public string? StaffMemberNationalId { get; set; }

    public int DegreeId { get; set; }

    public DateTime? HireDate { get; set; }

    public string? DecisionNum { get; set; }

    public DateTime? DecisionDate { get; set; }

    public int UnivId { get; set; }

    public int FacId { get; set; }

    public int DeptId { get; set; }

    public string? DegreeSpecial { get; set; }

    public bool? IsUpgrade { get; set; }

    public virtual Degree Degree { get; set; } = null!;

    public virtual StaffMember? StaffMemberNational { get; set; }
}
