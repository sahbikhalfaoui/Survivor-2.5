using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        if(PlayerPrefs.GetInt("lvl")==0)
        {
            PlayerPrefs.SetInt("lvl", 1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoToLvl1()
    {
        if (PlayerPrefs.GetInt("lvl") - 1 > 1)
        {
            PlayerPrefs.SetInt("lvl_done", 1);
        }
        SceneManager.LoadScene("Lvl1");
        
    }

    public void GoToLvl2()
    {
        if (PlayerPrefs.GetInt("lvl") - 2 > 1)
        {
            PlayerPrefs.SetInt("lvl_done", 1);
        }
        SceneManager.LoadScene("Lvl2");

    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
