using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrapCollisionSys : MonoBehaviour
{
    public static float dropSpeed = 0.8f;
    public GameObject Scrap;
    public static int scrapDur = 2;

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
            Debug.Log("Shot");
        }
    }
    void Update () {
        transform.position += -transform.up * dropSpeed * Time.deltaTime;
    }
}