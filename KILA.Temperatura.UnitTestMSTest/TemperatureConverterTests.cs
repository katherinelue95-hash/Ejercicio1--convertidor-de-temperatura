using KILA.Temperatura;

namespace KILA.Temperatura.UnitTestMSTest
{
    [TestClass]
    public class TemperatureConverterTests
    {
        [TestMethod]
        public void CelsiusToFahrenheit_FreezingPoint_Returns32()
        {
            TemperatureConverter converter = new TemperatureConverter();

            double result = converter.CelsiusToFahrenheit(0);

            Assert.AreEqual(32, result);
        }

        [TestMethod]
        public void CelsiusToFahrenheit_BoilingPoint_Returns212()
        {
            TemperatureConverter converter = new TemperatureConverter();

            double result = converter.CelsiusToFahrenheit(100);

            Assert.AreEqual(212, result);
        }

        [TestMethod]
        public void CelsiusToFahrenheit_BodyTemperature_Returns98Point6()
        {
            TemperatureConverter converter = new TemperatureConverter();

            double result = converter.CelsiusToFahrenheit(37);

            Assert.AreEqual(98.6, result, 0.0001);
        }

        [TestMethod]
        public void FahrenheitToCelsius_FreezingPoint_Returns0()
        {
            TemperatureConverter converter = new TemperatureConverter();

            double result = converter.FahrenheitToCelsius(32);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void FahrenheitToCelsius_BoilingPoint_Returns100()
        {
            TemperatureConverter converter = new TemperatureConverter();

            double result = converter.FahrenheitToCelsius(212);

            Assert.AreEqual(100, result);
        }
    }
}
