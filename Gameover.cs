using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gameover : MonoBehaviour
{
public GameObject  hud_heartFull1,hud_heartFull2,hud_heartFull3,hud_heartFull4,hud_heartFull5;
public int Score;

bool runOnce;
public static int Healthcal;
public int healthcheck;
public Text ScoreText;
public static int bestscore;
public static int highscore;
public static int recentscore;
public static int recentscore1;
 AudioSource m_MyAudioSource;
  public AudioClip dropAudio;
 public  AudioClip gameoverAudio;
 public AudioClip monkeyAudio;
 public GameObject gameoverRestart;
 public GameObject settingsbutton;
 public GameObject archivementbutton;
 public GameObject CannonGirlButton;
 
 public GameObject  facebookbutton;
 public GameObject pauseButton;
 public GameObject exitbutton2;
 public GameObject joystick;

public static int backgroundsound = 0;
 public GameObject connonGirl;
 public Text HighScoreText;
 public Text RecentScoreText;


   

    void Start()
    {

        healthcheck = 5;
        hud_heartFull5.gameObject.SetActive(true);
        hud_heartFull4.gameObject.SetActive(true);
        hud_heartFull3.gameObject.SetActive(true);
        hud_heartFull2.gameObject.SetActive(true);
        hud_heartFull1.gameObject.SetActive(true);

    }

    // Update is called once per frame
   public void Update(){

//bestscore =Gamscore.Score;
highscore=PlayerPrefs.GetInt("highscore", highscore);
recentscore1 =  PlayerPrefs.GetInt("Recentscore", recentscore);
HighScoreText.text = highscore.ToString();
RecentScoreText.text = recentscore1.ToString();
          
      if (healthcheck <=5 && healthcheck >=0){
            
        if (Health.HealHealth == 1 && healthcheck <5 || Health.HealHealth == -1 && healthcheck >-5 ){
              healthcheck =healthcheck+ Health.HealHealth;
        }

          Health.HealHealth = 0;
         }

       if (healthcheck == 5){
            hud_heartFull5.gameObject.SetActive(true);
            hud_heartFull4.gameObject.SetActive(true);
            hud_heartFull3.gameObject.SetActive(true);
            hud_heartFull2.gameObject.SetActive(true);
            hud_heartFull1.gameObject.SetActive(true);
        }
         
        
              
       if (healthcheck == 4){
            hud_heartFull5.gameObject.SetActive(false);
            hud_heartFull4.gameObject.SetActive(true);
            hud_heartFull3.gameObject.SetActive(true);
            hud_heartFull2.gameObject.SetActive(true);
            hud_heartFull1.gameObject.SetActive(true);
        }
        if (healthcheck == 3){
            hud_heartFull5.gameObject.SetActive(false);
            hud_heartFull4.gameObject.SetActive(false);
            hud_heartFull3.gameObject.SetActive(true);
            hud_heartFull2.gameObject.SetActive(true);
            hud_heartFull1.gameObject.SetActive(true);
        }
        if (healthcheck == 2){
            hud_heartFull5.gameObject.SetActive(false);
            hud_heartFull4.gameObject.SetActive(false);
            hud_heartFull3.gameObject.SetActive(false);
            hud_heartFull2.gameObject.SetActive(true);
            hud_heartFull1.gameObject.SetActive(true);
        }
        if (healthcheck == 1){
            hud_heartFull5.gameObject.SetActive(false);
            hud_heartFull4.gameObject.SetActive(false);
            hud_heartFull3.gameObject.SetActive(false);
            hud_heartFull2.gameObject.SetActive(false);
            hud_heartFull1.gameObject.SetActive(true);
        }
        if (healthcheck == 0){
            hud_heartFull5.gameObject.SetActive(false);
            hud_heartFull4.gameObject.SetActive(false);
            hud_heartFull3.gameObject.SetActive(false);
            hud_heartFull2.gameObject.SetActive(false);
            hud_heartFull1.gameObject.SetActive(false);
        }

        if (UnityAds.checkrewarded == 1)
        {

          healthcheck =3;
          UnityAds.checkrewarded =0;
          runOnce = false;
        }

       if(healthcheck == 0 ){
           Youlose();
        
        }
        
    }
void Gamedown()
{

  Debug.Log(healthcheck);
}

      void Youlose(){

      if (runOnce == false){
       m_MyAudioSource = GetComponent<AudioSource>();
       m_MyAudioSource.clip =  gameoverAudio;
       m_MyAudioSource.Play();
       ScoreText.text = "Game Over!";
       gameoverRestart.gameObject.SetActive(true);
       settingsbutton.gameObject.SetActive(false);
       archivementbutton.gameObject.SetActive(false);
      
       facebookbutton.gameObject.SetActive(false);
       pauseButton.gameObject.SetActive(false);
       exitbutton2.gameObject.SetActive(true);
      connonGirl.gameObject.SetActive(false);
      CannonGirlButton.gameObject.SetActive(false);  
      joystick.gameObject.SetActive(false);  
        cannon.CheckTimeManager =1;
       // Gamesettings.cannontimehelpmanager = 1;
        
        backgroundsound = 1;
        Time.timeScale = 0f;
        runOnce =true;
        SaveHighscore();


    }}
    private void OnTriggerEnter2D(Collider2D other){

            if(other.gameObject.tag != "healthcoin" && other.gameObject.tag != "moneycoin" && other.gameObject.tag != "enemy_monkey" )
      {

    
       m_MyAudioSource = GetComponent<AudioSource>();
     m_MyAudioSource.clip =  dropAudio;
      m_MyAudioSource.Play();
        
          AddScore();

      

      }

      if (other.gameObject.tag == "enemy_monkey")
      {

   m_MyAudioSource = GetComponent<AudioSource>();
     m_MyAudioSource.clip =  monkeyAudio;
      m_MyAudioSource.Play();

      }
    }

     void SaveHighscore(){
       bestscore =Gamscore.Score;
     if (bestscore >PlayerPrefs.GetInt("highscore", highscore) )
     {   highscore = bestscore;
   //  text.text = "" + bestscore;
 // HighScoreText.text = highscore.ToString();
       PlayerPrefs.SetInt("highscore", highscore);
       recentscore = bestscore;
       PlayerPrefs.SetInt("Recentscore", recentscore);
       PlayerPrefs.Save();
 }
 
 else {
    recentscore = bestscore;
   PlayerPrefs.SetInt("Recentscore", recentscore);
 }
 }



    void AddScore(){
        Score++;
    

      healthcheck=healthcheck - 1;
    }
}
