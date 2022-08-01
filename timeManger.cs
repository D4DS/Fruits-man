using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class timeManger : MonoBehaviour
{
public static float slowdownFactor =  0.15f;
public static float  slowdownLength = 2f;


public static int timehelpformonkey = 0;



//public void DoSlowMotion()
//{

   // Time.timeScale = slowdownFactor;
    //Time.fixedDeltaTime = Time.timeScale * 0.02f;
//}

void Start()
{
    timehelpformonkey = 1;
    Time.timeScale = slowdownFactor;
    Time.fixedDeltaTime = Time.timeScale * 0.02f;

}
        void Update()
    {    

    if(cannon.CheckTimeManager == 1)
    {     // Time.timeScale =1f;
           this.gameObject.SetActive(false);
           Destroy(this.gameObject);
           cannon.CheckTimeManager =0;
    
    }

    }


}