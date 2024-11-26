using System;
using System.Collections.Generic;

namespace StaffAffairs.DataLayer.Models;

public partial class StaffVac
{
    public int Id { get; set; }

    public string? StaffMemberNationalId { get; set; }

    public int VacTypeId { get; set; }

    public DateTime? VacStartDate { get; set; }

    public DateTime? VacEndtDate { get; set; }

    public string? DescisionNum { get; set; }

    public DateTime? DescisionDate { get; set; }

    public string? VacDetails { get; set; }

    public string? CountryName { get; set; }

    public virtual StaffMember? StaffMemberNational { get; set; }

    public virtual VacType VacType { get; set; } = null!;
}
