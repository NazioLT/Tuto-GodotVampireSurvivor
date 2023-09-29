using Godot;
using System;

public partial class CharacterAnimator : AnimationPlayer
{
    [Export] private Node2D _characterSprite = null;
    [Export] private CharacterMotor _motor = null;

    public const string ENEMY_ANIM = "EnemyAnim";
    
    public override void _Ready()
    {
        base._Ready();
        
        CurrentAnimation = ENEMY_ANIM;
    }

    public override void _Process(double delta)
    {
        bool goLeft = _motor.Velocity.X > 0;
        _characterSprite.RotationDegrees = 0;
    }
}
