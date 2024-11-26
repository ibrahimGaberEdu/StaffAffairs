using System;
using System.Collections.Generic;

namespace StaffAffairs.DataLayer.Models;

public partial class JobType
{
    public int Id { get; set; }

    public string? JobName { get; set; }

    public virtual ICollection<Job> Jobs { get; set; } = new List<Job>();
}
