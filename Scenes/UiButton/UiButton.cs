using Godot;
using System;

public partial class UiButton : TextureButton
{
    [Export] private string LabelText { get; set; }
    [Export] private Label Label { get; set; }

    public override void _Ready()
    {
        Label.Text = LabelText;
    }
}
