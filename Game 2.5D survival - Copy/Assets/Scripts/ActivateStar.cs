using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateStar : MonoBehaviour
{
    public GameObject i1;
    public GameObject i2;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void changeToTheFullStat()
    {
        i1.SetActive(false);
        i2.SetActive(true);
    }
        
    // Update is called once per frame
    void Update()
    {

    }
}
