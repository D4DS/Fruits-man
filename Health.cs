using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{    
  //public GameObject health;

public static int HealHealth;


AudioSource m_MyAudioSource;
  public AudioClip monkeyAudio;
 
     void start()
    {
       HealHealth = 0;
        
    }
    void Update()
    {
       
        
    }
        
     private void OnTriggerEnter2D(Collider2D other){
       if(other.gameObject.tag == "healthcoin")
      {
        AddScore();
      }

      if(other.gameObject.tag == "enemy_monkey")
      {

         DownScore();
        // Debug.Log("detect");
      }
    }
    

      void OnCollisionEnter2D(Collision2D other) {
          if(  other.gameObject.tag == "enemy_monkey"){
     DownScore();
          }}


      public  void AddScore(){
    
        /*if (HealHealth <=4){
        HealHealth++;
        }*/

        HealHealth = 1;
    }

          public  void DownScore(){
    
        /*if (HealHealth <=4){
        HealHealth++;
        }*/
 m_MyAudioSource = GetComponent<AudioSource>();
     m_MyAudioSource.clip =  monkeyAudio;
      m_MyAudioSource.Play();
        HealHealth = -1;
    }

}
