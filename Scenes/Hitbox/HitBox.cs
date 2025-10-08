using Godot;
using System;

[GlobalClass]
public partial class HitBox : Area2D
{
    [Export] protected int Damage { get; set; } = 10;
    [Export] public CollisionShape2D CollisionShape2D { get; set; }

    public override void _Ready()
    {
        base._Ready();

        AreaEntered += OnAreaEntered;
    }

    public override void _ExitTree()
    {
        base._ExitTree();
        AreaEntered -= OnAreaEntered;
    }

    public void Deactivate()
    {
        CollisionShape2D.SetDeferred(CollisionShape2D.PropertyName.Disabled, true);
    }

    protected virtual void OnAreaEntered(Area2D area)
    {
    }
}
