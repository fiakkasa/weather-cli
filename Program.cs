using System.Net.Http.Json;
using System.Text.RegularExpressions;
using WeatherCli.Models;
using static System.Console;

WriteLine("Hello from Weather Cli!");
PrnSep();

if (args.Contains("-h"))
{
    WriteLine(
@"Enter the name of the city for the current weather conditions!
ex. 
- NewYork
- New York
- New York, NY"
    );
    return;
}

var city = string.Join(' ', args).Trim();

if (!(city is { Length: > 0 } && new Regex("[a-zA-Z\\s,]{1,100}").IsMatch(city)))
{
    WriteLine("Please provide a valid city name!");
    return;
}

using var client = new HttpClient();

WriteLine($"Fetching data for city {city}...");

try
{
    var response = await client.GetAsync($"https://weatherdbi.herokuapp.com/data/weather/{city}");

    PrnSep();

    if (!response.IsSuccessStatusCode)
    {
        WriteLine("It appears that the API cannot be of service at this time! Try again later...");
        return;
    }

    var result = await response.Content.ReadFromJsonAsync<Response>();

    if (result.Region?.Trim() is not { Length: > 0 } region)
    {
        WriteLine($"It appears that the API does not recognize city {city}! Try again with a different city...");
        return;
    }

    var cc = result.CurrentConditions;

    WriteLine(
@$"Requested city: {city}
Region: {region}
Date and Time: {cc.Dayhour}
Temperature: {cc.Temp.C} °C
Humidity: {cc.Humidity}
Precipation: {cc.Precip}"
    );
}
catch
{
    WriteLine("Whoops, something went wrong...");
    throw;
}

static void PrnSep() => WriteLine("---------------------");