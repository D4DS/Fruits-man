using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameoverpanel : MonoBehaviour
{
    public static int Highscore;
public static int Recentcore;
public Text scoretext;
public Text highscoretext;
    // Start is called before the first frame update
  void Start()
{

     Highscore = Gameover.highscore;
     Recentcore= Gameover.recentscore;
     scoretext.text = Highscore.ToString();
    highscoretext.text = Recentcore.ToString();

}

    // Update is called once per frame
    void Update()
    {
        
    }
}
