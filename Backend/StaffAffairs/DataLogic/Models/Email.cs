using System;
using System.Collections.Generic;

namespace StaffAffairs.DataLayer.Models;

public partial class Email
{
    public string Code { get; set; } = null!;

    public string? Name { get; set; }

    public string? Msg { get; set; }

    public string? MsgEn { get; set; }

    public string? Title { get; set; }

    public string? TitleEn { get; set; }

    public bool SendEmail { get; set; }
}
