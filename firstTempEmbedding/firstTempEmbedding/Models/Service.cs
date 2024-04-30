using System;
using System.Collections.Generic;

namespace firstTempEmbedding.Models;

public partial class Service
{
    public int Id { get; set; }

    public string? ServiceTitle { get; set; }

    public string? Description { get; set; }

    public int? Price { get; set; }
}
