# Weather CLI

Simple console app that fetches the current weather for a specified city.

## Run

```bash
# Gets the weather
dotnet run -- <city_name>
# Help!
dotnet run -- -h
```

## Create a package

```bash
dotnet pack
```

## Install a local package as global tool

```bash
dotnet tool install --global --add-source ./nupkg weather-cli
```

## Uninstall a local package installed as a global tool

```bash
dotnet tool uninstall weather-cli --global
```

## Running once installed

```bash
# Help
dotnet-weather -h
dotnet weather -h
# Gets the weather!
dotnet-weather New York
dotnet weather New York, NY
```
