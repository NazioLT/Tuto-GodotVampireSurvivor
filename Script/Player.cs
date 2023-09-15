using Godot;
using System;

public partial class Player : Node2D
{
    [Export] private PlayerInput _input = null;
    [Export] private CharacterMotor _motor = null;

    public override void _Process(double delta)
    {
        _motor.MovementPerformed(_input.MovementInput);
    }
}
