# Vuforia-AR-tests

## This repository should serve as a compilation of tests done with Vuforia SDK and Unity3D for Augmented Reality.

**To get this working into your machine, you should have Unity installed, with Vuforia module.
In order to help you:**

1. Install Unity hub;
2. Install version 2018.4.12f1 with Vuforia module;
3. Create your account at [Vuforia](https://developer.vuforia.com/);
4. Log in and create a new license key;
5. Open the folder VuforiaTest in Unity project and check if Vuforia augmented reality in PC XR Options (just for tests with a webcam) and Android/Ios XR Options in Edit > Project Settings > Player are selected;
6. Create a new object "Ar Camera" and import Vuforia into your project;
7. Click in the button in your AR Camera component "Open Vuforia Engine Configuration" and paste your license;
8. Get back in Vuforia website and create a new image database and download it (if you choose device option, which I recomend for begginers);
9. Import your image database into Unity;
10. Create a new Vuforia Image, set your image in the component with your database and your image;
11. Create a new model child of the image and then run.

_Each scene has its own folder with everything needed to setup the scene._
_The main reason of this repository is to show what you can do with Augmented Reality_

**A basic explanation of what is going on each scene:**

1. [ ] InteractionScene

###### In this scene the two objects should interact with each other. The first one named player should recognize the second one named enemy (just to refer something like an action game) and the on player and enemy active, and the enemy in the search range of the player should go closer to the enemy, and in attack range, the player should hit him. After that, on disabling the enemy and enabling it again, it should 'reset' the action and the player should attack him again.

2. [x] JoystickScene

###### In this scene using a free [joystick pack](https://assetstore.unity.com/packages/tools/input-management/joystick-pack-107631) found in the asset store you should be able to move around the model named as player.

3. [x] PianoForPcScene

###### In this scene you should use your mouse to click the models in the scene (they're representing the piano tiles) and the 'response' should be some audio.

4. [x] PianoScene

###### In this scene you should have the same result of the PianoForPcScene, the difference is that in this scene you use touch for phone.

5. [x] ReadingEnableTargetScene

###### In this scene you just identify if a target is enable or not. If enable, just rotate it. The big deal for this scene, is that every frame in Unity is counted, meaning if you rotate an object it'll rotate even if the target has not been read. Basically, you are controlling the target "when to do something" or "do something by activating".

6. [x] VirtualButtonScene

###### In this scene you should do a virtual button get active when your hand or something goes over. The activation is right when the cube rotates.

7. [x] ChangingTargetScene

###### In this scene you should change the target of a model to another target.

8. [x] AugmentedWindow

###### In this scene you should see a model through a 'window' like you would normally see through a portal or something like that. This could be used as you can imagine, a new world beyond the portal, like World of Warcraft, or something more real like Louvre Museum. Just remember that you are limited to the image target. To get this effect you could use your own shader or use the Vuforia prefab on Vuforia>Materials>DepthMask and apply into some planes to work as 'barriers'.


## Each other scene in this project is just for any tests.