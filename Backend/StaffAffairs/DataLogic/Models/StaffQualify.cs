using System;
using System.Collections.Generic;

namespace StaffAffairs.DataLayer.Models;

public partial class StaffQualify
{
    public int Id { get; set; }

    public string? StaffMemberNationalId { get; set; }

    public int? UnivId { get; set; }

    public int? FacId { get; set; }

    public int? DeptId { get; set; }

    public int? QualifyId { get; set; }

    public string? QualifyYear { get; set; }

    public string? QualifySpecializm { get; set; }

    public string? QualifyDecisionNum { get; set; }

    public DateTime? QualifyDecisionDate { get; set; }

    public int? QualifyGrade { get; set; }

    public int? MonthId { get; set; }

    public virtual Month? Month { get; set; }

    public virtual StaffMember? StaffMemberNational { get; set; }
}
