using MoveIt.Sdk.Tires;
using MoveIt.Sdk.Tires.Builders;

namespace MoveIt.Sdk
{
    public interface ICar : IVehicle
    {
        TireSpec TireSpecs { get; }

        ICar ChangeTires(TireSpec tireSpecs);

		ICar ChangeTires(Func<ITireSpecBuilder, TireSpec> tireConfigurator);
	}
}