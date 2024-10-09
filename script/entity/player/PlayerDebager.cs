using Godot;
using component;

public partial class PlayerDebager : Node2D
{
	[ExportCategory("Need component")]
	[Export]
	public Player Player;

	public override void _Draw()
	{
		DrawCircle(Player._Motion, 10f, Color.Color8(255, 255, 255, 255), false, 1f, false);
		DrawLine(Vector2.Zero, Player._Motion, Color.Color8(255, 255, 255, 255), 1, false);
	}

	public override void _Process(double delta)
	{
		Position = Player.Position;
		QueueRedraw();
	}
}
