namespace MoveIt.Sdk.Tires.Builders
{
	public interface ISummerTireMaxTemperatureBuilder
	{
		ITireBuilder<SummerTireSpec> MaxTemperature(double unit, TireTemperatureUnitType type);
	}
}
