using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class framechanger : MonoBehaviour
{
     public float respawnTime = 5f;
    // Start is called before the first frame update
    void Start()
    {
         StartCoroutine(asteroidWave());
    }

    // Update is called once per frame
    void Update()
    {
        
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
