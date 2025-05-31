using Godot;
using System;

[GlobalClass]
public partial class DialogueSpeaker : Resource
{
    [Export] public string Name { get; set; }
    [Export] public Texture2D Portrait { get; set; }
    [Export] public Color Color { get; set; }
    [Export] public AudioStream Voice { get; set; }
}