using System;
using System.Collections.Generic;

namespace Insurance.Models;

public partial class Policy
{
    public int PolicyId { get; set; }

    public int? CompanyId { get; set; }

    public int? TypeId { get; set; }

    public string? PolicyName { get; set; }

    public int? TimePeriod { get; set; }

    public decimal? PolicyAmount { get; set; }

    public int Status { get; set; }

    public virtual Company? Company { get; set; }

    public virtual ICollection<PolicyTerm> PolicyTerms { get; } = new List<PolicyTerm>();
}
