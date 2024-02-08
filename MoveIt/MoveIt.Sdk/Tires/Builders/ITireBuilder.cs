namespace MoveIt.Sdk.Tires.Builders
{
	public interface ITireBuilder<T> where T: TireSpec
	{
		T Build();
	}
}
