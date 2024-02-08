using MoveIt.UnitTests.Factories;

namespace MoveIt.UnitTests.VehicleTests
{
	internal class MotorcycleMove_Should : BaseVehicleTest<IMotorcycle>
	{
		[SetUp]
		public void Setup()
		{
			this.SuT = ModelFactory.CreateMotorcycle("Maker");
		}

		[Test]
		public void MoveMotorcycle()
		{
			// Act
			this.SuT.Move();

			// Assert
			Assert.That(this.ConsoleOutput.ToString().Trim(), Is.EqualTo("Your are driving a motorcycle from Maker"));
		}
	}
}