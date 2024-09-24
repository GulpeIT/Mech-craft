using Godot;
using components;

public partial class PlayerDebager : Node2D
{
	[ExportCategory("Need component")]
	[Export]
	public Player Player;
	[Export]
	public HealthComponent HealthComponent;

	private Label HealthLabel;

	public override void _Draw()
	{
		DrawCircle(Player._Motion, 10f, Color.Color8(255, 255, 255, 255), false, 1f, false);
		DrawLine(Vector2.Zero, Player._Motion, Color.Color8(255, 255, 255, 255), 1, false);

		DrawCircle(Vector2.FromAngle(Player.Rotation) * Player._MaxSpeed, 5f, Color.Color8(0, 255, 0, 255), false, 1f, false);
	}
	
	public override void _Ready()
	{
		HealthLabel = GetNode<Label>("LabelHealthPoint");
		HealthLabel.Text = $"now HP = {HealthComponent._CurrentHealth}" ;
	}

	public override void _Process(double delta)
	{
		Position = Player.Position;
		QueueRedraw();
	}
}
