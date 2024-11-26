using System;
using System.Collections.Generic;

namespace StaffAffairs.DataLayer.Models;

public partial class EventImage
{
    public int Id { get; set; }

    public int Category { get; set; }

    public string? FileName { get; set; }

    public int Order { get; set; }

    public int EventId { get; set; }
}
