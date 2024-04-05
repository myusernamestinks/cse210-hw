using System;

public class OutdoorGathering : Event
{
    private string[] _weatherConditions = { "Sunny", "Cloudy", "Rainy", "Windy", "Snowy" };
    private Random _random = new Random();
    private string _weatherForecast;

    public OutdoorGathering(string title, string description, DateTime date, string time, Address address)
        : base(title, description, date, time, address)
    {
        _weatherForecast = GetRandomWeatherCondition();
    }

    private string GetRandomWeatherCondition()
    {
        int index = _random.Next(_weatherConditions.Length);
        return _weatherConditions[index];
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nWeather Forecast: {_weatherForecast}";
    }
}
