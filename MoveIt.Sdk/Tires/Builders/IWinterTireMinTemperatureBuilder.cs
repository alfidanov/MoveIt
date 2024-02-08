namespace MoveIt.Sdk.Tires.Builders
{
	public interface IWinterTireMinTemperatureBuilder
	{
		IWinterTireThicknessBuilder MinTemperature(double unit, TireTemperatureUnitType type);
	}
}
