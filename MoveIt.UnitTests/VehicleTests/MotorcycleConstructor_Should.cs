using MoveIt.UnitTests.Helpers;

namespace MoveIt.UnitTests.VehicleTests
{
	internal class MotorcycleConstructor_Should
    {
        [Test]
        public void ThrowException_WhenMakerIsNull()
        {
            // Act
            var result = ExceptionHelper.Catch(() => new Motorcycle(null), out ArgumentNullException ex);

            // Assert
            Assert.That(result, Is.True);
            Assert.That(ex.ParamName, Is.EqualTo("maker"));
        }

        [Test]
        public void ThrowException_WhenMakerIsEmpty()
        {
            // Act
            var result = ExceptionHelper.Catch(() => new Motorcycle(string.Empty), out ArgumentNullException ex);

            // Assert
            Assert.That(result, Is.True);
            Assert.That(ex.ParamName, Is.EqualTo("maker"));
        }
    }
}