using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CometCollisionSys : MonoBehaviour
{
    public static float dropSpeed = 1.0f;
    public GameObject fruit;

    void OnBecameInvisible() 
    {
        Destroy(gameObject);
        Debug.Log("Destroyed");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(fruit);
        Debug.Log("Shot");
    }
    void Update () {
 
        transform.position += -transform.up * dropSpeed * Time.deltaTime;
    }
}