namespace MoveIt.Sdk.Tires
{
	public sealed class WinterTireSpec : TireSpec
	{
		public WinterTireSpec(TirePressure pressure, TireTemperature minimumTemperature, TireThickness thickness)
			: base(pressure)
		{
			this.MinimumTemperature = minimumTemperature;
			this.Thickness = thickness;
		}

		public override TireType Type => TireType.Winter;

		public TireTemperature MinimumTemperature { get; }

		public TireThickness Thickness { get; }

		public override string GetInfo() => $"{base.GetInfo()}, Min Temp: {this.MinimumTemperature}, Thickness: {this.Thickness}";
	}
}