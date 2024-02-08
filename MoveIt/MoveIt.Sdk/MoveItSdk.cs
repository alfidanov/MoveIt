using MoveIt.Sdk.Vehicles;

namespace MoveIt.Sdk
{
	public class MoveItSdk
	{
		public CarFactory Cars { get; } = new CarFactory();

		public MotorcycleFactory Motorcycles { get; } = new MotorcycleFactory();

	}
}