using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class asteroid : MonoBehaviour
{

    public GameObject explosion;
    public GameObject ignoreanimal;
    

 //public float speed = 3.0f;

    private Rigidbody2D rb;
    
    private Vector2 screenBounds;
    private float Randomspeed;
    



    // Use this for initialization
    void Start () {

    // Debug.Log(rb.velocity.magnitude);
   //  rb = this.GetComponent<Rigidbody2D>();
     //   rb.velocity = new Vector2(0,-speed);
       Randomspeed = Random.Range(1.0f,4.0f);
//

//Debug.Log(Randomspeed);
    }
    void FixedUpdate ()
    {
 
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0,-Randomspeed);

    }

    // Update is called once per frame




 private void OnTriggerEnter2D(Collider2D other) {
          if( other.gameObject.layer == 9  || other.gameObject.layer == 10  ||other.gameObject.layer == 14 || other.gameObject.layer == 13){
 Physics2D.IgnoreCollision(this.gameObject.GetComponent<Collider2D>(), other.gameObject.GetComponent<Collider2D>());
                                                 }

 
        
          else{
      if (gameObject != null){
      if(other.gameObject.tag != "playman" && other.gameObject.layer != 11 && other.gameObject.layer !=13)
      {
      GameObject e = Instantiate(explosion) as GameObject;
      e.transform.position = transform.position;

      }
            Destroy(this.gameObject);
      this.gameObject.SetActive(false);

      
      }      
      
      
      
        }  

         


      

    
    





 
 }
}
