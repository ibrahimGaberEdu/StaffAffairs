using System;
using System.Collections.Generic;

namespace StaffAffairs.DataLayer.Models;

public partial class StaffRelation
{
    public int Id { get; set; }

    public string StaffMemberNationalId { get; set; } = null!;

    public string? PersonName { get; set; }

    public string? IdNum { get; set; }

    public string? PersonNationalId { get; set; }

    public int? Gender { get; set; }

    public int? RelationType { get; set; }

    public string? QualifyName { get; set; }

    public string? PersonJob { get; set; }

    public DateTime? BirthDate { get; set; }

    public string? BirthPlace { get; set; }

    public virtual StaffMember StaffMemberNational { get; set; } = null!;
}
