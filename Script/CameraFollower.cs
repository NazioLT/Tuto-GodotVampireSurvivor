using Godot;
using System;

public partial class CameraFollower : Node2D
{
    [Export] private Node2D _objectToFollow = null;
    [Export] private float _maxSpeed = 6f;
    [Export] private float _maxSpeedDistance = 50f;

    public override void _Process(double delta)
    {
        Vector2 deltaPos = _objectToFollow.Position - Position;

        if (deltaPos.Length() < 1f)
            return;

        Vector2 clampedDelta = deltaPos.LimitLength(_maxSpeedDistance) / _maxSpeedDistance;

        Position += _maxSpeed * (float)delta * clampedDelta;
    }
}
