using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterFlash : MonoBehaviour
{
     public float respawnTime = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
         StartCoroutine(asteroidWave());
    }

    // Update is called once per frame
    void Update()
    {
         if(Gamesettings.waterflash == 1)
    {
       this.gameObject.SetActive(false);
           Destroy(this.gameObject);
           Gamesettings.waterflash = 0;
          // Time.timeScale = 1f;
    }
    }


    private void spawnEnemy(){
        
      Destroy(this.gameObject);
      this.gameObject.SetActive(false); 
        
       
    }


        IEnumerator asteroidWave(){
        while(true){
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }
}
