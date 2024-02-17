using System;
using Sandbox;

public enum BeltDirection
{
	Forward,
	Backward,
	Left,
	Right
}

public sealed class ConveyorBelt : Component
{
	[Property] 
	public BeltDirection Direction { get; set; } = BeltDirection.Forward;
	
	[Property]
	public float Speed { get; set; } = 3f;
	

	protected override void OnFixedUpdate()
	{
		var body = Components.Get<Collider>().KeyframeBody;

		var rotation = Transform.Rotation.Forward;

		switch ( Direction )
		{
			case BeltDirection.Forward:
				rotation = Transform.Rotation.Forward;
				break;
			case BeltDirection.Backward:
				rotation = Transform.Rotation.Backward;
				break;
			case BeltDirection.Right:
				rotation = Transform.Rotation.Right;
				break;
			case BeltDirection.Left:
				rotation = Transform.Rotation.Left;
				break;
		}
		body.Position += rotation * Speed;
		body.Move( Transform.World, Time.Delta );
	}
}
