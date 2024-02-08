namespace MoveIt.UnitTests.VehicleTests
{
	internal class BaseVehicleTest<T> where T : IVehicle
	{
		protected StringWriter ConsoleOutput { get; private set; }

		protected T SuT { get; set; }

		[SetUp]
		public void SetupTest()
		{
			this.ConsoleOutput = new StringWriter();
			Console.SetOut(this.ConsoleOutput);
		}
	}
}
