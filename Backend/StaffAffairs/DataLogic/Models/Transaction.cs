using System;
using System.Collections.Generic;

namespace StaffAffairs.DataLayer.Models;

public partial class Transaction
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    public string? Details { get; set; }

    public DateTime TransactionTime { get; set; }

    public virtual User? User { get; set; }
}
