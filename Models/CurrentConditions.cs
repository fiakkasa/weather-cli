using System.Text.Json.Serialization;

namespace WeatherCli.Models;

public record struct CurrentConditions
{
    [JsonPropertyName("dayhour")]
    public string Dayhour { get; set; }

    [JsonPropertyName("temp")]
    public Temp Temp { get; set; }

    [JsonPropertyName("precip")]
    public string Precip { get; set; }

    [JsonPropertyName("humidity")]
    public string Humidity { get; set; }

    [JsonPropertyName("wind")]
    public Wind Wind { get; set; }

    [JsonPropertyName("comment")]
    public string Comment { get; set; }
}

