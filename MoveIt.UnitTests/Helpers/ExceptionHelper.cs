namespace MoveIt.UnitTests.Helpers
{
	internal class ExceptionHelper
	{
		public static bool Catch<T>(Action action, out T ex) where T : Exception
		{
			try
			{
				action();
			}
			catch (T exception)
			{
				ex = exception;
				return true;
			}
			ex = null;
			return false;
		}
	}
}
