using System.Text.Json.Serialization;

namespace WeatherCli.Models;

public record struct Temp
{
    [JsonPropertyName("c")]
    public double C { get; set; }

    [JsonPropertyName("f")]
    public double F { get; set; }
}
