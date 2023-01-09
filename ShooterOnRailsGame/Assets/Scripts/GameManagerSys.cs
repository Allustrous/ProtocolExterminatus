using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerSys : MonoBehaviour
{
    public BulletCollisionSys bulletVelocity;
    public EnemyCollisionSys dropSpeed;
    public RandomSpawnSys running;
    public HealthUI hp;
    public CharacterMovement shipSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            if(HealthUI.hp == 0)
            {
                RandomSpawnSys.running -=1;
            }
            //EnemyCollisionSys.dropSpeed += 1.0f;
    }
}
