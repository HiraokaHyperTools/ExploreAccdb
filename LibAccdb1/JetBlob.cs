﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LibAccdb1
{
    public class JetBlob
    {
        [JsonPropertyName("$binary")] public string? Binary { get; set; }
        [JsonPropertyName("$type")] public string? Type { get; set; }
    }
}
