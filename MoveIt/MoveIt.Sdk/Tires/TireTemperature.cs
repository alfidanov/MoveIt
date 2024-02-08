namespace MoveIt.Sdk.Tires
{
    public struct TireTemperature
    {
        public TireTemperature(double unit, TireTemperatureUnitType type)
        {
			this.Unit = unit;
			this.UnitType = type;
        }

        public double Unit { get; }

        public TireTemperatureUnitType UnitType { get; }

        public override string ToString() => $"{this.Unit} {this.UnitType}";
    }
}