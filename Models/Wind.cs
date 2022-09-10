using System.Text.Json.Serialization;

namespace WeatherCli.Models;

public record struct Wind
{
    [JsonPropertyName("km")]
    public double Km { get; set; }

    [JsonPropertyName("mile")]
    public double Mile { get; set; }
}