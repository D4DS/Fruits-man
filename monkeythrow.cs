using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monkeythrow : MonoBehaviour
{
    public GameObject[] asteroidPrefab;
    bool runOnce;
    

    string[] check ={"true","false"};
    public GameObject monkey;
    public GameObject treeroot;
    public Rigidbody2D rb2d;
    public float respawnTime = 4.0f;
    public float fruitrespawnTime = 1.35f;
    public float gravitychangeTime = 1.4f;
    // Start is called before the first frame update
    void Start()
    {    int randobject = Random.Range(0,check.Length);

        bool mycheck =bool.Parse(check[randobject]);
        monkey.gameObject.GetComponent<SpriteRenderer>().flipX = mycheck;
        rb2d = GetComponent<Rigidbody2D> ();
     

          GameObject b = Instantiate(treeroot)as GameObject;
          b.transform.SetParent(monkey.transform);

 b.transform.rotation = Quaternion.Euler(Vector3.forward * 0);

        if(mycheck == false){
      
    // GameObject b = Instantiate(treeroot)as GameObject;
      //   b.transform.SetParent(monkey.transform);
         b.transform.position = transform.position + new Vector3(-2 * monkey.transform.localScale.x,-3 * monkey.transform.localScale.y);;
   //      b.transform.rotation = Quaternion.Euler(Vector3.forward * 0);
        
        }

        if(mycheck == true)
        {
      //    GameObject b = Instantiate(treeroot)as GameObject;
      //    b.transform.SetParent(monkey.transform);
          monkey.transform.rotation = Quaternion.Euler(Vector3.forward * -45);
          b.transform.rotation = Quaternion.Euler(Vector3.forward * 0);
          b.transform.position = transform.position + new Vector3(+2 * monkey.transform.localScale.x,-3 * monkey.transform.localScale.y);;
      

        }
        StartCoroutine(asteroidWave());
        StartCoroutine(spawnfruittime());
        StartCoroutine(gravitychange());
    }







    private void spawnfruit(){
   
 int randobject = Random.Range(0,asteroidPrefab.Length);
GameObject a = Instantiate(asteroidPrefab[randobject])as GameObject;
   if(monkey.gameObject.GetComponent<SpriteRenderer>().flipX == false){

a.transform.position = transform.position + new Vector3(-2 * monkey.transform.localScale.x,-1.5f * monkey.transform.localScale.y);

   }
   if(monkey.gameObject.GetComponent<SpriteRenderer>().flipX == true)
   {

   a.transform.position = transform.position + new Vector3(+2 * monkey.transform.localScale.x,-1.5f * monkey.transform.localScale.y);    
   }



    }


        private void destorymonkey(){
        
            Destroy(this.gameObject);
      this.gameObject.SetActive(false); 

        
       
    }


    private void gravity()
    {
        
        rb2d.gravityScale = -2f;
    
        
        


    }

    private void monkeyposition()
    {
      
     monkey.transform.rotation = Quaternion.Euler(Vector3.forward * 30);

    }

            IEnumerator gravitychange(){
        while(true){
            yield return new WaitForSeconds(gravitychangeTime);
            gravity();
           // monkeyposition();

        }


      
}


        IEnumerator asteroidWave(){
        while(true){
            yield return new WaitForSeconds(respawnTime);
            destorymonkey();

        }


      
}
  IEnumerator spawnfruittime(){
        while(true){
            yield return new WaitForSeconds(fruitrespawnTime);
            spawnfruit();
        }
}}
