namespace MoveIt.Sdk.Vehicles
{
	public sealed class MotorcycleFactory
	{
		internal MotorcycleFactory() { }

		public IMotorcycle CreateHonda()
		{
			return new Motorcycle("Honda");
		}

		public IMotorcycle CreateKtm()
		{
			return new Motorcycle("KTM");
		}
	}
}