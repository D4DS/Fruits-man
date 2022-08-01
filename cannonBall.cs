using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonBall : MonoBehaviour
{
    public float canonrespawnTime = 3.35f;
    public GameObject explosion;
    AudioSource m_MyAudioSource;
 public AudioClip CountDownMusic;

    // Start is called before the first frame update
    void Start()
    {
      m_MyAudioSource = GetComponent<AudioSource>();
      m_MyAudioSource.clip =  CountDownMusic;
      m_MyAudioSource.Play();  
        StartCoroutine(cannonBalltime());
    }

    // Update is called once per frame
    void Update()
    {
        
    }




 public void spawnBall()
 {

        Destroy(this.gameObject);
      this.gameObject.SetActive(false);
 }


  IEnumerator cannonBalltime(){
        while(true){
            yield return new WaitForSeconds(canonrespawnTime);
            spawnBall();
        }
}


private void OnTriggerEnter2D(Collider2D other) {
Debug.Log("detect");
 if( other.gameObject.layer == 9  || other.gameObject.layer == 10 || other.gameObject.layer == 11 ){
 Physics2D.IgnoreCollision(this.gameObject.GetComponent<Collider2D>(), other.gameObject.GetComponent<Collider2D>());
                                                 }


 if(other.gameObject.tag != "playman" && other.gameObject.layer != 11 &&  other.gameObject.layer != 9  && other.gameObject.layer != 10 )
      {
      GameObject e = Instantiate(explosion) as GameObject;
      e.transform.position = transform.position;
      Destroy(this.gameObject);
      this.gameObject.SetActive(false);

      }

}
 public   void OnCollisionEnter2D(Collision2D other) {

 if(   other.gameObject.layer == 10 ){
Physics2D.IgnoreCollision(this.gameObject.GetComponent<Collider2D>(), other.gameObject.GetComponent<Collider2D>());
      Destroy(this.gameObject);
      this.gameObject.SetActive(false);
 }


       
      }
}
