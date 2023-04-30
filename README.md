# GAME351-Assignment-3
Program 3
School of Information, University of Arizona
Apr 30, 2023


Group Members: Teresa Tran, Hannah Klecan, Samantha Jackson, Ian Roach 


Character Key Mapping:


W: Move forward
S: Move backward
A: Turn left
D: Turn right
C: Crouch
F: Shoot 
Spacebar: Kick 


Primary Functionality:


For this American Wild West “A Palmful of Paper Money” action game, the team has implemented the following required features:


1.Cutscene Cameras:
        -Multiple Virtual Cameras: The cutscene features several virtual cameras, each set 
	   up to provide a unique perspective on the scene.

        -Dolly and Track Systems: These systems are used to move the cameras smoothly 
	  through the scene, creating a cinematic experience. 

        -Automatic Camera Transitions: The cameras are set up to automatically transition from 
	  one to the next, creating a seamless flow for the cutscene.

        -Player Interruption: The player can interrupt the cutscene at any time by pressing the 
	   'ESC' key.

        -Transition to Gameplay: After the cutscene ends or is interrupted, control is seamlessly 
	  passed to the player. The last virtual camera in the cutscene is a third-person camera 
	  centered on the player character, providing a smooth transition into gameplay.

        -Player Control: After the cutscene ends, the player can control their character using the 
	   W, A, S, D keys.


2.Player can Kick:
        -Kick Action: The player's character can perform a kick action by pressing the 
	   SPACEBAR key.

	  -Animation: The kick action triggers a kick animation on the character, controlled by an 
	  Animation Controller (AnimController) state machine.

	 -Random Kick Animations: Three different kick animations are available, and one is 
	chosen at random with equal probability each time the player initiates a kick.

	-Interaction with Dynamic Objects: The character can kick dynamic objects in the scene, 
	including Tumbleweeds, Baskets, Crates, and Barrels. This interaction is facilitated by 
	Unity's Physics system.

	-Kick Force: The force of the character's kick can be adjusted in the Inspector using a KickForce variable. 
	This variable affects the force applied to the objects the character kicks.


3.Shoot at Targets:
	-Shooting Action: The player's character can shoot by pressing the 'F' key.

	-Bullet Prefabs: Bullets are represented by prefabs which are spawned and propelled in the 
	direction of the player's line of sight when the shoot action is performed.

	-Collision Detection: The game detects collisions between bullets and other game objects.
	Collision detection is handled by Unity's physics system. When a bullet collides with another game object, 
	the OnCollisionEnter method is triggered. If the object hit is a bandit, a death animation is triggered on 
	the bandit's animation controller.

	-Target Response: When a bandit target is hit by a bullet, a death animation is triggered on the bandit's animation controller.

	-Fire Rate Limit: The player's rate of fire is limited to one shot per second to maintain game balance.


4.Dynamic Soundtrack
        
	  -The dynamic soundtrack is implemented using Unity's audio system. Audio Sources are 
	  attached to various game objects, and Audio Clips representing the different tracks and 
	  sound effects are played through these sources based on game events.

        -Each music track is attached to a separate Audio Source, and a script controls which 
	  track is playing based on the player's actions and location.

        -Foley effects are implemented by attaching Audio Sources to the relevant game objects 
	  and triggering the corresponding sound effect when the appropriate game event occurs.        

        -Character Taunts: Each bandit in the game directs unique taunts towards the player 
	  when nearby.

Choice Feature Implemented:

1. Monsoon Weather
	
	-Dark Clouds: Dark, stormy clouds are created using Unity's particle system with custom cloud textures/shading. 
	Dark clouds are added to the original sky to produce a stormy appearance. The sky dome color was also edited in 
	order to appear overcast as it would during a real summer monsoon. 

	-Rain: Rain is simulated using Unity's particle system. Each raindrop is a particle rendered with a custom raindrop texture. 
	The particles are spawned above the camera and fall under gravity, creating the illusion of rainfall. When the rain falls 
	it emits sub particles that appear as a ripple effect on the ground or surfaces.The emission rate of the particle system is 
	controlled by the RainController script with the "RainRate" variable, allowing for adjustable rainfall intensity.
	-Rain storm noises are added to the weather system as well as thunder. 

	-Lightning: Lightning strikes are created using Unity's VFX with custom lightning textures. The lightning VFX animation cycles 
    continuously throughout the gameplay. When the lightning strikes it produces sub particle sparks to enhance the effect.  


To install the project, follow these steps:


1) Create a blank "3D URP" project in Unity Hub.  
   Note: Your project MUST use the Universal
   Rendering Pipeline for textures and effects
   to render properly.
2) Allow the Unity editor to initialize the project.
3) Save your blank 3D URP project and exit Unity.
4) Navigate to project directory in file system.
5) Drop the "Assets" and "Project Settings" folders
   into this directory.
6) Open and reload the Unity project you created.
7) In the project navigator, go to the assets directory
   and find the "Scenes" folder.
8) Click on the "WesternTown" to load it.
7) Go to Unity->File->Build Settings and verify that
   the "WesternTown Scene" is in the "Scenes in Build"
   list.
8) If the scene is not in the build list, click
   "Add Open Scenes". The scene should appear checked.
9) The game template then should be ready for building
   and running.


Credits:
 
Sample code by Leonard D. Brown, University of Arizona.
This program was developed for educational purposes. Not
for redistribution.


Additional Assets used:
https://assetstore.unity.com/packages/audio/sound-fx/nature-sounds-pack-free-202076


Lightning vfx tutorial used:
https://www.youtube.com/watch?v=ewC_c6aHbf8


Media assets were used from the following sources:
(1) https://www.gog.com/en/game/outlaws_a_handful_of_missions
(2) https://assetstore.unity.com/
(3) https://www.gameartguppy.com/
(4) https://www.videvo.net/royalty-free-sound-effects/
(5) https://freesound.org/search/
(6) https://www.youtube.com/watch?v=JN8nj2-7G34
