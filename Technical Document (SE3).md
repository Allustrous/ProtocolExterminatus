# ProtocolExterminatus
School project
Technical Document (SE3)

BackgroundAnimation.cs: Was used to test animations during development, went unused in the end as whole team was new to animating in unity and we figured out how to do without.

BulletCollisionSys.cs: Controls the physics and collision of the Projectile prefab.
  bulletVelocity: the base value of the bullet's speed
  fruit: the codename for the Comet prefab, called to be used for testing during development
  bullet: the codename for the Projectile prefab, called to be used for testing during development
  Start():  on start, the bulletVelocity is reset, to allow the game to be replayable.
  OnBecameInvisible(): on the object exiting the screen limits, it is destroyed.
  Update(): the code used to control the bullet's movement
  
CharacterMovement.cs: The controls for player movement, player collision and event system interacting with the upgrade system.
  shipSpeed: the base value of the ship's movement speed
  PlayerShip: calling the Player ship asset to be used.
  fruit: calling the Comet asset to be used.
  Scrap: calling the Scrap asset to be used.
  Enemy: calling the Enemy asset to be used.
  FireRateMeter: the variable used to control the fire rate of the player's weapon.
  BulletVelMeter: the variable used to control the bullet velocity of the player's weapon.
  hitDetection: variable used for hit detection and sound effect system.
  xMin, xMax: variables used for limiting player movement.
  yMin, yMax: variables used for limiting player movement.
  Start(): sets the size limit for the player character clamping system
  spriteSize: calling for the size of a sprite.
  cam: calling for the camera as a variable.
  camHeight: calling for the camera height as a variable.
  camHeight: calling for the camera width as a variable.
  Update(): contains the player movement and input system, and the clamping system.
  hor: a variable to contain the horizontal input axis.
  direction: a variable to contain vector 2 horizontal.
  xValidPosition: a variable to clamp the y axis position.
  yValidPosition: a variable to clamp the x axis position.
  OnTriggerEnter2D: on trigger of an entity entering the 2D collider of the object, the upgrade system and health system is affected depending on the tag of the entering object.
  
CharacterWeaponSys.cs: the controls and source variables of the player ship's weapon.
  playerShip: calling the Player ship asset to be used.
  projectile: calling the projectile asset to be used.
  fireRate: the base fire rate of the weapon.
  lastShot: the variable used to distinguish cooldown of the weapon.
  timeStamp: a testing variable used for a different, faulty, cooldown system.
  source: the asset containing the audio source.
  weaponFire: the weapon fire sound effect.
  Start(): resets variables on scene start to make game replayable.
  Update(): contains the weapon firing and projectile spawning system.
  
CometCollisionSys.cs: the physics and collision events of the Comet(fruit) asset.
  dropSpeed: the base speed of the comet.
  fruit: calling the comet asset to be used.
  RateKit: calling the fire rate kit asset to be used.
  CometPos: a vector 3 variable of the comet's position.
  deathDetection: for use with the audio sound effect play system.
  Start (): resets speed on scene open to make game replayable.
  OnBecameInvisible(): destroys game object on exiting camera screen limits.
  OnTriggerEnter2D (): the collision system that destroys the asset, projectile, spawns the upgrade and plays the audio through the audio manager.
  Update (): controls the asset movement.
  
EnemyCollisionSys.cs: the physics and collision events of the Enemy asset.
  dropSpeed: the base speed of the enemy.
  Enemy: calling the enemy asset to be used.
  MedKit: calling the med kit asset to be used.
  EnemyPos: a vector 3 variable of the enemy's position.
  enemyDur: a variable used to keep track of the asset's health.
  hitDetection: for use with the audio sound effect play system.
  deathDetection: for use with the audio sound effect play system.
  void Start (): resets speed and asset health on scene open to make game replayable.
  OnBecameInvisible(): destroys game object on exiting camera screen limits.
  OnTriggerEnter2D (): the collision system that destroys the asset and projectile, controls durability, spawns the upgrade, and plays the audio through the audio manager.
  Update (): controls the asset movement.
 
GameManagerSys.cs: manages majority of the game systems that need to interact with other systems.
  running: calling the running variable from RandomSpawnSys.cs.
  hp: calling the hp variable from HealthUI.cs.
  Timer: a variable used for the timer.
  playtimer: textmesh to view timer.
  Difficulty: difficulty counter.
  SpawnScrap: variable for use to start spawn scrap.
  SpawnEnemy: variable for use to start spawn enemy.
  Comet: calling an asset to be used.
  Scrap: calling an asset to be used.
  Enemy: calling an asset to be used.
  source: the asset containing the audio source.
  enemyHit: enemyHit sound effect
  enemyDead: enemyDead sound effect
  upgraded: upgraded sound effect
  hitDetection: detects a hit to play hit sound.
  deathDetection: detects a death to play death sound.
  upgradeDetection: detects an upgrade to play upgrade sound.
  Update(): Contains the sound effect event system.
  Start(): resets the game on scene open to base values and starts the game timer.
  GameTimer(): runs the timer, previews timer,  detects game over event, ends game to game over screen, controls difficulty, 
  
GameOverUI.cs: Controls the Over scene as the game over screen.
  highScr: variable to contain the high score.
  highScore: text mesh to view highscore.
  newScore: text mesh to view new score.
  Start(): controls the high score and new score text mesh previews.
  Update(): controls scene change to menu.
  
GameStartUI.cs: the main menu of the game.
  Update(): controls scene change to game.

HealthUI.cs: contains the health value and previews it in textmesh format.
  hp: base health value.
  health: text mesh of health.
  Start(): resets health for replayability.
  Update(): previews health in text mesh format.

MedCollisionSys.cs: controls the movement and management of upgrade assets on screen.
  dropSpeed: base movement speed of upgrades.
  MedKit: testing variable no longer in use.
  hpUI: testing variable no longer in use.
  OnBecameInvisible(): destroys game object on exiting camera screen limits.
  Update (): controls movement of the asset.
  
RandomSpawnSys.cs: controls the spawning system of the game's comet, scrap and enemy assets.
  fruit: calling the comet asset to be used.
  Scrap: calling the Scrap asset to be used.
  Enemy: calling the Enemy asset to be used.
  x: a variable used to contain position.
  running: a variable used to control game activity state.
  spawnOne: a variable used to contain a randomizer.
  spawnTwo: a variable used to contain a randomizer.
  spawnThree: a variable used to contain a randomizer.
  spawnRate1: a variable used to control spawnrate of spawner 1.
  spawnRate2: a variable used to control spawnrate of spawner 2.
  spawnRate3: a variable used to control spawnrate of spawner 3.
  Start(): starts the spawner 1 coroutine.
  SpawnScrap(): starts the spawner 2 coroutine.
  SpawnEnemies(): starts the spawner 3 coroutine.
  SpawnRoutine1(): a randomized spawner.
  SpawnRoutine2(): a randomized spawner.
  SpawnRoutine3(): a randomized spawner.
  
ScoreUI.cs: contains and controls the current score.
  scr: the current score.
  score: text mesh for the current score.
  Start(): reset score for replayability.
  Update(): updates the score text mesh.
  
ScrapCollisionSys.cs: controls the physics and collision of the scrap asset.
  dropSpeed: the base speed of the scrap.
  Scrap: calling the scrap asset to be used.
  scrapDur: health of the scrap asset.
  SpeedKit: calling for the speed kit asset to be used.
  ScrapPos: vector 3 variable of the scrap's position.
  Start (): resets variables for replayability.
  OnBecameInvisible(): destroys game object on exiting camera screen limits.
  OnTriggerEnter2D (): the collision system that destroys the asset and projectile, controls durability, spawns the upgrade, and plays the audio through the audio manager.
  Update (): controls the asset movement.
  
