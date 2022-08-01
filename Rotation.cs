using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotation : MonoBehaviour
{
  public static float Rotz;
  public float rusSpeed = 1f;
  public static float horizontalMove = 0f;
  public Joystick joystick;
  public GameObject waterBall;
private Vector2 screenBounds;
public int right;
public int left;



void Start()
{
screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
right =1;
left =1;
}


    void Update()
    {
 //screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

    
    //  Debug.Log(joystick.Horizontal);
        horizontalMove = joystick.Horizontal * rusSpeed; 
        transform.rotation =  Quaternion.Euler(0, 0,horizontalMove);
//Debug.Log(joystick.Horizontal);
       if (joystick.Horizontal > 0.7f && right == 1)
        {
         GameObject c = Instantiate(waterBall)as GameObject;
          c.transform.position = new Vector2(-screenBounds.x,-screenBounds.y);
            right = 0;
            left = 1;
        }

        else if (joystick.Horizontal < -0.7f && left == 1)
        {
          GameObject d = Instantiate(waterBall)as GameObject;
         d.transform.position = new Vector2(screenBounds.x,-screenBounds.y);
         left = 0;
         right = 1;

        }


    }


 
}
