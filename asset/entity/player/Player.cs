using Godot;

public partial class Player : CharacterBody2D
{
	[ExportCategory("Player movement")]
	[Export] 
	public float MaxSpeed = 80f; 
	[Export] 
	public float Acceleration = 2.5f;
	[Export] 
	public float SpeedStopMotion = 25f;
	[Export(PropertyHint.Range, "0, 3.5, 0.2")] 
	public float RotationSpeed = 0.15f;

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
	
		MoveAndCollide(Motion * (float)delta, false, 0.08f, true);
	}

	//ToDo:  при использование мышки или геймпада, персонаж наблюдает за точкой. Если игрок не пользуется мышкой или геймпадом
	// то персонаж поворачивается в сторону движения.

	//TODO: переместить в компонент movement, добавить поля для инкапсуляции:
	//1)
	private void AccelerationCharacter()
	{
		Motion.X = Mathf.MoveToward(Motion.X, MaxSpeed * Direction.X, SpeedStopMotion);
		Motion.Y = Mathf.MoveToward(Motion.Y, MaxSpeed * Direction.Y, SpeedStopMotion);
	}
	//2)
	private void DecelerationCharacter()
	{
		Motion.X = Mathf.MoveToward(Motion.X, 0, SpeedStopMotion);
		Motion.Y = Mathf.MoveToward(Motion.Y, 0, SpeedStopMotion);
	}
	//3)
	//Use lerp add smooth rotation
	private void RotateCharacter() => Rotation = Mathf.LerpAngle(Rotation, Motion.Angle(), RotationSpeed); 
	
}
