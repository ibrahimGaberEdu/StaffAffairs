using System;
using System.Collections.Generic;

namespace StaffAffairs.DataLayer.Models;

public partial class ScientificLevel
{
    public int Id { get; set; }

    public string? NameEn { get; set; }

    public string? Name { get; set; }

    public int? Order { get; set; }
}
