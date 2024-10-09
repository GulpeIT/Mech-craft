using Godot;

public partial class Player : CharacterBody2D
{
	[ExportCategory("Player movement")]
	[Export] 
	public float _MaxSpeed = 80f; 
	[Export] 
	public float _Acceleration = 2.5f;
	[Export] 
	public float _SpeedStopMotion = 25f;

	public Vector2 _Motion = Vector2.Zero;
	public Vector2 _Direction = Vector2.Zero;

    public override void _PhysicsProcess(double delta)
	{
		_Direction = Input.GetVector("uc_left", "uc_right", "uc_up", "uc_down");

		if(_Direction != Vector2.Zero)
		{
			
			AccelerationCharacter();
		}
		else
		{
			DecelerationCharacter();
		}

		MoveAndCollide(_Motion * (float)delta, false, 0.08f, true);
	}

	//ToDo:  при использование мышки или геймпада, персонаж наблюдает за точкой. Если игрок не пользуется мышкой или геймпадом
	// то персонаж поворачивается в сторону движения.

	//TODO: переместить в компонент movement, добавить поля для инкапсуляции:
	//1)
	private void AccelerationCharacter()
	{
		_Motion.X = Mathf.MoveToward(_Motion.X, _MaxSpeed * _Direction.X, _Acceleration);
		_Motion.Y = Mathf.MoveToward(_Motion.Y, _MaxSpeed * _Direction.Y, _Acceleration);
	}
	//2)
	private void DecelerationCharacter()
	{
		_Motion.X = Mathf.MoveToward(_Motion.X, 0, _SpeedStopMotion);
		_Motion.Y = Mathf.MoveToward(_Motion.Y, 0, _SpeedStopMotion);
	}
}
