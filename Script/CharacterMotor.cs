using Godot;
using System;

public partial class CharacterMotor : CharacterBody2D
{
	[Export] private float _speed = 6f;
	
	private Vector2 _movementInput = Vector2.Zero;
	
	public void MovementPerformed(Vector2 input)
	{
		_movementInput = input.Normalized();
	}
	
	public override void _PhysicsProcess(double delta)
	{
		Velocity = _movementInput * _speed;
		MoveAndSlide();
	}
}
