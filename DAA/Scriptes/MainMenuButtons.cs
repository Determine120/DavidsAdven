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
		Visible = false;
	}
	
	void _on_quit_button_pressed()
	{
		GetTree().Quit();
	}
	
	void _on_back_to_main_menu_pressed()
	{
		Visible = true;
	}
}
