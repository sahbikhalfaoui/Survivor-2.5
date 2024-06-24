using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI nbrFrames;

    private int frames;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        frames++;
        nbrFrames.text = "Frames :" + frames;
    }

    public void LoadNewScene()
    {
        SceneManager.LoadScene("Scene2");
    }
}
