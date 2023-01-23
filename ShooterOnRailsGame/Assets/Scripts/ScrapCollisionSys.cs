using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrapCollisionSys : MonoBehaviour
{
    public static float dropSpeed = 0.8f;
    public GameObject Scrap;
    public static int scrapDur = 3;
    public GameObject SpeedKit;
    public Vector3 ScrapPos;

    void Start () {
        dropSpeed = 0.8f;
        scrapDur = 3;
    }

    void OnBecameInvisible() 
    {
        Destroy(gameObject);
    }
    void OnTriggerEnter2D (Collider2D targetObj) 
    {
       if(targetObj.gameObject.tag == "Bullet")
        {
            scrapDur -=1;
            Destroy(targetObj.gameObject);
            if(scrapDur <= 0)
            {
                Destroy(gameObject);
                Instantiate(SpeedKit, ScrapPos, Quaternion.identity);
                ScoreUI.scr +=2;
                scrapDur = 5;
            }
            
        } 
    }
    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        scrapDur -=1;

        if(scrapDur <= 0)
        {
            Destroy(Scrap);
            Instantiate(RateKit, ScrapPos, Quaternion.identity);
            Debug.Log("Shot");
            scrapDur = 5;
        }
    }*/
    void Update () {
        ScrapPos = Scrap.transform.position;
        transform.position += -transform.up * dropSpeed * Time.deltaTime;
    }
}