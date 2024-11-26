using System;
using System.Collections.Generic;

namespace StaffAffairs.DataLayer.Models;

public partial class QmemberJobsBefor
{
    public string? NationNumber { get; set; }

    public int? JopId { get; set; }

    public int? Category { get; set; }

    public string? JobDescription { get; set; }

    public string? DescisionNo { get; set; }

    public DateTime? DescisionDate { get; set; }

    public DateTime? JobDate { get; set; }

    public DateTime? EndJobDate { get; set; }

    public string? JobPlace { get; set; }

    public string? PartId { get; set; }

    public short? EntedabType { get; set; }
}
