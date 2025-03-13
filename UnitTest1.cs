using EcoEnergyRazor.Models;

namespace EcoEnergyRazor.Tests
{
    public class SolarSystemTests
    {
        [Theory]
        [InlineData(5, 7.5)]
        [InlineData(8, 12.0)]
        [InlineData(12.5, 18.75)]
        public void EnergyCalculation(double sunHours, double expectedEnergy)
        {
            // Arrange
            var solarSystem = new SolarSystem(sunHours, 10, 1.2, 5);
            // Act
            double actualEnergy = solarSystem.Energy;
            // Assert
            Assert.Equal(expectedEnergy, actualEnergy);
        }

        [Theory]
        [InlineData(5, 5, 37.5)]
        [InlineData(8, 7, 84.0)]
        [InlineData(12.5, 10, 187.5)]
        public void CalculateTotalCost(double sunHours, double cost, double expectedCost)
        {
            // Arrange
            var solarSystem = new SolarSystem(sunHours, 10, 1.2, cost);
            // Act
            double actualTotalCost = solarSystem.TotalCost;
            // Assert
            Assert.Equal(expectedCost, actualTotalCost);
        }

        [Theory]
        [InlineData(5, 10, 75.0)]
        [InlineData(8, 12, 144.0)]
        [InlineData(12.5, 15, 281.25)]
        public void CalculateTotalPrice(double sunHours, double price, double expectedPrice)
        {
            // Arrange
            var solarSystem = new SolarSystem(sunHours, price, 1.2, 5);
            // Act
            double actualTotalPrice = solarSystem.TotalPrice;
            // Assert
            Assert.Equal(expectedPrice, actualTotalPrice);
        }
    }
}
