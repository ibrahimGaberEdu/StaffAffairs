using System;
using System.Collections.Generic;

namespace StaffAffairs.DataLayer.Models;

public partial class Job
{
    public int Id { get; set; }

    public string? JobName { get; set; }

    public int JobTypeId { get; set; }

    public int? JobPriority { get; set; }

    public virtual JobType JobType { get; set; } = null!;

    public virtual ICollection<StaffJob> StaffJobs { get; set; } = new List<StaffJob>();
}
