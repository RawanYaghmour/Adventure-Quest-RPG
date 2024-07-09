# :european_castle: Adventure Quest RPG :dragon:

Adventure Quest RPG is a console-based role-playing game where players embark on an adventure, fight monsters, discover new locations, and collect items to improve their abilities.

## Table of Contents

- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)
- [Game Flow](#game-flow)
- [XUnit Tests](#XUnit-Tests)

## Features :sun_with_face:	

- Explore different locations: Forest, Cave, and Tower.
- Fight various monsters, including ordinary monsters and boss monsters.
- Collect and use items to boost health, defense, and attack power.
- Level up and progress through the game.
- View inventory and manage collected items.

## Installation

1. Clone the repository:
    ```sh
    git@github.com:RawanYaghmour/Adventure-Quest-RPG.git
    ```

2. Navigate to the project directory:
    ```sh
    cd Adventure-Quest-RPG
    ```

3. Restore the dependencies and build the project:
    ```sh
    dotnet restore
    dotnet build
    ```

## Usage

1. Run the application:
    ```sh
    dotnet run
    ```

2. Follow the prompts in the console to navigate through the game.

## Game Flow

1. **Start the Game**: Enter your player name and begin your adventure.
2. **Main Menu**:
    - Press `1` to discover a new location.
    - Press `2` to show your current location.
    - Press `3` to attack a monster.
    - Press `4` to view the inventory.
    - Press `5` to end the game.
3. **Discover Locations**: Choose between Forest, Cave, and Tower.
4. **Fight Monsters**: Engage in battles with random monsters and level up.
5. **Collect Items**: Win items after battles and decide whether to use them immediately or add them to your inventory.
6. **End the Game**: Conclude your adventure when you reach level 5, run out of health, or choose to end the game from the menu.

## 🧪 XUnit Tests

### Attack Method Tests:

✅ Verify that the Attack method correctly reduces the health of the target (enemy) when the player attacks.

✅ Verify that the Attack method correctly reduces the health of the target (player) when the enemy attacks.

### Battle Outcome Tests:

✅ Assert that the winner's health is greater than zero after winning the battle.

### Location Tests:

✅ Verify that the chosen location is correctly set.

### Monster Encounter Tests:

✅ Verify that a boss monster can be encountered within 100 attempts.


## Enjoy Your Adventure Quest RPG!
Embark on epic battles and see if you can defeat the monsters in this thrilling console RPG game!
