using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enamy_monkey : MonoBehaviour
{
 //public GameObject monkeyrun;
    public GameObject ignoreanimal;
    public GameObject explosion;
    

 public float speed = 1.0f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;
    



    // Use this for initialization
    void Start () {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0,-speed);
                  }
    void update ()
    {
    }

    // Update is called once per frame




 private void OnTriggerEnter2D(Collider2D other) {
          if(  other.gameObject.layer == 9 || other.gameObject.layer == 13 || other.gameObject.layer == 12 ){
 Physics2D.IgnoreCollision(this.gameObject.GetComponent<Collider2D>(), other.gameObject.GetComponent<Collider2D>());
          }

 
        
          else{
      if (gameObject != null){
      if(other.gameObject.tag == "playman")
      {

             Destroy(this.gameObject);

    this.gameObject.SetActive(false);  
 GameObject e = Instantiate(explosion) as GameObject;
      e.transform.position = transform.position;


      }
      else {
                     Destroy(this.gameObject);

    this.gameObject.SetActive(false);  
 GameObject e = Instantiate(explosion) as GameObject;
      e.transform.position = transform.position;
            //     GameObject e = Instantiate(monkeyrun) as GameObject;
    //  e.transform.position = transform.position;  

      }


      
      }      
      
      
      
        }  

 
 }




 public void OnPointerDown()
 {

Debug.Log("onPointerDown monkey!");

 }
}
