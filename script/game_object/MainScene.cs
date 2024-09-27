using Godot;

public partial class MainScene : Node2D
{

    public override void _Input(InputEvent @event)
    {
        if (Input.IsActionJustPressed("ui_close")){
            GetTree().Quit();
        }
    }
}
