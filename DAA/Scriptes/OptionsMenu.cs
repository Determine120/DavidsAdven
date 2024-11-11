using Godot;
using System;

public partial class OptionsMenu : VBoxContainer
{
	void _on_back_to_main_menu_pressed()
	{
		Visible = false;
	}
	
	void _on_options_button_pressed()
	{
		Visible = true;
	}
}
