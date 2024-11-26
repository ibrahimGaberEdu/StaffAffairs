using System;
using System.Collections.Generic;

namespace StaffAffairs.DataLayer.Models;

public partial class StaffMember
{
    public string NationalId { get; set; } = null!;

    public string? Name { get; set; }

    public string? FileNo { get; set; }

    public int GenderId { get; set; }

    public string? BirthPlace { get; set; }

    public DateTime? BirthDate { get; set; }

    public int? SocialId { get; set; }

    public int MilitaryStateId { get; set; }

    public string? HomePhone { get; set; }

    public string? MobilePhone { get; set; }

    public bool DoingWork { get; set; }

    public string? SpecialiseId { get; set; }

    public int FacId { get; set; }

    public int DeptId { get; set; }

    public string? IssureNumber { get; set; }

    public int ReligionId { get; set; }

    public string? CurrentAddress { get; set; }

    public string? OldAddress { get; set; }

    public int NationalityId { get; set; }

    public string? Email { get; set; }

    public int HireTypeId { get; set; }

    public bool EndWork { get; set; }

    public DateTime? EndWorkDate { get; set; }

    public string? EndWorkReason { get; set; }

    public virtual ICollection<LastAllowanceDate> LastAllowanceDates { get; set; } = new List<LastAllowanceDate>();

    public virtual ICollection<StaffCourse> StaffCourses { get; set; } = new List<StaffCourse>();

    public virtual ICollection<StaffDegree> StaffDegrees { get; set; } = new List<StaffDegree>();

    public virtual ICollection<StaffJob> StaffJobs { get; set; } = new List<StaffJob>();

    public virtual ICollection<StaffPunish> StaffPunishes { get; set; } = new List<StaffPunish>();

    public virtual ICollection<StaffQualify> StaffQualifies { get; set; } = new List<StaffQualify>();

    public virtual ICollection<StaffRelation> StaffRelations { get; set; } = new List<StaffRelation>();

    public virtual ICollection<StaffVac> StaffVacs { get; set; } = new List<StaffVac>();
}
