using CleanArchitecture.Domain.Enums;
using System;

namespace CleanArchitecture.Domain.Entities
{
    public class WeatherForecast
    {
        public Guid Id { get; set; }

        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public WeatherForecastSummary Summary { get; set; }
    }
}
