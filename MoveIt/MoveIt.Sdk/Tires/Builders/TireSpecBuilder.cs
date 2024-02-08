namespace MoveIt.Sdk.Tires.Builders
{
	internal class TireSpecBuilder : ITireSpecBuilder
	{
		public ITirePressureBuilder<ISummerTireMaxTemperatureBuilder> Summer() => new SummerTireSpecBuilder();

		public ITirePressureBuilder<IWinterTireMinTemperatureBuilder> Winter() => new WinterTireSpecBuilder();
	}
}
