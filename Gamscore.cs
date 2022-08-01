using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(AudioSource))]
public class Gamscore : MonoBehaviour
{
// public  AudioSource[] m_MyAudioSource;
 AudioSource m_MyAudioSource;
  public AudioClip catchAudio;
 public  AudioClip abilityAudio;
public static int Score=0;
public Text ScoreText; 

 public GameObject waterFlash;
 public GameObject bucket;
 public Collider2D m_collider;
 public GameObject cannonball;






void start(){


Score =0;
Debug.Log(Score);
 

}

void Update()
{
 if (UnityAds.checkrewarded == 1)
        {

          Score = PlayerPrefs.GetInt("Recentscore", Gameover.recentscore);
        }

//Physics2D.IgnoreCollision(this.gameObject.GetComponent<Collider2D>(), cannonball.gameObject.GetComponent<Collider2D>());
if (Gamesettings.ScoreSet == 1)
{

  Score = 0;
  Gamesettings.ScoreSet =0;
}

}
 



    private void OnTriggerEnter2D(Collider2D other){

         Physics2D.IgnoreCollision(this.gameObject.GetComponent<Collider2D>(), cannonball.gameObject.GetComponent<Collider2D>());
                Vector3 m_Center;
                m_Center = m_collider.bounds.center;
     
 
                if(other.gameObject.tag != "healthcoin" && other.gameObject.tag != "moneycoin" )
      {
     
                 GameObject e = Instantiate(waterFlash) as GameObject;
                 e.transform.SetParent(bucket.transform);
                 e.transform.position = transform.position + new Vector3(0,1f);
                 m_MyAudioSource = GetComponent<AudioSource>();
                 m_MyAudioSource.clip =  catchAudio;
                 m_MyAudioSource.Play();
                 AddScore();
       }
    
                  

      if (other.gameObject.tag == "healthcoin")
      {
         m_MyAudioSource = GetComponent<AudioSource>();
       m_MyAudioSource.clip =  abilityAudio;
       m_MyAudioSource.Play();

      }

    }

    void AddScore(){
        Score++;
        ScoreText.text = Score.ToString();
        
    }
 
 



  
     

}
