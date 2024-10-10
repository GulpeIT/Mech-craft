using Godot;
using System;

public partial class Cursor : Node2D
{   

    private Sprite2D CURSOR_SPRITE;

    public override void _Ready()
    {
        base._Ready();
        
        Input.SetMouseMode(Input.MouseModeEnum.Hidden);
        CURSOR_SPRITE = GetNode<Sprite2D>("Sprite2D");

        CURSOR_SPRITE.Frame = 0;
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
            CURSOR_SPRITE.Position = Vector2.Down;
            CURSOR_SPRITE.Frame = 2;
        }
        else if (@event.IsActionReleased("ui_mouse_button_left_click"))
        {
            CURSOR_SPRITE.Position = Vector2.Zero;
            CURSOR_SPRITE.Frame = 1;
        }
    }
}
