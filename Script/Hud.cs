using Godot;
using System;

public partial class Hud : Control
{
	[Export] private ProgressBar _bar = null;

	private Life _life = null;

	public override void _Ready()
	{
		_life = Player.Instance.Life;

        _life.OnLifeChanged += OnLifeChanged;
    }

	private void OnLifeChanged(float newLife)
	{
		_bar.Value = _life.LifePercent;
	}
}
