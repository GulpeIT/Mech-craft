using Godot;
using System;

public partial class Cursor : Node2D
{   

    private Sprite2D _CursorSprite;

    public override void _Ready()
    {
        base._Ready();
        
        Input.SetMouseMode(Input.MouseModeEnum.Hidden);
        _CursorSprite = GetNode<Sprite2D>("Sprite2D");

        _CursorSprite.Frame = 0;
    }

    public override void _Process(double delta)
    {
        base._Process(delta);
        Position = GetGlobalMousePosition();
    }

    public override void _Input(InputEvent @event)
    {
        base._Input(@event);
        if (@event.IsActionPressed("ui_mouse_button_left_click"))
        {
            _CursorSprite.Position = Vector2.Down;
        }
        else if (@event.IsActionReleased("ui_mouse_button_left_click"))
        {
            _CursorSprite.Position = Vector2.Zero;
        }
    }
}
