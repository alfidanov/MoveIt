using MoveIt.UnitTests.Factories;

namespace MoveIt.UnitTests.TireTests
{
	internal class SummerTireSpecConstructor_Should
	{
		[Test]
		public void SetDefaultSpecValues()
		{
			// Act
			var tire = ModelFactory.CreateSummerTire();

			// Assert
			Assert.That(tire.Pressure.Unit, Is.EqualTo(2.5));
			Assert.That(tire.Pressure.UnitType, Is.EqualTo(TirePressureUnitType.Bar));

			Assert.That(tire.MaxTemperature.Unit, Is.EqualTo(50));
			Assert.That(tire.MaxTemperature.UnitType, Is.EqualTo(TireTemperatureUnitType.Celsius));
		}

		[Test]
		public void SetPressure()
		{
			// Act
			var tire = new SummerTireSpec(new TirePressure(10, TirePressureUnitType.Bar), ModelFactory.Temp);

			// Assert
			Assert.That(tire.Pressure.Unit, Is.EqualTo(10));
			Assert.That(tire.Pressure.UnitType, Is.EqualTo(TirePressureUnitType.Bar));
		}


		[Test]
		public void SetTemperature()
		{
			// Act
			var tire = new SummerTireSpec(ModelFactory.Pressure, new TireTemperature(10, TireTemperatureUnitType.Fahrenheit));

			// Assert
			Assert.That(tire.MaxTemperature.Unit, Is.EqualTo(10));
			Assert.That(tire.MaxTemperature.UnitType, Is.EqualTo(TireTemperatureUnitType.Fahrenheit));
		}
	}
}
