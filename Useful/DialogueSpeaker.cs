using Godot;
using System;

public partial class DialogueSpeaker : Resource
{
    [Export] public string Name { get; set; }
    [Export] public Sprite2D Portrait { get; set; }
}
