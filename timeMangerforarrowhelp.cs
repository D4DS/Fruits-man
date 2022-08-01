using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class timeMangerforarrowhelp : MonoBehaviour
{
     public float respawnTime = 1.0f;
     public static float slowdownFactor =   0.15f;
     public static float  slowdownLength = 2f;
    void Start()
    {
         StartCoroutine(asteroidWave());
         Time.timeScale = slowdownFactor;
         Time.fixedDeltaTime = Time.timeScale * 0.02f;

    }
        void Update()
    {    

    if(Gamesettings.cannontimehelpmanager == 1)
    {  
       this.gameObject.SetActive(false);
       Destroy(this.gameObject);
       Gamesettings.cannontimehelpmanager = 0;
       
    }
    
    if(timeManger.timehelpformonkey == 1)

    {
       this.gameObject.SetActive(false);
       Destroy(this.gameObject);
       timeManger.timehelpformonkey =0;

    }
    

    }


public void DoSlowMotion()
{

}

 private void timeAdjust(){
             Destroy(this.gameObject);
     this.gameObject.SetActive(false);
          Time.timeScale += (1f / slowdownLength) * Time.unscaledDeltaTime;
Time.timeScale = Mathf.Clamp(Time.timeScale, 0f,1f);

       
    }




        IEnumerator asteroidWave(){
        while(true){
            yield return new WaitForSeconds(respawnTime);
            timeAdjust();
        }
    }

}
