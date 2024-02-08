namespace MoveIt.Sdk.Tires.Builders
{
	internal class WinterTireSpecBuilder : ITirePressureBuilder<IWinterTireMinTemperatureBuilder>, IWinterTireThicknessBuilder, IWinterTireMinTemperatureBuilder, ITireBuilder<WinterTireSpec>
	{
		private TirePressure pressure;
		private TireTemperature minTemp;
		private TireThickness thickness;

		public WinterTireSpec Build()
		{
			return new WinterTireSpec(this.pressure, this.minTemp, this.thickness);
		}

		public IWinterTireThicknessBuilder MinTemperature(double unit, TireTemperatureUnitType type)
		{
			this.minTemp = new TireTemperature(unit, type);
			return this;
		}

		public ITireBuilder<WinterTireSpec> Thickness(double unit, TireThicknessType type)
		{
			this.thickness = new TireThickness(unit, type);
			return this;
		}

		public IWinterTireMinTemperatureBuilder TirePressure(double pressure, TirePressureUnitType type)
		{
			this.pressure = new TirePressure(pressure, type);
			return this;
		}
	}
}
