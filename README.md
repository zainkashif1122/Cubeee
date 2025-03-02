# Cubeee

Cubeee is a menu-based 3D game built in Unity using C#, featuring two action-packed levels with unique mechanics. Players must strategically collect pickups, avoid obstacles, and use shooting mechanics to progress.

## Table of Contents
1. [Introduction](#introduction)
2. [Project Overview](#project-overview)
3. [Live Preview](#live-preview)
4. [Features](#features)
5. [Installation](#installation)
6. [Game Instructions](#game-instructions)
7. [File Structure](#file-structure)
8. [Technologies Used](#technologies-used)
9. [Code Explanation](#code-explanation)
10. [Future Improvements](#future-improvements)
11. [Conclusion](#conclusion)

## Introduction
Cubeee is a menu-based game built in Unity using C#, featuring two levels with interactive gameplay. Players navigate through challenges with a pickups collecting system, shooting mechanics, health system, and a timer that adds intensity to the experience. The game combines action and strategy, pushing players to complete levels before time runs out.

## Project Overview
The game consists of two levels:
- **Level 1:** The player moves by sliding and collects pickups by colliding with them.
- **Level 2:** Players must collect all pickups within 30 seconds. If time runs out before collecting all pickups, the game is lost. A twist in this level is that players lose immediately if they collide with a pickup. Instead, they must shoot bullets to collect pickups.

## Live Preview
To help visualize the game in action, we have provided a screen recording:

- [`GamePlayVideo`](GamePlayVideo.mp4)
  Demonstrates the menu, gameplay mechanics, and level challenges.

Feel free to check out the video to get a better understanding of the game's functionality and user experience.
> **Note:** The quality of this screen recording has been reduced to comply with GitHub's 25MB file size limit.

## Features
- **Menu System:** Includes buttons for Level 1, Level 2, and Quit.
- **Two Unique Levels:** Different mechanics and challenges.
- **Pickups Collecting System:** Players interact with objects to progress.
- **Shooting Mechanic:** Players shoot bullets to collect pickups in Level 2.
- **Health System:** Players lose if they collide with pickups in Level 2.
- **Timer System:** Adds a time-based challenge in Level 2.
- **Particle Effects:** Visual effects for bullet and pickup collisions.

## Installation
To play **Cubeee**, follow these steps:
1. **Download the game files** from the repository.
2. **Run the executable** provided in the game folder.
3. **Start playing!**

## Game Instructions
- **Movement:** Use `Arrow Keys` or `WASD` to move the player.
- **Shooting:** Use `Left Mouse Click` to shoot bullets.
- **Level 1:** Slide and collide with pickups to collect them.
- **Level 2:** Shoot bullets to collect pickups while avoiding direct collisions.

## File Structure
- [`CubeeeGame.exe`](CubeeeGame.exe) - Game executable.
- [`Assets/`](Assets/) - Game assets and resources.
- [`Scripts/`](Scripts/) - C# scripts for game mechanics.

## Technologies Used
- **Game Engine:** Unity
- **Programming Language:** C#

## Code Explanation
- **Player Movement:** Controls movement using arrow keys or `WASD`.
- **Shooting Mechanic:** Detects bullet collisions with pickups.
- **Timer System:** Limits time to complete Level 2.
- **Health System:** Ends the game if the player collides with pickups in Level 2.
- **Menu System:** Allows navigation between levels.

## Future Improvements
- **Enhanced UI:** Improve visuals and animations.
- **More Levels:** Introduce new challenges.
- **Multiplayer Mode:** Allow competitive gameplay.

## Conclusion
Cubeee is a fast-paced, interactive game that challenges players with different mechanics in each level. The combination of movement, shooting, and time-based objectives makes it an engaging experience. Enjoy the game and test your skills!
