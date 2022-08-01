using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployAsteroids : MonoBehaviour
{
//public GameObject[] asteroidPrefab;
public GameObject health;
public GameObject collitionright;
public GameObject collitionleft;
public GameObject healthLocation;
public GameObject monkey;
public GameObject monkeyEnemy;
//public timeMangerforarrowhelp timeMangerforarrowhelp;
public GameObject timeMangerforarrowhelpPrefab;
public GameObject CannonPowerPanel;
AudioSource m_MyAudioSource;
  public AudioClip backgroundAudio;
  public GameObject  arrowforcannon;
  public GameObject cannonPowerButton;
  public  GameObject gameInstruct;


    public float respawnTime = 1.0f;
    private Vector2 screenBounds;
    private static  int changescore;
    private static  int changescore1;
    //public float healthlocate = 0.159;
    
    

    // Use this for initialization
    void Start () {

         Time.timeScale =0;
         m_MyAudioSource = GetComponent<AudioSource>();
         m_MyAudioSource.clip =  backgroundAudio;
         m_MyAudioSource.Play();
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
  
       float healthlocatex =(float) (1.7);
       float healthlocatey =(float) (4.8);
        collitionright.transform.position = new Vector2(screenBounds.x, 0);
        collitionleft.transform.position = new Vector2(-screenBounds.x, 0);
        healthLocation.transform.position = new Vector2(screenBounds.x - healthlocatex, healthlocatey);



     //  Debug.Log(screenBounds.x);
       // Debug.Log(-screenBounds.x);

        StartCoroutine(asteroidWave());
    }

 
 public void Update()
 {
           
      
      changescore = Gamscore.Score;
      if(changescore >= 25 && changescore <50){
         respawnTime = 0.9f;
      }
    
      if(changescore>= 50 &&  changescore <75)
      {

          respawnTime = 0.8f;
      }
       if(changescore>= 75 &&  changescore <100)
      {

          respawnTime = 0.7f;
      }

       if(changescore>=100  &&  changescore <125)
      {
          respawnTime = Random.Range(0.4f,0.6f);
        
      }

          if(changescore>=125 &&  changescore <150  )
      {
          respawnTime = Random.Range(0.2f,0.4f);
        
      }
          if(changescore>=150 &&   changescore <170 )
      {
          respawnTime = Random.Range(0.1f,0.2f);
        
      }

            if(changescore>=170 )
      {
          respawnTime = Random.Range(0.07f,0.1f);
        
      }


 }
    
 private void spawnEnemy(){


if (PlayerPrefs.GetInt("gameInstruction") == 3)
{
      Time.timeScale = 1f;
      
}
else{

      Time.timeScale = 0f;
      gameInstruct.gameObject.SetActive(true);
}














      if (changescore == Random.Range(changescore,changescore+25))
 {
         GameObject b = Instantiate(health)as GameObject;
         b.transform.position = new Vector2(Random.Range(-screenBounds.x + health.transform.localScale.x, screenBounds.x - health.transform.localScale.x), screenBounds.y);
 }
       if (changescore == Random.Range(changescore,changescore+15))
 {
         GameObject d = Instantiate(monkeyEnemy)as GameObject;
         d.transform.position = new Vector2(Random.Range(-screenBounds.x + monkeyEnemy.transform.localScale.x + 2.0f, screenBounds.x - monkeyEnemy.transform.localScale.x - 2.0f), screenBounds.y);
 
       if (PlayerPrefs.GetInt("cannonInstruction") == 3)
        {
          Gamesettings.waterflash =1;
          cannon.CheckTimeManager =1;
         // Gamesettings.cannontimehelpmanager =1;
          
          GameObject l = Instantiate(timeMangerforarrowhelpPrefab)as GameObject;
          

          
  
       }
       else{
         arrowforcannon.SetActive(true);
         Gamesettings.cannonPowerClicked =0;
         CannonPowerPanel.gameObject.SetActive(true);
         StartCoroutine(arrowhelpfor());
         Gamesettings.waterflash = 1;
         cannon.CheckTimeManager =1;
         Time.timeScale = 0f;


       }
         
   


 }

    
            GameObject c = Instantiate(monkey)as GameObject;

            c.transform.position = new Vector2(Random.Range(-screenBounds.x + 4*monkey.transform.localScale.x, screenBounds.x - 4*monkey.transform.localScale.x), screenBounds.y + monkey.transform.localScale.y + 0.2f);

        
    
    }

 


    IEnumerator asteroidWave(){
        while(true){
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }


    IEnumerator arrowhelpfor(){
        while(true){
            yield return new WaitForSeconds(respawnTime);
           arrowforcannon.gameObject.SetActive(false);
        }
    }



}
