using Godot;

public partial class Camera : Camera2D
{
	
	// Изменение позиции камеры по определённым точка на сцене
	[ExportCategory("Передвижение камеры по точкам")]
	[Export] 
	private Marker2D[] MARKERS  = new Marker2D[] {};
	[Export(PropertyHint.Range, "0, 999")]
	public int CURRENT_POSITION = 0;

	[Export]
	float MOVE_TIME = 0.75f;

	public override void _Ready()
	{
		MoveToPoint(2);
	}

	/// <summary>
	/// Method call to change camera position a new point
	/// </summary>
	/// <param name="newPoint">
	/// This is points in the array "MARKERS"
	/// </param>
	public void MoveToPoint(int newPoint)
	{
		if (newPoint > MARKERS.Length)
		{
			GD.PrintErr($"Camera: Method MoveToPoint get value outweigh marks length");
			return;
		}
		CURRENT_POSITION = newPoint;
		Tween tween = GetTree().CreateTween();
		tween.SetTrans(Tween.TransitionType.Cubic);
		tween.SetEase(Tween.EaseType.Out);
		tween.TweenProperty(GetNode("../Camera"), "position", MARKERS[CURRENT_POSITION].Position, MOVE_TIME);
	}
}
