namespace MoveIt.Sdk.Tires
{
	public struct TirePressure
	{
		public TirePressure(double unit, TirePressureUnitType type)
		{
			if (unit < 0)
			{
				throw new ArgumentException("Tire pressure must be greater than 0.", nameof(unit));
			}

			this.Unit = unit;
			this.UnitType = type;
		}

		public double Unit { get; }

		public TirePressureUnitType UnitType { get; }

		public override string ToString() => $"{this.Unit} {this.UnitType}";
	}
}