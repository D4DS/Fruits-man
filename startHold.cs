using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startHold : MonoBehaviour
{ public GameObject countDown;
public bool needplaygame = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        needplaygame = false;
      playgame();
    }



 public void playgame(){
if(needplaygame)
{
    Time.timeScale =1;
}
else
{
    Time.timeScale =0 ;
}
}
}
