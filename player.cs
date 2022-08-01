using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{    
    
     public float runSpeed = 40f;
     float horizontalMove = 0f;
     private Rigidbody2D rb;
    // bool isGrounded =  false;
     float flip = 0f;
     public static int health;
     public GameObject countDown;
     public static float transformX;
     public static float transformY;
     

     

      public Animator Animator;
      public GameObject cannonball;
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {  
Physics2D.IgnoreCollision(this.gameObject.GetComponent<Collider2D>(), cannonball.gameObject.GetComponent<Collider2D>());
      transformX= transform.position.x;
      transformY= transform.position.y;


       //Debug.Log(Gamesettings.cannonPowerClicked);
    // if(Gamesettings.cannonPowerClicked == 1)
      //   {
     
      //GameObject e = Instantiate(countDown) as GameObject;
        //e.transform.position = transform.position;

     //}
         //  flip = GetComponent<Rigidbody2D>().angularVelocity;
        flip = Rotation.horizontalMove;
         horizontalMove = GetComponent<Rigidbody2D>().velocity.x * runSpeed;
//Debug.Log(GetComponent<Rigidbody2D>().velocity.x);
        // Debug.Log(Mathf.Abs(horizontalMove));
        transform.eulerAngles = new Vector3(0f, 0f, 0f);
   //   GetComponent<Rigidbody2D>().angularVelocity =0f;
GetComponent<Rigidbody2D>().rotation =0f;
     // GetComponent<Rigidbody2D>().velocity =new Vector2(0f,0f);
 // GetComponent<Rigidbody2D>().centerOfMass = new Vector2(0f,0f);

     //GetComponent<Rigidbody2D>().inertia = 1f;
     
   //  Debug.Log(Mathf.Abs(horizontalMove));
       //Animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        Animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
//Debug.Log(horizontalMove);

//Debug.Log(GetComponent<Rigidbody2D>().angularVelocity);



         if (flip <= 0)
           {
                         gameObject.GetComponent<SpriteRenderer>().flipX = false;
            }
            if (flip >0)
           {
                         gameObject.GetComponent<SpriteRenderer>().flipX = true;
            }




    }

 
 




} 
