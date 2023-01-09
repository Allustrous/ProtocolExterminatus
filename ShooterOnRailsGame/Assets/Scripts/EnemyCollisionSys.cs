using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollisionSys : MonoBehaviour
{
    public static float dropSpeed = 0.5f;
    public GameObject Enemy;
    public GameObject Drop;
    public Vector3 EnemyPos;
    public static int enemyDur = 3;


    void OnBecameInvisible() 
    {
        Destroy(gameObject);
        Debug.Log("Destroyed");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        enemyDur -=1;

        if(enemyDur <= 0)
        {
            Destroy(Enemy);
            Debug.Log("Shot");
            Instantiate(Drop, EnemyPos, Quaternion.identity);
        }
    }
    void Update () {
        transform.position += -transform.up * dropSpeed * Time.deltaTime;
        EnemyPos = Enemy.transform.position;
    }
}