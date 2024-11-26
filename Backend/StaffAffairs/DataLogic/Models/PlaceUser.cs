using System;
using System.Collections.Generic;

namespace StaffAffairs.DataLayer.Models;

public partial class PlaceUser
{
    public int Id { get; set; }

    public string? UserName { get; set; }

    public int PlaceId { get; set; }
}
