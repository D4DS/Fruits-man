using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{


    
    // Start is called before the first frame update
    public void PlayGame()
  {
  //   Gamesettings gp =FindObjectOfType<Gamesettings>();
    //if(gp._paused =false){
   //  gp._paused =false;
    // SceneManager.UnloadScene("level1");   
    // }

    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
      
  }
    

    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();


    }
}
