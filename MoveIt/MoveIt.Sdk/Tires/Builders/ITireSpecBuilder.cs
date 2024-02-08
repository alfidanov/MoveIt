namespace MoveIt.Sdk.Tires.Builders
{
	public interface ITireSpecBuilder
	{
		ITirePressureBuilder<ISummerTireMaxTemperatureBuilder> Summer();

		ITirePressureBuilder<IWinterTireMinTemperatureBuilder> Winter();
	}
}
