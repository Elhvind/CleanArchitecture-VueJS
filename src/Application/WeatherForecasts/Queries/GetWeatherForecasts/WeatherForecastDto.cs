using CleanArchitecture.Application.Common.Mappings;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.WeatherForecasts.Queries.GetWeatherForecasts;

public class WeatherForecastDto : IMapFrom<WeatherForecast>
{
    public Guid Id { get; set; }

    public DateTime Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF { get; set; }

    public int Summary { get; set; }
}
