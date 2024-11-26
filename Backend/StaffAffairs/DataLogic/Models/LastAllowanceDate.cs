using System;
using System.Collections.Generic;

namespace StaffAffairs.DataLayer.Models;

public partial class LastAllowanceDate
{
    public int Id { get; set; }

    public string? NationalId { get; set; }

    public string? StaffMemberNationalId { get; set; }

    public DateTime AllowanceDate { get; set; }

    public string? Details { get; set; }

    public virtual StaffMember? StaffMemberNational { get; set; }
}
