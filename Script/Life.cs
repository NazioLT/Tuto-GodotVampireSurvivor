using Godot;
using System;

public partial class Life : Node
{
    [Signal]
    public delegate void OnLifeChangedEventHandler(float newLife);

    [Export] private float _maxLife = 100f;

    private float _currentLife = 0;

    public float LifePercent => _currentLife / _maxLife;

    public void Damage(float amount)
    {
        ModifyLife(-amount);
    }

    public void Heal(float amount)
    {
        ModifyLife(amount);
    }

    private void ModifyLife(float amount)
    {
        _currentLife += amount;

        EmitSignal(SignalName.OnLifeChanged, _currentLife);
    }

    public override void _Ready()
    {
        _currentLife = _maxLife;
    }
}