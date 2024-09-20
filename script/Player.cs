using Godot;

public partial class Player : CharacterBody2D
{
	[ExportCategory("Player movement")]
	[Export] public float MaxSpeed = 80f; 
	[Export] public float Acceleration = 2.5f;
	[Export] public float SpeedStopMotion = 25f;
	[Export] public float RotationSpeed = 0.15f;

	public Vector2 Motion = Vector2.Zero;
	public Vector2 Direction = Vector2.Zero;
	
    public override void _PhysicsProcess(double delta)
	{
		Direction = Input.GetVector("uc_left", "uc_right", "uc_up", "uc_down");

		if(Direction != Vector2.Zero)
		{
			AccelerationCharacter();
			RotateCharacter(); 
		}
		else
		{
			DecelerationCharacter();
		}
	
		MoveAndCollide(Motion * (float)delta, false, 0.08f, false);
	}

	public void AccelerationCharacter()
	{
		Motion.X = Mathf.MoveToward(Motion.X, MaxSpeed * Direction.X, SpeedStopMotion);
		Motion.Y = Mathf.MoveToward(Motion.Y, MaxSpeed * Direction.Y, SpeedStopMotion);
	}

	public void DecelerationCharacter()
	{
		Motion.X = Mathf.MoveToward(Motion.X, 0, SpeedStopMotion);
		Motion.Y = Mathf.MoveToward(Motion.Y, 0, SpeedStopMotion);
	}

	public void RotateCharacter()
	{
		Rotation = Mathf.RotateToward(Rotation, Motion.Angle(), RotationSpeed);
	}
}
