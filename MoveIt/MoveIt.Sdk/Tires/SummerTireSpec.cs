namespace MoveIt.Sdk.Tires
{
	public sealed class SummerTireSpec : TireSpec
	{
		public SummerTireSpec()
			: this(new TirePressure(2.5, TirePressureUnitType.Bar), new TireTemperature(50, TireTemperatureUnitType.Celsius))
		{
		}

		public SummerTireSpec(TirePressure pressure, TireTemperature maxTemperature) : base(pressure)
		{
			this.MaxTemperature = maxTemperature;
		}

		public override TireType Type => TireType.Summer;

		public TireTemperature MaxTemperature { get; }

		public override string GetInfo() => $"{base.GetInfo()}, Max Temp: {this.MaxTemperature}";
	}
}