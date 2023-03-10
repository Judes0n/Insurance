using System;
using System.Collections.Generic;

namespace Insurance.Models;

public partial class Client
{
    public int ClientId { get; set; }

    public int? LoginId { get; set; }

    public string? ClientName { get; set; }

    public string? Gender { get; set; }

    public string? Dob { get; set; }

    public string? Address { get; set; }

    public string? ProfilePic { get; set; }

    public decimal? PhoneNum { get; set; }

    public int Status { get; set; }

    public virtual ICollection<ClientPolicy> ClientPolicies { get; } = new List<ClientPolicy>();
}
