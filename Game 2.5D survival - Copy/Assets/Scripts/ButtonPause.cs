using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPause : MonoBehaviour
{
    public GameObject UIPause;


    public bool intPause;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("lvl") == 0)
            PlayerPrefs.SetInt("lvl", 1);

        if (PlayerPrefs.GetInt("soundfx") == 0)
            GetComponent<AudioSource>().mute = false;
        else GetComponent<AudioSource>().mute = true;
        intPause = false;
        UIPause.SetActive(intPause);
    }

    public void HideBtnAfterMakesound()
    {
        //soundCoins.Play();
        GameObject.Find("CollectBtn").SetActive(false);
        PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") +20);
        if (PlayerPrefs.GetInt("lvl_done") == 0)
        {
            PlayerPrefs.SetInt("lvl", PlayerPrefs.GetInt("lvl") + 1);
        }
    }
    public void ButtonPauseMain()
    {
        Time.timeScale = 0;
        intPause = true;
    }

    public void unPause()
    {
        Time.timeScale = 1;
        intPause = false;
    }

    public void GotoMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }

    public void Replay() 
    {
        Time.timeScale = 1;
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }

    // Update is called once per frame
    void Update()
    {
        UIPause.SetActive(intPause);
    }
}
