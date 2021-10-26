using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController _controller = new WeatherForecastController();

        [Fact]
        public void CelciusConvertsToFahrenheit()
        {
            var freezingTemperature = _controller.GetFahrenheitTemperature(0);
            Assert.Equal(32, freezingTemperature);
        }
    }
}
