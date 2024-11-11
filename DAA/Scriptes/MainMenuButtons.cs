using Godot;
using System;

public partial class MainMenuButtons : VBoxContainer
{
	void _on_play_button_pressed()
	{
		GD.Print("Game Started");
	}
	
	void _on_options_button_pressed()
	{
		GD.Print("Options open");
	}
	
	void _on_quit_button_pressed()
	{
		GetTree().Quit();
	}
}
