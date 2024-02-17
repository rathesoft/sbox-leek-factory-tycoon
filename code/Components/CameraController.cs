using Sandbox;

[Category("Leek Factory")]
[Icon("video_call")]
public sealed class CameraController : Component
{
	public Vector3 WishVelocity { get; set; }

	[Property]
	private float MoveSpeed { get; set; } = 600f;

	protected override void OnFixedUpdate()
	{
		base.OnFixedUpdate();

		// Get input values
		float horizontalInput = Input.AnalogMove.x;
		float verticalInput = Input.AnalogMove.y;

		// Calculate movement direction
		Vector3 movement = new Vector3(0, verticalInput, 0).Normal;

		// Move the camera
		MoveCamera(movement);
	}
	
	private void MoveCamera(Vector3 direction)
	{
		// Calculate the new position
		Vector3 newPosition = Transform.Position + (direction * MoveSpeed * Time.Delta);

		// Apply the new position
		Transform.Position = new Vector3(Transform.Position.x, newPosition.y, Transform.Position.z);
	}

}
