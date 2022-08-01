using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monkeyrun : MonoBehaviour
{


     private Rigidbody2D rb;
     float flip = 0f;
      float horizontalMove = 0f;
      public float runSpeed = 40f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        flip = GetComponent<Rigidbody2D>().angularVelocity;
                 horizontalMove = GetComponent<Rigidbody2D>().velocity.x * runSpeed;
        transform.eulerAngles = new Vector3(0f, 0f, 0f);
              if (flip <= 0)
           {
                         gameObject.GetComponent<SpriteRenderer>().flipX = true;
            }
            if (flip >0)
           {
                         gameObject.GetComponent<SpriteRenderer>().flipX = false;
            }
    }



      void OnCollisionEnter2D(Collision2D other) {
          if(  other.gameObject.layer == 9 || other.gameObject.layer == 13){
 Physics2D.IgnoreCollision(this.gameObject.GetComponent<Collider2D>(), other.gameObject.GetComponent<Collider2D>());
          }

 
        
          else{
      if (gameObject != null){
      if(other.gameObject.tag == "playman")
      {

             Destroy(this.gameObject);

    this.gameObject.SetActive(false);  



      }



      
      }      
      
      
      
        }  

 
 }

}
