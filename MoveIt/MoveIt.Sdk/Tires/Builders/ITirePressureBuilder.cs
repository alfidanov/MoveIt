namespace MoveIt.Sdk.Tires.Builders
{
	public interface ITirePressureBuilder<T>
	{
		T TirePressure(double pressure, TirePressureUnitType type);
	}
}
