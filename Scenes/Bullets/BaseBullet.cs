using Godot;
using System;

public partial class BaseBullet : HitBox
{
    [Export] private VisibleOnScreenNotifier2D visibleOnScreenNotifier2D;

    private Vector2 direction = Vector2.Up;
    private float speed = 50.0f;

    public override void _Ready()
    {
        base._Ready();

        visibleOnScreenNotifier2D.ScreenExited += OnScreenExited;
    }

    public override void _Process(double delta)
    {
        base._Process(delta);
        Position += direction * speed * (float)delta;
    }

    protected override void OnAreaEntered(Area2D area)
    {
        base.OnAreaEntered(area);
        BlowUp();
    }

    public void Setup(Vector2 direction, float speed)
    {
        this.direction = direction.Normalized();
        this.speed = speed;
    }

    private void BlowUp()
    {
        SetProcess(false);
        QueueFree();
    }

    private void OnScreenExited()
    {
        QueueFree();
    }

}
