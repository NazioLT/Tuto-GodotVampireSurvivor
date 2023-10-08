using Godot;
using System;

public partial class Player : Node2D
{
    [Export] private PlayerInput _input = null;
    [Export] private CharacterMotor _motor = null;
    [Export] private Life _life = null;

    public Vector2 BodyPosition => _motor.GlobalPosition;
    public Life Life => _life;

    public override void _Process(double delta)
    {
        _motor.MovementPerformed(_input.MovementInput);
    }
}
