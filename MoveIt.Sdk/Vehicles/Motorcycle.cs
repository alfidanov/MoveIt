namespace MoveIt.Sdk.Vehicles
{
	internal class Motorcycle : IMotorcycle
	{
		private readonly string maker;

		public Motorcycle(string maker)
		{
			if (string.IsNullOrEmpty(maker))
			{
				throw new ArgumentNullException(nameof(maker));
			}

			this.maker = maker;
		}

		public void Move()
		{
			Console.WriteLine($"Your are driving a motorcycle from {this.maker}");
		}
	}
}