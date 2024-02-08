using MoveIt.Sdk;
using MoveIt.Sdk.Tires;

namespace MoveIt
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var sdk = new MoveItSdk();
			
			var toyota = sdk.Cars.CreateToyota();
			toyota.Move();

			toyota.ChangeTires(
				new SummerTireSpec(
					new TirePressure(3.0, TirePressureUnitType.Bar),
					new TireTemperature(60, TireTemperatureUnitType.Celsius)));
			toyota.Move();

			var honda = sdk.Cars.CreateHonda()
									.ChangeTires(
										new WinterTireSpec(
											new TirePressure(2.2, TirePressureUnitType.Bar),
											new TireTemperature(20, TireTemperatureUnitType.Celsius),
											new TireThickness(8, TireThicknessType.Millimeters)));
			honda.Move();

			honda.ChangeTires(b => b.Summer()
									.TirePressure(2.4, TirePressureUnitType.Bar)
									.MaxTemperature(50, TireTemperatureUnitType.Celsius)
									.Build());

			honda.Move();

			honda.ChangeTires(b => b.Winter()
								   .TirePressure(2.2, TirePressureUnitType.Psi)
								   .MinTemperature(-5, TireTemperatureUnitType.Celsius)
								   .Thickness(4, TireThicknessType.Millimeters)
								   .Build());
			honda.Move();

			var ktm = sdk.Motorcycles.CreateKtm();
			ktm.Move();

			Console.ReadKey();
		}
	}
}