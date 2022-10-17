# Project Edge Shooters

[Markdown Cheatsheet](https://github.com/adam-p/markdown-here/wiki/Markdown-Here-Cheatsheet)

### Student Info

-   Name: Jordan Mazza
-   Section: 202

## Game Design

-   Camera Orientation: The art assests are viewed from the topside.
-   Camera Movement: The camera is a fixed position on the screen of the game.
-   Player Health: The player has a healthbar. They can take 5 total hits.
-   End Condition: Once all enemies are defeated the wave ends. After 3 waves the game is complete.
-   Scoring: Killing the enemies, surviving each wave.

### Game Description

The objective of the game is for the player to surviv e3 waves of enemies. Each wave is random amound of enemies from a range of numbers. And there are 3 enemy types. Each type of enemy moves at a different speed.

### Controls

-   Movement
    -   Up: W Key
    -   Down: S Key
    -   Left: D Key
    -   Right: A Key
-   Fire: Left Mouse Button

## You Additions

The way I will make my game unique is to have the enemies come from all sides of the screen. All 4 sides of the screen will have enemies attack, but the way to make
it not TOO diffiuclt is that the side with the enemies attacking, there will be a red flashing line on that edge of the screen. Which then enemies will attack from
there. Another thing I want to try is to make it so the player can only move left and right and once they hit the side of the screen, they will rotate to the side
so that the ship moves around the inner perimeter of the screen.

## Sources

-   Game Asset Sprites from: redfoc.com
-   _If an asset is from the Unity store, include a link to the page and the author’s name_

## Known Issues

The collision does not work properly. The player and enemies are highlited red and when they disappear an error occurs. Tried to make a timer for bullet firing, but could not figure it out. The score is not added when an enemy gets destroyed, and the health bar does not decrease when the player takes damage. The border for the player movement is only the bottom right diagonal of the game screen.

### Requirements not completed

-Delay between player fired bullets (timer setup I had did not work).
-Scoring system does not work.
-Health bar does not properly work.
-Enemies collide with other enemies.
-My own twist was to have the player stick to the edge of the screen, which was only half way done.

