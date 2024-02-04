using Sandbox;

public abstract class OriginalComponent : Component
{
	public virtual void PrintSomething()
	{
		Log.Info( "Hello, I'm the original" );
	}
}
