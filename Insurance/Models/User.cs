using Insurance.Enum;
using System;
using System.Collections.Generic;

namespace Insurance.Models;

public partial class User
{
    public int LoginId { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public UserTypeEnum Type { get; set; }

    public UserStatusEnum Status { get; set; }
}
