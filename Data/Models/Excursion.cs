﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Data.Models;

public partial class Excursion
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int Duration { get; set; }

    public string GuideLanguage { get; set; } = null!;

    public decimal Price { get; set; }

    public string Image { get; set; } = null!;

    public bool Active { get; set; }

    [JsonIgnore] 

    public virtual ICollection<Guia>Guia { get; set; } = new List<Guia>();
}
