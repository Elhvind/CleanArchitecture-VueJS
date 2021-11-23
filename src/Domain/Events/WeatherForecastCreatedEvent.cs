namespace CleanArchitecture.Domain.Events;

public class WeatherForecastCreatedEvent : DomainEvent
{
    public WeatherForecastCreatedEvent(WeatherForecast forecast)
    {
        Forecast = forecast;
    }

    public WeatherForecast Forecast { get; }
}
