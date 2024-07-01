# 🏰 Adventure-Quest-RPG 🐉

## 🎯 Purpose of the Program
The Adventure Quest RPG is a console application where players embark on epic journeys, battle monsters, and explore dungeons.




## 🚀How to run the program
1. **Clone the repository:**
2. **Navigate to the project directory:**
3. **Compile and run the program:**
4. **Follow the on-screen instructions:**
-Choose an option from the menu to perform an action (e.g., read, add, delete, count, or search entries).
-Follow the prompts to provide necessary inputs (e.g., date, content, keywords).

## ✨Features

# Player and Monster Classes:

The Player and Monster are subclasses of the abstract Character class.
Player: Represents the player-controlled character with properties like Name, Health, AttackPower, and Defense.
Monster: Represents the monster characters in the game, inheriting properties from the Character class.

# Battle System:

⚔️ Attack Method: Simulates an attack between two characters, calculating and applying damage based on their attributes.
🛡️ StartBattle Method: Initiates and manages the battle between the player and a monster, alternating turns until one is defeated.

## Additional information or notes
Error Handling: The application includes basic error handling to manage unexpected inputs and scenarios.
Data Initialization: Default values for player and monster attributes are set in their respective constructors.

## Enjoy Your Adventure Quest RPG!
Embark on epic battles and see if you can defeat the monsters in this thrilling console RPG game!

## 🧪 XUnit Tests
# Attack Method Tests:

✅ Verify that the Attack method correctly reduces the health of the target (enemy) when the player attacks.
✅ Verify that the Attack method correctly reduces the health of the target (player) when the enemy attacks.

# Battle Outcome Tests:

✅ Assert that the winner's health is greater than zero after winning the battle.

