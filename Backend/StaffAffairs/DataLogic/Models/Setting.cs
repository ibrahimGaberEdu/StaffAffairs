using System;
using System.Collections.Generic;

namespace StaffAffairs.DataLayer.Models;

public partial class Setting
{
    public int Id { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string CurrentAcademicYear { get; set; } = null!;

    public bool Available { get; set; }

    public bool StudentNewRequestAvailable { get; set; }

    public bool StudentUpadateAvailable { get; set; }

    public bool PlaceUpdateAvailable { get; set; }

    public bool AdminUpdateAvailable { get; set; }

    public bool PlaceAvailable { get; set; }

    public bool AdminAvailable { get; set; }

    public string NotAvailableMessage { get; set; } = null!;

    public string? SecureSite { get; set; }

    public string? Notes { get; set; }

    public bool PersonalPhotoRequired { get; set; }

    public bool NationalIdImageRequired { get; set; }

    public string? TrainingSupervisor { get; set; }

    public float ExtraCertificatePrice { get; set; }

    public string? ContactInfo { get; set; }
}
