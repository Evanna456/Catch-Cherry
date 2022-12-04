using Godot;
using System;

public class Level0 : Node2D
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		var Evanna = GD.Load<PackedScene>("res://characters/player/evanna/Evanna.tscn");
		var evanna_instance = (Node2D)Evanna.Instance();
		AddChild(evanna_instance);
		evanna_instance.Position = new Vector2(640,640);
		
	}
	


//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
