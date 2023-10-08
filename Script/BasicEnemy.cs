using Godot;

public partial class BasicEnemy : Node
{
	[Export] private CharacterMotor _motor = null;
	[Export] private Player _player = null;

	[Export] private float _attackDistance = 1f;
	[Export] private float _attackDamagePerSecond = 10f;

	public override void _Process(double delta)
	{
		Vector2 deltaPlayerPosition = _player.BodyPosition - _motor.GlobalPosition;
		float distanceToPlayer = deltaPlayerPosition.Length();

        if (distanceToPlayer < _attackDistance)
		{
			Attack(delta);
			return;
        }

		GoToPlayer(deltaPlayerPosition);
	}

	private void Attack(double delta)
	{
		_motor.Stop();

		_player.Life.Damage(_attackDamagePerSecond * (float)delta);
    }

    private void GoToPlayer(Vector2 deltaPlayerPosition)
    {
		_motor.MovementPerformed(deltaPlayerPosition.Normalized());
    }
}
