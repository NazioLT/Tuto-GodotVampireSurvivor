using Godot;
using System;

public partial class CharacterAnimator : AnimationPlayer
{
    public override void _Ready()
    {
        base._Ready();
        
        CurrentAnimation = "EnemyAnim";
    }
}
