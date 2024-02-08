using MoveIt.UnitTests.Factories;

namespace MoveIt.UnitTests.VehicleTests
{
	internal class CarMove_Should : BaseVehicleTest<ICar>
	{
		[SetUp]
		public void Setup()
		{
			this.SuT = ModelFactory.CreateCar("Maker");
		}

		[Test]
		public void MoveCar_WithDefaultTires()
		{
			// Act
			this.SuT.Move();

			// Assert
			Assert.That(this.ConsoleOutput.ToString().Trim(), Is.EqualTo("Your are driving a car from Maker. Types - Summer tires at 2.5 Bar, Max Temp: 50 Celsius"));
		}

		[Test]
		public void MoveCar_WithSummerTires()
		{
			// Arrange
			this.SuT.ChangeTires(b => b.Summer()
									   .TirePressure(3, TirePressureUnitType.Bar)
									   .MaxTemperature(55, TireTemperatureUnitType.Celsius)
									   .Build());

			// Act
			this.SuT.Move();

			// Assert
			Assert.That(this.ConsoleOutput.ToString().Trim(), Is.EqualTo("Your are driving a car from Maker. Types - Summer tires at 3 Bar, Max Temp: 55 Celsius"));
		}

		[Test]
		public void MoveCar_WithWinterTires()
		{
			// Arrange
			this.SuT.ChangeTires(b => b.Winter()
									   .TirePressure(2.2, TirePressureUnitType.Bar)
									   .MinTemperature(-20, TireTemperatureUnitType.Celsius)
									   .Thickness(8, TireThicknessType.Millimeters)
									   .Build());

			// Act
			this.SuT.Move();

			// Assert
			Assert.That(this.ConsoleOutput.ToString().Trim(), Is.EqualTo("Your are driving a car from Maker. Types - Winter tires at 2.2 Bar, Min Temp: -20 Celsius, Thickness: 8 Millimeters"));
		}
	}
}