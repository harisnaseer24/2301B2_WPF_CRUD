using System;
using System.Collections.Generic;

namespace firstTempEmbedding.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string? Empname { get; set; }

    public long? Salary { get; set; }

    public DateTime? Joining { get; set; }

    public string? Designation { get; set; }
}
