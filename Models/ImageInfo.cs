using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BlazorWasmSuperHeroApi.Models
{
    public class ImageInfo
    {
        [JsonPropertyName("url")] public string Url { get; set; } = string.Empty;
    }
}