using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace google_homepagev2.Models
{
    public class Dictionary
    {
        [JsonPropertyName("word")]
        public int Word { get; private set; }

        [JsonPropertyName("meaning")]
        public int Meaning { get; private set; }

        public override string ToString() => JsonSerializer.Serialize<Dictionary>(this);
        
    }
}
