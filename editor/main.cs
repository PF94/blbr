//-----------------------------------------------------------------------------

// Package overrides to initialize the mod.
package Editor {
	function onStart()
	{
		Parent::onStart();
		echo("\n--------- Initializing MOD: Editor ---------");
		exec("./editor.cs"); //works, but pointless.
		exec("./particleEditor.cs"); //broken, but pointless
		exec("./GuiEditorGui.gui"); //broken, IMPORTANT TO FIX THIS
		exec("./ParticleEditor.gui"); //broken, but pointless
	}

	function initClient()
	{
		Parent::initClient();
	}
}; // Editor package
activatePackage(Editor);