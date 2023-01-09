using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManagerSys : MonoBehaviour
{
    public RandomSpawnSys running;
    public HealthUI hp;
    public static float Timer = 0f;
    public TextMeshProUGUI playtimer;
    public static int Difficulty = 30;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        int showtimer = (int)Timer;
        playtimer.SetText("Time: " + showtimer.ToString()+"s");

        if(HealthUI.hp == 0)
        {
            RandomSpawnSys.running -=1;
        }

        if(showtimer >= Difficulty)
        {
            EnemyCollisionSys.dropSpeed += 0.1f;
            ScrapCollisionSys.dropSpeed += 0.3f;
            CometCollisionSys.dropSpeed += 0.5f;
            ScoreUI.scr +=10;
            Difficulty += 30;
        }

        if(showtimer == 200)
        {
            RandomSpawnSys.spawnRate1=2;
            RandomSpawnSys.spawnRate2=5;
            RandomSpawnSys.spawnRate3=7;
            Difficulty += 30;
        }
        else if(showtimer == 400)
        {
            RandomSpawnSys.spawnRate1=1;
            RandomSpawnSys.spawnRate2=4;
            RandomSpawnSys.spawnRate3=6;
        }
        else if(showtimer == 600)
        {
            RandomSpawnSys.spawnRate1=1;
            RandomSpawnSys.spawnRate2=3;
            RandomSpawnSys.spawnRate3=5;
        }

        //EnemyCollisionSys.dropSpeed += 1.0f;

    }
}
