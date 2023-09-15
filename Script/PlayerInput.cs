using Godot;
using System;

public partial class PlayerInput : Node
{
	private Vector2 _movementInput = Vector2.Zero;

	public Vector2 MovementInput => _movementInput;

	public override void _Process(double delta)
	{
		_movementInput = new Vector2(
			Input.GetAxis("Left", "Right"),
			Input.GetAxis("Up", "Down")
		);
	}
}
