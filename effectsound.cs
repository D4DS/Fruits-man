using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class effectsound : MonoBehaviour
{
    private AudioSource audioSrc1;
private float effectsounds = 1f;
public Slider volumeSlider2;
    // Start is called before the first frame update
    void Start()
    {
             effectsounds= PlayerPrefs.GetFloat("effectsounds", effectsounds);

        volumeSlider2.value = effectsounds;
        audioSrc1 =GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        audioSrc1.volume = effectsounds;
    }
               public void SetVolumeeffect(float vol)
    {


        effectsounds = vol;

        PlayerPrefs.SetFloat("effectsounds", effectsounds);
        
    }
}
