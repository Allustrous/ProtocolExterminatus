using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollisionSys : MonoBehaviour
{
    public static float bulletVelocity = 1.0f;
    public GameObject fruit;
    public GameObject bullet;

    void OnBecameInvisible() 
    {
        Destroy(gameObject);
        Debug.Log("Destroyed");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(bullet);
        Debug.Log("Destroyed");
    }
    void Update () {
        transform.position += transform.up * bulletVelocity * Time.deltaTime;
    }
}