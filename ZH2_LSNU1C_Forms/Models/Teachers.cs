using System;
using System.Collections.Generic;

namespace ZH2_LSNU1C_Forms.Models;

public partial class Teachers
{
    public int TeacherId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public virtual ICollection<AssignedSubjects> AssignedSubjects { get; set; } = new List<AssignedSubjects>();
}
