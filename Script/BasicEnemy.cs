using Godot;

public partial class BasicEnemy : Node
{
	[Export] private CharacterMotor _motor = null;
	[Export] private Player _player = null;

	[Export] private float _attackDistance = 1f;

	public override void _Process(double delta)
	{
		Vector2 deltaPlayerPosition = _player.BodyPosition - _motor.GlobalPosition;
		float distanceToPlayer = deltaPlayerPosition.Length();

        GD.Print(distanceToPlayer);

        if (distanceToPlayer < _attackDistance)
		{
			Attack();
			return;
        }

		GoToPlayer(deltaPlayerPosition);
	}

	private void Attack()
	{
		_motor.Stop();
	}

    private void GoToPlayer(Vector2 deltaPlayerPosition)
    {
		_motor.MovementPerformed(deltaPlayerPosition.Normalized());
    }
}
