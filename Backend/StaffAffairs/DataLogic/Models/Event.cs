﻿using System;
using System.Collections.Generic;

namespace StaffAffairs.DataLayer.Models;

public partial class Event
{
    public int Id { get; set; }

    public int Order { get; set; }

    public bool DisplayInHome { get; set; }

    public bool DisplayInHomeEn { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime Cdate { get; set; }

    public string? Image { get; set; }

    public string? Header { get; set; }

    public string? HeaderEn { get; set; }

    public string? Content { get; set; }

    public string? ContentEn { get; set; }

    public string? ExternalUrl { get; set; }
}