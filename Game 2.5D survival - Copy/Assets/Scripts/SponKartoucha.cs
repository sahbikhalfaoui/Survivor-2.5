using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SponKartoucha : MonoBehaviour
{
    public GameObject kartoucha;

    // Start is called before the first frame update
    void Start()
    {

    }


    
    public void InstantiateSponKartoucha()
    {
        Instantiate(kartoucha, transform);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
