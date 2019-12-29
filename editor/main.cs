//-----------------------------------------------------------------------------

// Package overrides to initialize the mod.
package Editor {
	function onStart()
	{
		Parent::onStart();
		echo("\n--------- Initializing MOD: Editor ---------");
		exec("./editor.cs");
		exec("./particleEditor.cs");
		exec("./GuiEditorGui.gui");
		exec("./ParticleEditor.gui");
	}

	function initClient()
	{
		Parent::initClient();
	}
}; // Editor package
activatePackage(Editor);


///COMPATIBILTY
///		editor.cs: //works, but pointless.
///		particleEditor.cs: //broken, but pointless
///		GuiEditorGui.gui: //broken, IMPORTANT TO FIX THIS
///		ParticleEditor.gui: //broken, but pointless