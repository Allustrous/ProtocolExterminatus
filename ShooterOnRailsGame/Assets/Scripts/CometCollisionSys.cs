using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CometCollisionSys : MonoBehaviour
{
    public static float dropSpeed = 1.0f;
    public GameObject fruit;
    public GameObject RateKit;
    public Vector3 CometPos;
    public GameManagerSys deathDetection;

    void Start () {
        dropSpeed = 1.0f;
    }

    void OnBecameInvisible() 
    {
        Destroy(gameObject);
    }
    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(fruit);
        Debug.Log("Shot");
        
    }*/

    void OnTriggerEnter2D (Collider2D targetObj) 
    {
       if(targetObj.gameObject.tag == "Bullet")
        {
            Destroy(targetObj.gameObject);
            Destroy(gameObject);
            Instantiate(RateKit, CometPos, Quaternion.identity);
            ScoreUI.scr +=1;
            GameManagerSys.deathDetection++;
        } 
    }

    void Update () {
        CometPos = fruit.transform.position;
        transform.position += -transform.up * dropSpeed * Time.deltaTime;
    }
}