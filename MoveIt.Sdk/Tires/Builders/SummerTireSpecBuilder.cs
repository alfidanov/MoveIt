namespace MoveIt.Sdk.Tires.Builders
{
	internal class SummerTireSpecBuilder : ITirePressureBuilder<ISummerTireMaxTemperatureBuilder>, ISummerTireMaxTemperatureBuilder, ITireBuilder<SummerTireSpec>
	{
		private TirePressure pressure;
		private TireTemperature maxTemp;

		public SummerTireSpec Build()
		{
			return new SummerTireSpec(this.pressure, this.maxTemp);
		}

		public ITireBuilder<SummerTireSpec> MaxTemperature(double unit, TireTemperatureUnitType type)
		{
			this.maxTemp = new TireTemperature(unit, type);
			return this;
		}

		public ISummerTireMaxTemperatureBuilder TirePressure(double pressure, TirePressureUnitType type)
		{
			this.pressure = new TirePressure(pressure, type);
			return this;
		}
	}
}
