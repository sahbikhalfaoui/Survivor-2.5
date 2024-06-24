using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManageStars : MonoBehaviour
{
    public GameObject s1;
    public GameObject s2;
    public GameObject s3;
    public Slider slider;
    private AudioSource soundStar;
    private int lastState;


    // Start is called before the first frame update
    void Start()
    {
        lastState = 0;
        soundStar = GetComponent<AudioSource>();
        if(PlayerPrefs.GetInt("soundfx")==0)
            soundStar.mute = false;
        else soundStar.mute = true;
    }

    // Update is called once per frame
    void Update()
    {
        
       if( slider.maxValue - slider.value == 2 ) 
        {
        s1.GetComponent<ActivateStar>().changeToTheFullStat();
            if(lastState != slider.maxValue - slider.value)
            {
                soundStar.Play();
            }
            lastState = (int)(slider.maxValue - slider.value);
        }
        else if (slider.maxValue - slider.value == 1)
        {
            s2.GetComponent<ActivateStar>().changeToTheFullStat();
            if (lastState != slider.maxValue - slider.value)
            {
                soundStar.Play();
            }
            lastState = (int)(slider.maxValue - slider.value);
        }
        else if (slider.maxValue - slider.value == 0)
        {
            s3.GetComponent<ActivateStar>().changeToTheFullStat();
            if (lastState != slider.maxValue - slider.value)
            {
                soundStar.Play();
            }
            lastState = (int)(slider.maxValue - slider.value);
        }

    }
}
