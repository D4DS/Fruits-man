using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class music : MonoBehaviour


{

    private AudioSource audioSrc;
   
    private float musicVolume = 1f;
    
    public Slider volumeSlider;



    

    // Start is called before the first frame update
    void Start()
    {
     musicVolume= PlayerPrefs.GetFloat("backgroundVolume", musicVolume);

        volumeSlider.value = musicVolume;
        audioSrc =GetComponent<AudioSource>();



    }

    // Update is called once per frame
    void Update()
    {
         if (Gameover.backgroundsound == 1){

             audioSrc.volume = 0;


         }

         else if(Gamesettings.supportforbackgroundmusic == 1)
         {    
             Gameover.backgroundsound = 0;
           audioSrc.volume =PlayerPrefs.GetFloat("backgroundVolume", musicVolume);
         }
        else{
        audioSrc.volume = musicVolume;
       } 
       
       
       
     //  Debug.Log(Gameover.backgroundsound);
         }

    public void SetVolume(float vol)
    {


        musicVolume = vol;

        PlayerPrefs.SetFloat("backgroundVolume", musicVolume);
        
    }







 



}
