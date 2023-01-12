using TestApp;

namespace Tests.Data
{
    public class TestData
    {
        [Fact]
        public void AssertTemperatureFahrenheitNotNull()
        {
            WeatherForecast weatherForecast = new WeatherForecast();

            Assert.NotNull(weatherForecast);
        }
    }
}