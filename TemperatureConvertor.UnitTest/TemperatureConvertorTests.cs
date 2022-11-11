using NUnit.Framework;

namespace TemperatureConvertor.UnitTest
{
    public class TemperatureConvertorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(10,50)]
        [TestCase(-40, -40)]
        [TestCase(108, 226.4)]
        public void ToFarenheit(decimal degreeCelsius, decimal expectedDegreeFarenheit)
        {
            //Arrange
            TemperatureConvertor temperatureConvertor = new TemperatureConvertor();
            //Act
            decimal convertedDegreeFarenheit = temperatureConvertor.TemperatureF(degreeCelsius);
            //Assert
            Assert.That(convertedDegreeFarenheit == expectedDegreeFarenheit);
        }

        [Test]
        [TestCase(50, 10)]
        [TestCase(-40, -40)]
        [TestCase(226.4, 108)]
        public void ToCelsius(decimal degreeFarenheit, decimal expectedDegreeCelsius)
        {
            //Arrange
            TemperatureConvertor temperatureConvertor = new TemperatureConvertor();
            //Act
            decimal convertedDegreeCelsius = temperatureConvertor.TemperatureC(degreeFarenheit);
            //Assert
            Assert.That(convertedDegreeCelsius == expectedDegreeCelsius);
        }

    }
}