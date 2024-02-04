using Sandbox;

public sealed class InheritedComponentFirst : OriginalComponent
{
	public override void PrintSomething()
	{
		Log.Info( "Nice to meet you, I'm the first" );
	}
}
