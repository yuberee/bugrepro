using Sandbox;

public sealed class ParentComponent : Component
{
	[Property]
	public OriginalComponent Component1 { get; set; }

	[Property]
	public OriginalComponent Component2 { get; set; }

	protected override void OnStart()
	{
		Component1.PrintSomething();
		Component2.PrintSomething();
	}
}
