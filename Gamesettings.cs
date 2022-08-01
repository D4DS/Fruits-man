using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Gamesettings : MonoBehaviour
{ 
public Text boardText;
public GameObject timeManger;
public GameObject player;
public static float  Timerforvalue;
public GameObject countDown;
public GameObject countframe;
public GameObject CannonPower;
public GameObject cannonpowerPanel;
public static int clicked = 0;
public static int cannonPowerClicked = 0;
public static int checkInstruction =0;
public static int cannontimehelpmanager = 0;
public static int supportforbackgroundmusic =0;

public static int gameInstruction = 0;
public static int waterflash = 0;
public static int ScoreSet =0;
public  Text playtoResumeText;  
  
     public void deployed()
    {

     GameObject e = Instantiate(countDown) as GameObject;
      

    }
    
       
       public   void SettingsGame()
  {
       playtoResumeText.text = "Resume";
       clicked = 1;
       Time.timeScale = 0f;      
   }
  void Update()
   {
                  
   }
    public void playGame()
   {
     
     boardText.text = " ";
     deployed();
     Time.timeScale = 1f;
   }
    public void PauseGame()
   {
     boardText.text = "Pause!";

     Time.timeScale = 0f;
     clicked = 1;
     // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
   }
     public void ResumeGame()
   {
     boardText.text = "Resume!";
     clicked = 0;
     Time.timeScale = 1f;
     deployed();
    }

     public void RestartGame()
    {
     Time.timeScale = 0f;
     clicked = 1;
    

    }
     public void CancelRestartGame()
    {
     Time.timeScale = 1f;
     clicked = 0;
     deployed();
    }
     public void OkRestartGame()
    {
     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
     ScoreSet =1;
     clicked =0;
     Gameover.backgroundsound =0;
     supportforbackgroundmusic =1;
     

     {
         
     }
    }
      public void closebutton()
    {
     Time.timeScale = 1f;

    }
      public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }


    public void connonPower()
    {  clicked = 1;
       cannonPowerClicked = 1;
       cannontimehelpmanager = 1;
       waterflash =1;
       GameObject l = Instantiate(timeManger)as GameObject;
       CannonPower.SetActive(true);
       cannonpowerPanel.gameObject.SetActive(false);
       GameObject e = Instantiate(countframe) as GameObject;
       e.transform.position = new Vector2(player.transform.position.x,player.transform.position.y);  
       GameObject g = Instantiate(countframe) as GameObject;
       g.transform.position = new Vector2(CannonPower.transform.position.x,CannonPower.transform.position.y);  
       
       }


    public void ScoreButton()
    {
      clicked = 1;
       Time.timeScale = 0f;
    }

    public void ConnoInstruction()
    { checkInstruction =3;
       
      PlayerPrefs.SetInt("cannonInstruction", checkInstruction);
    }

    public void scoreclosepanel()
    {

      clicked = 0;
    }


    public void infoClose()
    {


           gameInstruction =3;
       
     PlayerPrefs.SetInt("gameInstruction", gameInstruction);
     Time.timeScale = 1f;
    }

}
