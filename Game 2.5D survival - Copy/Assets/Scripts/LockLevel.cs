using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LockLevel : MonoBehaviour
{
    public GameObject unlock;
    public int lvlNumber; 
    // Start is called before the first frame update
    void Start()
    {
        if (lvlNumber <= PlayerPrefs.GetInt("lvl"))
        {
            unlock.SetActive(false);

            PlayerPrefs.SetInt("lvl_done", 0);
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
