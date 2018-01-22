# FogOfWar
Fog of War in Unity
	Fog of war is the uncertainty in military operations. In game, this concept is used to hide the identity of game unit. In game like Yu-Gi-Oh!, players could place card face down to prevent player from noticing the ability of the card. This is one kind of “Fog of War” in game. In game like Blizzard’s Warcraft, game unit have their own field of view.  Player could see friend unites’ view, in contrast, other area would be hidden. 
	The Fog of War I want to research is the later one. There are different ways to archive the Fog of War effect in unity. I used three methods in this time’s research.
1.	Fog of War GameObject
Generally, this method is setting series of gameobject, fog of war, between game camera and player gameobject. Thus, camera’s view will be blocked by these “fog”. To make the “player” visible, the way I do, is to set the “Mesh Render” of the “fog” as disable. 
Before writing the script, create a “plane” gameobject and reset value. Name it “ground” and set the “scale.x” and (scale.z) value to 10. A large value will case performance issue if the following steps do exactly what I have done in this round of experiment. 
Then set a cube and palce it on the ground. Rename it as “Player”. Drag and drop “MainCamera” to make it a child of player. This could make a simple camera follow. Place some other cube around player and name them enemy. Add a new tag and give it a name “Enemy”. Change all the enemy cube to “Enemy” tag. This tag will be used in trigger check. Add a new cube as Fog, add and change fog’s tag as “Fog”. Put this “Fog” at a higher position(increase the transform.y value). Set “Fog” as prefab.
Add new box collider to player. Other types of collider work, too. Check the “isTrigger” to set the newly created collider as a trigger. Resize the collider and make sure the collider could collision with “Fog” Created a new C# script name it “FoWTrigger” and attach to player. This script will have two functions. On is “OnTriggerEnter” and another is “OnTriggerExit”. Both are Unity functions and execute when collider enter and exit trigger. In the “OnTriggerEnter” function, check the collider’s tag, if that tag is “Fog”, then disable the render of the “Enemy”. Reverse the process in “OnTriggerExit” function. Add a new script called “Movement” and add simple “move” function to player.
Run, the game, the “Fog” could be triggered by the “Fog” render or un-render “Fog”. Then add new script to “Ground”. Create a reference of “Fog” prefab instantiate “Fog” over the entire “Ground”. If the “Ground” is oversized, Unity will spend too much time instantiate the “Fog”, even errors. 
So far, this simple Fog of War test should work. 
2.	Render and un-render
This method is fully workable with the previous scene but “Fog”. “Ground” do no long need the script to instantiate “Fog”. 
Next step is changing the script of trigger. However, if the “FoWTrigger” script is changed, the first will not work properly. Thus a new script is required. This script is typically the same as “FoWTriger”. Instead of disable the render when enter trigger, render should be enable when entered and disable when exit. The collider tag should be “Enemy”. That is why I change the tag but do not use it in the first.
Now, this “fog” is working. But, to make it more fog-like, the light should be changed. Remove the direct-light. Add a spot light to player and change the propriety.
Last step is make all “Enemy” invisible when game start. Selecting all “Enemy” and uncheck “Mesh Render”.
All set now.  
3.	Shade 
Shader would the best way to do Fog of War in my opinion. However, it is more complicated. Customized shader is fully capable of this job but I do not figure out how to make it work properly. 
What I have done is adding a filter to the camera and the result is reduced filed of view. It consumes little performance, but only work for fixed camera. Furthermore, resolution could also change to result. 

