using System.Collections.Generic;
using todolist_aspcore.Models;

namespace todolist_aspcore.Providers
{
    public interface IWeatherProvider
    {
        List<WeatherForecast> GetForecasts();
    }
}
