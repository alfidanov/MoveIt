using MoveIt.UnitTests.Helpers;

namespace MoveIt.UnitTests.VehicleTests
{
	internal class CarConstructor_Should
    {
        [Test]
        public void ThrowException_WhenMakerIsNull()
        {
            // Act
            var result = ExceptionHelper.Catch(() => new Car(null), out ArgumentNullException ex);

            // Assert
            Assert.That(result, Is.True);
            Assert.That(ex.ParamName, Is.EqualTo("maker"));
        }

        [Test]
        public void ThrowException_WhenMakerIsEmpty()
        {
            // Act
            var result = ExceptionHelper.Catch(() => new Car(string.Empty), out ArgumentNullException ex);

            // Assert
            Assert.That(result, Is.True);
            Assert.That(ex.ParamName, Is.EqualTo("maker"));
        }

        [Test]
        public void Initialize_DefaultTires()
        {
            // Act
            var car = new Car("Maker");

            // Assert
            Assert.That(car.TireSpecs, Is.Not.Null);
        }
    }
}