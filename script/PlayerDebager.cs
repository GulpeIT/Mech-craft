using Godot;

public partial class PlayerDebager : Node2D
{
	[ExportCategory("Need component")]
	[Export] public Player player;

	public override void _Draw()
	{
		DrawCircle(player.Motion, 10f, Color.Color8(255, 255, 255, 255), false, 1f, false);
		DrawLine(Vector2.Zero, player.Motion, Color.Color8(255, 255, 255, 255), 1, false);

		DrawCircle(Vector2.FromAngle(player.Rotation) * player.MaxSpeed, 5f, Color.Color8(0, 255, 0, 255), false, 1f, false);
	}

	public override void _Process(double delta)
	{
		Position = player.Position;
		QueueRedraw();
	}
}
