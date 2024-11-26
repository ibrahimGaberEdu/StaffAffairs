using System;
using System.Collections.Generic;

namespace StaffAffairs.DataLayer.Models;

public partial class News
{
    public int Id { get; set; }

    public int Order { get; set; }

    public bool DisplayInHome { get; set; }

    public bool DisplayInHomeEn { get; set; }

    public DateTime Cdate { get; set; }

    public string? Image { get; set; }

    public string? Header { get; set; }

    public string? HeaderEn { get; set; }

    public string? Content { get; set; }

    public string? ContentEn { get; set; }

    public bool IsDeleted { get; set; }
}
