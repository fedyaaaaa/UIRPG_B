Izmaiņas un Uzlabojumi: (angliski, jo tā vieglāk rakstīt)

Changes 
1. Enemy System Improvements
-Implemented random enemy spawning from a list of prefabs.
-Fixed an issue where enemies would infinitely clone upon death.
-Ensured enemies reset health upon spawning.
-Updated UI to correctly display enemy names and health after each respawn.
2. Player & Enemy Combat System
-Fixed damage application so player and enemy both attack correctly per round.
-Ensured the enemy name updates in the UI when a new one spawns.
-Added the possibility of toggling on and off the shield, 10% chance of it breaking 
4. Game Over System
-Created a GameOverManager to handle the end of the game when the player's health reaches 0.
-Displayed "Game Over" UI when the player dies.
-Prevented further attacks after the game ends.
OOP Principles 
-Encapsulation – Used private variables and public methods to manage health, attacks, and UI updates safely.
-Inheritance – The Enemy and Player classes inherit from a base Character class, allowing shared properties like health and attack logic.
-Polymorphism – Overridden methods such as GetHit() to allow enemies and the player to take damage differently.
-Abstraction – Game mechanics were split into modular scripts like GameManager and GameOverManager, making the codebase more manageable.
From the list of extra tasks that needed to be implemented i chose to add three different enemy types. 
1. Berserker (already was implemented during class - gets increasingly more aggressive upon each attack/does more dmg over time)
2. Assassin (Low health but high damage. Deals extra critical hits occasionally.)
3. Tank (High health but deals low damage. Has damage resistance, making it harder to kill.)
