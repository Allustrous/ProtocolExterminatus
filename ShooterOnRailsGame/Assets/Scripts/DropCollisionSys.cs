using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropCollisionSys : MonoBehaviour
{
    public static float dropSpeed = 1f;
    public GameObject Drop;
    public HealthUI hpUI;


    void OnBecameInvisible() 
    {
        Destroy(gameObject);
        Debug.Log("Destroyed");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        HealthUI.hp += 2;
        Destroy(gameObject);
    }
     void Update () {
        transform.position += -transform.up * dropSpeed * Time.deltaTime;
    }
    
}