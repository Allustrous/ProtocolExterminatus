using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrapCollisionSys : MonoBehaviour
{
    public static float dropSpeed = 0.8f;
    public GameObject Scrap;
    public static int scrapDur = 5;
    public GameObject RateKit;
    public Vector3 ScrapPos;

    void OnBecameInvisible() 
    {
        Destroy(gameObject);
        Debug.Log("Destroyed");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        scrapDur -=1;

        if(scrapDur <= 0)
        {
            Destroy(Scrap);
            Instantiate(RateKit, ScrapPos, Quaternion.identity);
            Debug.Log("Shot");
            scrapDur = 5;
        }
    }
    void Update () {
        ScrapPos = Scrap.transform.position;
        transform.position += -transform.up * dropSpeed * Time.deltaTime;
    }
}