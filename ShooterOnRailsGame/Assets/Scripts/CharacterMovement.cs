using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public static float shipSpeed = 5f;
    public GameObject PlayerShip;
    public GameObject fruit;

    private float xMin, xMax;
    private float yMin, yMax;

    /*public GameObject Center;
    public GameObject Left;
    public GameObject Right;

    private Vector3 posCenter;
    private Vector3 posLeft;
    private Vector3 posRight;*/

    public HealthUI hpUI;
    public string dropTag;

    // Start is called before the first frame update
    void Start()
    {
        
        /*posCenter = Center.transform.position;
        posLeft = Left.transform.position;
        posRight = Right.transform.position;*/
        
        var spriteSize = GetComponent<SpriteRenderer>().bounds.size.x * .5f;
        var cam = Camera.main;
        var camHeight = cam.orthographicSize;
        var camWidth = cam.orthographicSize * cam.aspect;

        yMin = -camHeight + spriteSize;
        yMax = camHeight - spriteSize;
         
        xMin = -camWidth + spriteSize;
        xMax = camWidth - spriteSize;
    }

    // Update is called once per frame
    void Update()
    {
        var hor = Input.GetAxisRaw("Horizontal");

        var direction = new Vector2(hor, 0).normalized;
        direction *= shipSpeed * Time.deltaTime; // apply speed
 
        var xValidPosition = Mathf.Clamp(transform.position.x + direction.x, xMin, xMax);
        var yValidPosition = Mathf.Clamp(transform.position.y + direction.y, yMin, yMax);
 
        transform.position = new Vector3(xValidPosition, -4, 0f);
        /*if(Input.GetKeyDown(KeyCode.A))
        {
            PlayerShip.transform.position = posLeft;
        }
        else if(Input.GetKeyDown(KeyCode.S))
        {
            PlayerShip.transform.position = posCenter;
        }
        else if(Input.GetKeyDown(KeyCode.D))
        {
            PlayerShip.transform.position = posRight;
        }
        else
        {

        }*/
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        HealthUI.hp -= 1;
    }

    /*void OnTriggerEnter (Collider targetObj) 
    {
        if(targetObj.gameObject.tag == dropTag)
        {
            Destroy(targetObj.gameObject);
        }
    }*/
}
