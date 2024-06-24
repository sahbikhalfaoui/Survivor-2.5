using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ControlMainMenuUI : MonoBehaviour
{
    public Toggle toggle;
    public void GoToLevels()
    {
        SceneManager.LoadScene("AllLevels");
    }

    public void GoToLShop()
    {
        SceneManager.LoadScene("AllShop");
    }
    // Start is called before the first frame update

    private void Awake()
    {
        int i = PlayerPrefs.GetInt("soundfx");
        if (i == 0)
            toggle.isOn = true;
        else
            toggle.isOn = false;
    }
    void Start()
    {
        if(PlayerPrefs.GetInt("health") == 0 )
        {
            PlayerPrefs.SetInt("health", 2);
        }
        
    }

    public void SetSoundFx()
    {
        if(toggle.isOn)
            PlayerPrefs.SetInt("soundfx", 0);
        else
            PlayerPrefs.SetInt("soundfx",1);
    }
    // Update is called once per frame

    public void GoToLOptions()
    {
        SceneManager.LoadScene("Options");
    }

    void Update()
    {
        
    }
    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
