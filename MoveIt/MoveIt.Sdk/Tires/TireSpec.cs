namespace MoveIt.Sdk.Tires
{
	public abstract class TireSpec
	{
		public TireSpec(TirePressure pressure)
		{
			this.Pressure = pressure;
		}

		public abstract TireType Type { get; }

		public TirePressure Pressure { get; }

		public virtual string GetInfo() => $"{this.Type} tires at {this.Pressure}";
	}
}