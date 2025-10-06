using Godot;
using System;

public partial class Main : Control
{
    [Export] private UiButton StartButton { get; set; }
    [Export] private UiButton QuitButton { get; set; }

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        GetTree().Paused = false;
        QuitButton.Pressed += () => { GetTree().Quit(); };
        StartButton.Pressed += () => { GameManager.LoadGameScene(); };
    }
}
