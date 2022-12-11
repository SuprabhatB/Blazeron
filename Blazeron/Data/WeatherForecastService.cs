namespace Blazeron.Data
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines the <see cref="WeatherForecastService" />.
    /// </summary>
    public class WeatherForecastService
    {
        /// <summary>
        /// The summaries
        /// </summary>
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        /// <summary>
        /// Gets the forecast asynchronous.
        /// </summary>
        /// <param name="startDate">The startDate<see cref="DateTime"/>.</param>
        /// <returns>The <see cref="Task{WeatherForecast[]}"/>.</returns>
        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToArray());
        }
    }
}
