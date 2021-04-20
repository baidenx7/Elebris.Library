Using IActionBulder:
	Create a new CharacterAction, populate it with stats and calculations from the iActionBuilder
	
Using CharacterAction:
Pass to the player as a stored Action,
Retreive either from a stored keybind reference or put it directly into a slot that know what keybinds to look for.

Using StoredAction:
	Grab a copy, store in CurrentAction (Unity) and then modify CurrentAction with any info the player wants to pass in (passives)
	After Execution, All info is sent with the Gameobject(Unity)

	GameObject:


Upon contact: 
	The target gets a chance to populate their own mods and calculations, then there is an intermediate step where the action itself
	grabs any stats that aren't already populated to complete it's calculations, as well as remove any stats it wants to ignore such as defense).



Execute():
	Perform calculations on any/every stat, and create ActionResult objects which are then carried out on the relevant targets.




	Different types of actions encompass different general behaviours intended by an action.