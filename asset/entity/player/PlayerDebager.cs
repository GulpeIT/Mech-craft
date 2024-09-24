using Godot;

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
		DrawCircle(Player.Motion, 10f, Color.Color8(255, 255, 255, 255), false, 1f, false);
		DrawLine(Vector2.Zero, Player.Motion, Color.Color8(255, 255, 255, 255), 1, false);

		DrawCircle(Vector2.FromAngle(Player.Rotation) * Player.MaxSpeed, 5f, Color.Color8(0, 255, 0, 255), false, 1f, false);
	}
	
	public override void _Ready()
	{
		HealthLabel = GetNode<Label>("LabelHealthPoint");
		HealthLabel.Text = $"now HP = {HealthComponent.Health}" ;
	}

	public override void _Process(double delta)
	{
		Position = Player.Position;
		QueueRedraw();
	}
}
