using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RandomSpawnSys : MonoBehaviour
{

    public GameObject fruit;
    public GameObject Scrap;
    public GameObject Enemy;
    public float x = 0f;
    public static float running = 0; 
    public int spawnOne = 0;
    public int spawnTwo = 0;
    public int spawnThree = 0;

    void Start()
    {
        StartCoroutine("SpawnRoutine1");
        StartCoroutine("SpawnRoutine2");
        StartCoroutine("SpawnRoutine3");
    }

    void Update()
    {
        
    }

    IEnumerator SpawnRoutine1()
    {
        while(running == 0)
        {
            spawnOne = Random.Range(0,10);
            if(spawnOne == 1)
            {
                Debug.Log("spawn 1");
                Vector3 pos1 = new Vector3(x-7, transform.position.y + 1);
                Instantiate(fruit, pos1, Quaternion.identity);
                yield return new WaitForSeconds(3);
                
            }
            else if(spawnOne == 2)
            {
                Debug.Log("spawn 2");
                Vector3 pos2 = new Vector3(x-5, transform.position.y + 1);
                Instantiate(fruit, pos2, Quaternion.identity);
                yield return new WaitForSeconds(3);
                
            }
            else if(spawnOne == 3)
            {
                Debug.Log("spawn 3");
                Vector3 pos2 = new Vector3(x-3, transform.position.y + 1);
                Instantiate(fruit, pos2, Quaternion.identity);
                yield return new WaitForSeconds(3);
                
            }
            else if(spawnOne == 4)
            {
                Debug.Log("spawn 4");
                Vector3 pos2 = new Vector3(x-1, transform.position.y + 1);
                Instantiate(fruit, pos2, Quaternion.identity);
                yield return new WaitForSeconds(3);
                
            }
            else if(spawnOne == 5)
            {
                Debug.Log("spawn 5");
                Vector3 pos2 = new Vector3(x+1, transform.position.y + 1);
                Instantiate(fruit, pos2, Quaternion.identity);
                yield return new WaitForSeconds(3);
                
            }
            else if(spawnOne == 6)
            {
                Debug.Log("spawn 6");
                Vector3 pos2 = new Vector3(x+3, transform.position.y + 1);
                Instantiate(fruit, pos2, Quaternion.identity);
                yield return new WaitForSeconds(3);
                
            }
            else if(spawnOne == 7)
            {
                Debug.Log("spawn 7");
                Vector3 pos2 = new Vector3(x+5, transform.position.y + 1);
                Instantiate(fruit, pos2, Quaternion.identity);
                yield return new WaitForSeconds(3);
                
            }
            else if(spawnOne == 8)
            {
                Debug.Log("spawn 8");
                Vector3 pos2 = new Vector3(x+7, transform.position.y + 1);
                Instantiate(fruit, pos2, Quaternion.identity);
                yield return new WaitForSeconds(3);
                
            }
            else if(spawnOne == 9)
            {
                Debug.Log("spawn 9");
                Vector3 pos2 = new Vector3(x-9, transform.position.y + 1);
                Instantiate(fruit, pos2, Quaternion.identity);
                yield return new WaitForSeconds(3);
                
            }
            else
            {
                Debug.Log("spawn 10");
                Vector3 pos2 = new Vector3(x+9, transform.position.y + 1);
                Instantiate(fruit, pos2, Quaternion.identity);
                yield return new WaitForSeconds(3);
                
            }
        }
    }

    IEnumerator SpawnRoutine2()
    {
        while(running == 0)
        {
            spawnTwo = Random.Range(0,10);
            if(spawnTwo == 1)
            {
                Debug.Log("spawn 1");
                Vector3 pos1 = new Vector3(x-7, transform.position.y + 1);
                Instantiate(Scrap, pos1, Quaternion.identity);
                yield return new WaitForSeconds(6);
                
            }
            else if(spawnTwo == 2)
            {
                Debug.Log("spawn 2");
                Vector3 pos2 = new Vector3(x-5, transform.position.y + 1);
                Instantiate(Scrap, pos2, Quaternion.identity);
                yield return new WaitForSeconds(6);
                
            }
            else if(spawnTwo == 3)
            {
                Debug.Log("spawn 3");
                Vector3 pos2 = new Vector3(x-3, transform.position.y + 1);
                Instantiate(Scrap, pos2, Quaternion.identity);
                yield return new WaitForSeconds(6);
                
            }
            else if(spawnTwo == 4)
            {
                Debug.Log("spawn 4");
                Vector3 pos2 = new Vector3(x-1, transform.position.y + 1);
                Instantiate(Scrap, pos2, Quaternion.identity);
                yield return new WaitForSeconds(6);
                
            }
            else if(spawnTwo == 5)
            {
                Debug.Log("spawn 5");
                Vector3 pos2 = new Vector3(x+1, transform.position.y + 1);
                Instantiate(Scrap, pos2, Quaternion.identity);
                yield return new WaitForSeconds(6);
                
            }
            else if(spawnTwo == 6)
            {
                Debug.Log("spawn 6");
                Vector3 pos2 = new Vector3(x+3, transform.position.y + 1);
                Instantiate(Scrap, pos2, Quaternion.identity);
                yield return new WaitForSeconds(6);
                
            }
            else if(spawnTwo == 7)
            {
                Debug.Log("spawn 7");
                Vector3 pos2 = new Vector3(x+5, transform.position.y + 1);
                Instantiate(Scrap, pos2, Quaternion.identity);
                yield return new WaitForSeconds(6);
                
            }
            else if(spawnTwo == 8)
            {
                Debug.Log("spawn 8");
                Vector3 pos2 = new Vector3(x+7, transform.position.y + 1);
                Instantiate(Scrap, pos2, Quaternion.identity);
                yield return new WaitForSeconds(6);
                
            }
            else if(spawnTwo == 9)
            {
                Debug.Log("spawn 9");
                Vector3 pos2 = new Vector3(x-9, transform.position.y + 1);
                Instantiate(Scrap, pos2, Quaternion.identity);
                yield return new WaitForSeconds(6);
                
            }
            else
            {
                Debug.Log("spawn 10");
                Vector3 pos2 = new Vector3(x+9, transform.position.y + 1);
                Instantiate(fruit, pos2, Quaternion.identity);
                yield return new WaitForSeconds(6);
                
            }
        }
    }

    IEnumerator SpawnRoutine3()
    {
        while(running == 0)
        {
            spawnThree = Random.Range(0,10);
            if(spawnOne == 1)
            {
                Debug.Log("spawn 1");
                Vector3 pos1 = new Vector3(x-7, transform.position.y + 1);
                Instantiate(Enemy, pos1, Quaternion.identity);
                yield return new WaitForSeconds(8);
                
            }
            else if(spawnThree == 2)
            {
                Debug.Log("spawn 2");
                Vector3 pos2 = new Vector3(x-5, transform.position.y + 1);
                Instantiate(Enemy, pos2, Quaternion.identity);
                yield return new WaitForSeconds(8);
                
            }
            else if(spawnThree == 3)
            {
                Debug.Log("spawn 3");
                Vector3 pos2 = new Vector3(x-3, transform.position.y + 1);
                Instantiate(Enemy, pos2, Quaternion.identity);
                yield return new WaitForSeconds(8);
                
            }
            else if(spawnThree == 4)
            {
                Debug.Log("spawn 4");
                Vector3 pos2 = new Vector3(x-1, transform.position.y + 1);
                Instantiate(Enemy, pos2, Quaternion.identity);
                yield return new WaitForSeconds(8);
                
            }
            else if(spawnThree == 5)
            {
                Debug.Log("spawn 5");
                Vector3 pos2 = new Vector3(x+1, transform.position.y + 1);
                Instantiate(Enemy, pos2, Quaternion.identity);
                yield return new WaitForSeconds(8);
                
            }
            else if(spawnThree == 6)
            {
                Debug.Log("spawn 6");
                Vector3 pos2 = new Vector3(x+3, transform.position.y + 1);
                Instantiate(Enemy, pos2, Quaternion.identity);
                yield return new WaitForSeconds(8);
                
            }
            else if(spawnThree == 7)
            {
                Debug.Log("spawn 7");
                Vector3 pos2 = new Vector3(x+5, transform.position.y + 1);
                Instantiate(Enemy, pos2, Quaternion.identity);
                yield return new WaitForSeconds(8);
                
            }
            else if(spawnThree == 8)
            {
                Debug.Log("spawn 8");
                Vector3 pos2 = new Vector3(x+7, transform.position.y + 1);
                Instantiate(Enemy, pos2, Quaternion.identity);
                yield return new WaitForSeconds(8);
                
            }
            else if(spawnThree == 9)
            {
                Debug.Log("spawn 9");
                Vector3 pos2 = new Vector3(x-9, transform.position.y + 1);
                Instantiate(Enemy, pos2, Quaternion.identity);
                yield return new WaitForSeconds(8);
                
            }
            else
            {
                Debug.Log("spawn 10");
                Vector3 pos2 = new Vector3(x+9, transform.position.y + 1);
                Instantiate(Enemy, pos2, Quaternion.identity);
                yield return new WaitForSeconds(8);
                
            }
        }
    }
}