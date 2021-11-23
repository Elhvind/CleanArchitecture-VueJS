namespace CleanArchitecture.Domain.Entities;

public class WeatherForecast : Entity, IHasDomainEvent
{
    public DateTime Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public WeatherForecastSummary Summary { get; set; }

    public List<DomainEvent> DomainEvents { get; set; } = new List<DomainEvent>();
}
