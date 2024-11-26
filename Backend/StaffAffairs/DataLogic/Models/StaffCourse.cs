using System;
using System.Collections.Generic;

namespace StaffAffairs.DataLayer.Models;

public partial class StaffCourse
{
    public int Id { get; set; }

    public string? StaffMemberNationalId { get; set; }

    public string? CourseName { get; set; }

    public int CoursePlaceTypeId { get; set; }

    public string? CoursePlace { get; set; }

    public DateTime CourseStartDate { get; set; }

    public DateTime CourseEndDate { get; set; }

    public int CourseGrade { get; set; }

    public virtual StaffMember? StaffMemberNational { get; set; }
}
