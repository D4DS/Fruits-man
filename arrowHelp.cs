using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowHelp : MonoBehaviour
{
    public float respawnTime = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        // StartCoroutine(asteroidWave());
    }

    // Update is called once per frame
    void Update()
    {
        if(Gamesettings.cannonPowerClicked == 1)
        {
            
        this.gameObject.SetActive(false);
        }
    }


 /*   private void spawnEnemy(){
        
            Destroy(this.gameObject);
      this.gameObject.SetActive(false); 
        
       
    }


        IEnumerator asteroidWave(){
        while(true){
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }*/
}
