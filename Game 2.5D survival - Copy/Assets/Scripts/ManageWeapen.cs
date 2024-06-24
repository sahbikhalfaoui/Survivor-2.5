using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageWeapen : MonoBehaviour
{
    public GameObject bat;
    public GameObject gun;
    // Start is called before the first frame update
    private void Awake()
    {
        Debug.Log(PlayerPrefs.GetInt("NumberWeapen"));
        if (PlayerPrefs.GetInt("NumberWeapen") == 0)
        {
            bat.SetActive(true);
            gun.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("NumberWeapen") == 3)
        {
            gun.SetActive(true);
            bat.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
