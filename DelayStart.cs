

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DelayStart : MonoBehaviour
{  // public GameObject countDown;
  //  public AudioClip CountDownMusic;
 
AudioSource m_MyAudioSource;
 public AudioClip CountDownMusic;
    void Start()
    {
     
    
   
StartCoroutine(StartDelay());
   
  m_MyAudioSource = GetComponent<AudioSource>();
     m_MyAudioSource.clip =  CountDownMusic;
      m_MyAudioSource.Play();  
    }
    public  void StopDelay(){
      
     // btnPressed = true;
    // clicked =11;
    Debug.Log("you clicked");
      //Debug.Log(clicked);
         // Destroy(countDown.gameObject);  
    StopCoroutine(StartDelay());
     
    }
 
    void Update()
    {    
    //  if(Input.GetButton("Fire1"))
     // {
      //  Destroy(this.gameObject);

      
      
      //}

  // Debug.Log(Gamesettings.clicked);
    if(Gamesettings.clicked == 1)
    {
       this.gameObject.SetActive(false);
           Destroy(this.gameObject);
    }

    }
 

    // Update is called once per frame
 

    public   IEnumerator  StartDelay() {


        Time.timeScale =0;
        float pauseTime =   Time.realtimeSinceStartup + 3f;
        while (Time.realtimeSinceStartup < pauseTime)
       // yield return 0;
       
     yield return  null;
       // countDown.gameObject.SetActive (false);
        Destroy(this.gameObject);
      
        Time.timeScale =1f;
          }









}
