namespace MoveIt.Sdk.Vehicles
{
	public sealed class CarFactory
	{
		internal CarFactory() { }

		public ICar CreateToyota()
		{
			return new Car("Toyota");
		}

		public ICar CreateHonda()
		{
			return new Car("Honda");
		}
	}
}