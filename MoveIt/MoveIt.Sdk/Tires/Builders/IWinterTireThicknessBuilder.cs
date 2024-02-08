namespace MoveIt.Sdk.Tires.Builders
{
	public interface IWinterTireThicknessBuilder
	{
		ITireBuilder<WinterTireSpec> Thickness(double unit, TireThicknessType type);
	}
}
