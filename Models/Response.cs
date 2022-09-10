using System.Text.Json.Serialization;

namespace WeatherCli.Models;

public record struct Response
{
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    [JsonPropertyName("currentConditions")]
    public CurrentConditions CurrentConditions { get; set; }
}
