using System;
using System.Collections.Generic;

namespace Insurance.Models;

public partial class Company
{
    public int CompanyId { get; set; }

    public int? LoginId { get; set; }

    public string? CompanyName { get; set; }

    public string? Address { get; set; }

    public string? Email { get; set; }

    public decimal? PhoneNum { get; set; }

    public string? ProfilePic { get; set; }

    public int? Status { get; set; }

    public virtual ICollection<Policy> Policies { get; } = new List<Policy>();
}
