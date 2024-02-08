using MoveIt.Sdk.Tires;
using MoveIt.Sdk.Tires.Builders;

namespace MoveIt.Sdk.Vehicles
{
	internal class Car : ICar
	{
		private readonly string maker;

		public Car(string maker)
		{
			if (string.IsNullOrEmpty(maker))
			{
				throw new ArgumentNullException(nameof(maker));
			}

			this.maker = maker;
			this.TireSpecs = new SummerTireSpec();
		}

		public TireSpec TireSpecs { get; private set; }

		public ICar ChangeTires(TireSpec tireSpecs)
		{
			this.TireSpecs = tireSpecs;
			return this;
		}

		public ICar ChangeTires(Func<ITireSpecBuilder, TireSpec> tireConfigurator)
		{
			this.ChangeTires(tireConfigurator(new TireSpecBuilder()));
			return this;
		}

		public virtual void Move()
		{
			Console.WriteLine($"Your are driving a car from {this.maker}. Types - {this.TireSpecs.GetInfo()}");
		}
	}
}