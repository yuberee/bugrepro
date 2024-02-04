using Sandbox;

public sealed class InheritedComponentSecond : OriginalComponent
{
	public override void PrintSomething()
	{
		Log.Info( "Haha, but I'm the second!" );
	}
}
