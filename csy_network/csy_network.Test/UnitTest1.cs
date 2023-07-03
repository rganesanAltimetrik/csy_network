using csy_network;
using csy_network.Controllers;
using Microsoft.Extensions.Logging;
using Moq;

namespace csy_network.Test
{
    [TestClass]
    public class UnitTest1
    {
        private Mock<ILogger<WeatherForecastController>> _logger;

        [TestInitialize]
        public void TestInitialize()
        {
            _logger = new Mock<ILogger<WeatherForecastController>>();
        }

        [TestMethod]
        public void TestMethod1()
        {
            WeatherForecastController controll = new WeatherForecastController(_logger.Object);
            List<WeatherForecast> result = controll.Get().ToList();
            Assert.IsNotNull(result);
        }
    }
}