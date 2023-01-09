using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterWeaponSys : MonoBehaviour
{
    public GameObject playerShip;
    public GameObject projectile;
    private float fireRate = 3.5f;
    private float lastShot = 0.0f;
    private float timeStamp;
    
    // Start is called before the first frame update
    void Start()
    {
        timeStamp = Time.time + fireRate;
    }

    // Update is called once per frame
    void Update()
    {
         
        Vector3 shipPos = playerShip.transform.position;
        shipPos.y += 2;

        /*if(Input.GetKeyDown(KeyCode.Space) && timeStamp <= Time.time)
        {
            Instantiate(projectile, shipPos, Quaternion.identity);
            timeStamp += fireRate;
        }*/
        
        if(Input.GetKeyDown("space"))
        {
            if (Time.time > fireRate + lastShot)
            {
                Instantiate(projectile, shipPos, Quaternion.identity);
                lastShot = Time.time;
            }
        }
    }

}
