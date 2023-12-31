﻿using System;
using System.Collections.Generic;

namespace ZH2_LSNU1C_Forms.Models;

public partial class Students
{
    public int StudentId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int Semester { get; set; }

    public virtual ICollection<Enrollments> Enrollments { get; set; } = new List<Enrollments>();
}
