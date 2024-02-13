using Godot;
using System;

public partial class CharacterAnimator : Node
{
    [Export] private Sprite2D _characterSprite = null;
    [Export] private AnimatedSprite2D _animatedCharacterSprite = null;
    [Export] private AnimationPlayer _animationPlayer = null;
    [Export] private CharacterMotor _motor = null;

    public const string ENEMY_ANIM = "EnemyAnim";

    public override void _Ready()
    {
        base._Ready();

        if (_animationPlayer != null)
            _animationPlayer.CurrentAnimation = ENEMY_ANIM;
    }

    public override void _Process(double delta)
    {
        bool goLeft = _motor.LastDirection.X > 0;
        if (_characterSprite != null)
            _characterSprite.FlipH = goLeft;

        if (_animatedCharacterSprite != null)
            _animatedCharacterSprite.FlipH = goLeft;
    }
}
