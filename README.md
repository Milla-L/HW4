# HW4
## Devlog
The model-view-controller pattern is used in the player’s code to delegate events. 
My player code has three events called Jump, Die, and Score which are called by their variables. 
When the player jumps, the playerJump gets invoked and when the player collides with anything then either endGame or getPoint will be invoked depending on the object tag. 
The player is the control part of the pattern because it sets up the logic for the view parts to subscribe to. 
From there, the audio and UI both subscribe to the events. 
The UI and PipeManager are what create the aesthetics however only the UI is tied to the Player events. 
The PipeManager controls the pipes spawning and the score block spawning through the prefab system. 
The UI subscribes to the Score and Die events and updates the UI to respond to when the getPoint event is invoked as well as adds the points as needed. 
The Audio class is subscribed to all three events so that in the Audio game object, the Audio Sources can be connected to their respective audio clips. 
The singleton in this code is the player’s Locator class so that way there can only be one instance of a player and be referenced from all of the classes that subscribe to the player’s events. 

## Open-Source Assets
If you added any other assets, list them here!
- [Brackey's Platformer Bundle](https://brackeysgames.itch.io/brackeys-platformer-bundle) - sound effects
- [Industrial Pipe Platformer Tileset](https://wwolf-w.itch.io/industrial-pipe-platformer-tileset) - pipe sprites
- [Bird Sprites with Animations](https://carysaurus.itch.io/bird-sprites) - bird sprites