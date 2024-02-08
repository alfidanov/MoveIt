namespace MoveIt.UnitTests.Factories
{
	internal class ModelFactory
	{
		public static readonly TireTemperature Temp = new TireTemperature(1, TireTemperatureUnitType.Celsius);
		public static readonly TirePressure Pressure = new TirePressure(2, TirePressureUnitType.Bar);

		public static ICar CreateCar(string maker)
		{
			return new Car(maker);
		}

		public static IMotorcycle CreateMotorcycle(string maker)
		{
			return new Motorcycle(maker);
		}

		public static SummerTireSpec CreateSummerTire()
		{
			return new SummerTireSpec();
		}
	}
}
