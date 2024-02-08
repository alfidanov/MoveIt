namespace MoveIt.Sdk.Tires
{
	public struct TireThickness
	{
		public TireThickness(double unit, TireThicknessType type)
		{
			if (unit < 0)
			{
				throw new ArgumentException("Tire thickness must be greater than 0.", nameof(unit));
			}

			this.Unit = unit;
			this.UnitType = type;
		}

		public double Unit { get; }

		public TireThicknessType UnitType { get; }

		public override string ToString() => $"{this.Unit} {this.UnitType}";
	}
}
