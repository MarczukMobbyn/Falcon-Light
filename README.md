# Falcon Light

A physics-based 3D arcade game developed in Unity where the player controls a rocket navigating through challenging levels filled with obstacles. The project focuses on fine-tuned physics movement.

## Gameplay Preview
![Rocket Boost Preview](Media/gameplay1.gif)
![Rocket Boost Preview](Media/gameplay2.gif)

## Key Technical Features

* **Physics-Based Movement:** Custom rocket controller using Unity's `Rigidbody` component. Movement is handled via `AddRelativeForce` for thrust.
* **Collision System & Level Logic:** Implementation of a tag-based collision system to distinguish between safe landing zones, obstacles, and fuel pickups.
* **Game State Management:** Centralized logic for handling player deaths, level transitions, and "Success" states with synchronized audio and visual effects (Particle Systems).
* **Level Design:** Multiple stages with increasing difficulty, utilizing Unity's Scene Management for transitions.
* **Audio & FX Integration:** Dynamic sound effects for rocket thrust and collisions, paired with particle systems for engine exhaust and explosions.

## Built With

* **Unity Engine:** Core game loop and physics simulation.
* **C#:** Scripting for rocket mechanics and level flow.
* **Unity Particle System:** Visual feedback for propulsion and destruction.

## How to Play

1.  **Space:** Activate main thrusters to fly upwards.
2.  **A / D (or Left/Right Arrows):** Rotate the rocket to navigate.
3.  **Goal:** Reach the green landing pad without hitting any obstacles.

## How to Run

1. Clone this repository.
2. Open the project in Unity (Version 6000.0.28f1).
3. Open `Assets/Scenes/Over.unity`.
4. Press Play.

## Author
* **Szymon Marczuk** - [GitHub Profile](https://github.com/MarczukMobbyn)
