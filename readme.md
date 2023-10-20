[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-24ddc0f5d75046c5622901739e7c5dd533143b0c8e959d652212380cedb1ea36.svg)](https://classroom.github.com/a/Xmv1pZ8x)
# README.md

**Cube Field V2**

| Name       | Divy Chandra |
| ---------- | ------------ |
| Student ID |      1005246 |

## Basic Game Description

Genre: **Casual** (Endless Runner like Temple Run/Subway Surf)
Main Objective: **Make it as far as possible by avoiding running into cubes, 3 lives**

SCREENSHOT_PLACEHOLDER

### Game Executable

#### System Requirements

- OS: **Windows 10**
- Processor: **Intel 20th Gen, @42.0 Ghz**
- Memory: **64 GB DDRX RAM**
- Graphics: **RTX 6090 DDRXI 16GB VRAM**
- Storage: **1TB NVMe SSD**

Provide a **link** to download your game executable

### How to Play

- Starting: Click "Start"
- Progression:
  - Movement: Move/Jump (A/D, Space) to avoid running into cubes
  - Shooting: shoot cubes to destroy them if you obtain the Laser powerup
  - Speed: Movement speed increases over time
  - Lives: Colliding with a cube will lose a life and grant temp invincibility for 5s to allow stabilisation
- Special: Collect powerups
  - Laser: destroy blocks by shooting (lasts 10s)
  - Phase Mode: pass through blocks (lasts 10s)
  - Spare Part: 1-Up (Extra Life, Max 5)
- Resolving:
  - Game ends when all lives are lost. The score is a function of distance travelled and difficulty level

### Gameplay Video

A ~60s recorded run of your game from start to finish (you may record from Unity editor, show your Game window clearly). You may provide a **working link, or a gif embedded directly here.**

## Features Implementation

Fill up the table below based on the **features** that you want us to grade you with. You may implement more features than what you can afford as your feature points, so you can select the features that we can grade. Feature prerequisite rule should apply.

You are free to transform the table below into short paragraphs if you'd like. The goal is to ensure that we **can find** and **confirm** each node implementation.

| Node ID (Dep) | Color                         | Short Description of Implementation                                                                                                           | Feature Point Cost | Marks to earn |
|---------------|-------------------------------|-----------------------------------------------------------------------------------------------------------------------------------------------|--------------------|---------------|
| 1  (-)        | $\textbf{Black}$              | Set up main cam at starting location of player                                                                                                | 0                  | 0             |
| 2  (-)        | $\textbf{Black}$              | 3 Different actions (move, jump, shoot)                                                                                                       | 0                  | 0             |
| 3  (-)        | $\textbf{Black}$              | Runnable EXE                                                                                                                                  | 0                  | 0             |
| 4  (-)        | $\textbf{Black}$              | README                                                                                                                                        | 0                  | 0             |
| 23 (-)        | $\text{White}$                | 2D Canvas UI, 2 Elements (Score, Pause, Reset)                                                                                                | 1                  | 3             |
| 34 (4)        | $\text{White}$                | Mnemonic var, fn, class naming                                                                                                                | 1                  | 3             |
| 35 (4)        | $\text{White}$                | Organised Assets into appropriate folders                                                                                                     | 1                  | 3             |
| 36 (4)        | $\text{White}$                | Git commits follow [conventions](https://www.conventionalcommits.org/en/v1.0.0/)                                                              | 1                  | 3             |
| 37 (4)        | $\text{White}$                | Follow C# [Naming Conventions](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/identifier-names#naming-conventions) | 1                  | 3             |
| 38 (3)        | $\text{White}$                | Score is a function of distance and difficulty                                                                                                | 1                  | 3             |
| 56 (3)        | $\color{orange}\text{Orange}$ | Audio Feedback (jump, shoot, collect powerup)                                                                                                 | 2                  | 10            |
| 71 (4)        | $\color{pink}\text{Pink}$     | Modular Design of 10+ Scripts (each script is self contained and does not interact directly with any other object's script)                   | 3                  | 15            |
| 73 (3)        | $\color{pink}\text{Pink}$     | Static classes are used for 1. Live state-keeping, 2. Proxying SOs for persistent states/configs 3. Centralising access to Events             | 3                  | 15            |
| 74 (3)        | $\color{pink}\text{Pink}$     | SO Event architecture (used for resets, pauses, player getting hit, player dying, ui controls)                                                | 3                  | 15            |
| 83 (3)        | $\color{purple}\text{Purple}$ | Difficulty (easy, medium, hard, changes the speed and acceleration of the game)                                                               | 4                  | 20            |
| 85 (4)        | $\color{purple}\text{Purple}$ | Object Pooling (cubes are pooled!)                                                                                                            | 4                  | 20            |

**Total Feature Points spent:** $\color{red}25$

$\color{red}1\color{white} * 6\ \ +\ \ \color{red}2\color{white} * \color{orange}1\color{white}\ \ +\ \ \color{red}3\color{white} * \color{pink}3\color{white}\ \ +\ \ \color{red}4\color{white} * \color{purple}2\color{white} = \color{red}25$

**Maximum Marks to earn:** $\color{lime}113$

$\color{lime}3\color{white} * 6\ \ +\ \ \color{lime}10\color{white} * \color{orange}1\color{white}\ \ +\ \ \color{lime}15\color{white} * \color{pink}3\color{white}\ \ +\ \ \color{lime}20\color{white} * \color{purple}2\color{white} = \color{lime}113$


### Feature Tree Visual Representation

Note: IDs 1, 2 and 23 are on their own and might be hard to see the highlight:

![tree-path](./50033-2023-tree.path.png)

### Feature Analysis

For **each** of your **orange**, **pink** and **purple** nodes, explain clearly your game design justification on how this feature upgrades the **overall quality** of the game. In short, you're providing a short **analysis**.

- If the feature stated that it has to support a core drive, explain which core drive.
- If the feature does not state anything concrete, it becomes an **open ended feature. Please** use proper terminologies whenever possible.
  - You can argue that this feature forms an **elegant rule**, or
  - It improves the UX of the game, or
  - **It improves code maintenance** overall
- Consult our lecture slides for inspiration and samples on how to concisely **analyse** a game.

| Node ID (Dep) | Color                         | Justification                                                                                                                                                                                                                                                                                                                                                                                                                                                                  | Category                    |
|---------------|-------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|-----------------------------|
| 56 (3)        | $\color{orange}\text{Orange}$ | Audio feedback is important for player immersion, game aesthetic and feel. It also informs the player that their actions are doing something in the game.                                                                                                                                                                                                                                                                                                                      | Player Feedback Enhancement |
| 71 (4)        | $\color{pink}\text{Pink}$     | Having a modular design for each script is important. It makes code a lot more readable, and follows the single responsibility principle.                                                                                                                                                                                                                                                                                                                                      | Code Quality                |
| 73 (3)        | $\color{pink}\text{Pink}$     | Static classes are used for<br/>1. Live state-keeping (temporary state)<br/>2. Proxying SOs for persistent states/configs. This is done for two reasons: a) Syntax, b) Centralising access to config/constant SOs so that they do not need to be passed to every script which needs them<br/>3. Centralising access to Events so that they do not need to be passed to every script which needs them.                                                                          | Code Quality                |
| 74 (3)        | $\color{pink}\text{Pink}$     | SO Event architecture is used to provide self sufficiency and modularity to every game object that needs to listen to events. This allows the object to not require referencing other game objects in the inspector and is even more important for objects that will be spawned with prefabs, pooled and re-used.                                                                                                                                                              | Code Quality                |
| 83 (3)        | $\color{purple}\text{Purple}$ | To make the game more accessible to players of all kinds of skill levels, different difficulty levels: **Easy**, **Medium**, and **Hard** are introduced, and they change the speed and acceleration of the game.<br/>A higher difficulty will naturally also give more score, more specifically, travelling the same distance in a higher difficulty level will grant 2x the score of the lower difficulty (each difficulty is meant to be about 2x as hard as the previous). | Gameplay                    |
| 85 (4)        | $\color{purple}\text{Purple}$ | Object pooling is important for performance reasons, since the game needs to spawn a lot of cubes on the fly. Performance is important for a game whose core mechanic is reflexes, as we do not want lag to be a factor for a player's death.                                                                                                                                                                                                                                  | Performance Optimisation    |

## Notes

```py
def cost_score(w, o, pi, pu):
    cost = w + 2*o + 3*pi + 4*pu
    score = 3*w + 10*o + 15*pi + 20*pu
    return cost, score

cost_score(6, 1, 3, 2)
```

## Asset Used & Credits

All assets used in the game are the ones available on the mid term website
