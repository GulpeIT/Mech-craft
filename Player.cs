using Godot;

public partial class Player : CharacterBody2D
{
	[ExportCategory("Player movement")]
	[Export] public float CharacterMaxSpeed = 80f; 
	[Export] public float CharacterAcceleration = 0.5f;

	public override void _Ready()
	{

	}
	//TODO: Сделать прикол типа игрок такой уууу буду гнать,
	// а потом ему надо тормозить,
	// а трение такое ооооо не дам и он медленно тормозит и меняет угол поворота
	
	//TODO: Сделать прикол, типа перс медленно разворачивается и типа на это влияет что-то
	// там типа какие-то ебучие множители и так далее я ваще хз че делаю xdd секс фури насилие.

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _PhysicsProcess(double delta)
    {
		Velocity = CharacterMaxSpeed * GetDirection();
		LookAt(GetGlobalMousePosition());

		GD.Print(Velocity);
		MoveAndSlide();	
    }

    private Vector2 GetDirection()
	{
		Vector2 dir = new Vector2(0, 0);
		dir.X = Input.GetAxis("uc_left", "uc_right");
		dir.Y = Input.GetAxis("uc_up", "uc_down"); 
		return dir.Normalized();
	}
}
