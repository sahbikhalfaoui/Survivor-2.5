using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShop : MonoBehaviour
{
    private int nbrActioin;
    private bool tern;
    private int caracter;


    // Start is called before the first frame update
    void Start()
    {
        nbrActioin = 0;
        tern = false;
        caracter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (tern && nbrActioin < 50)
        {
            transform.Rotate(new Vector3(0, 3.6f, 0));
            nbrActioin++;
        }
        else
        {
            tern = false;
            nbrActioin = 0;
        }

    }

    public void SelectCharacter()
    {
        PlayerPrefs.SetInt("caracter", caracter % 2);
    }
    public void RotatePlayerShop()
    {
        caracter++;
        tern = true;
    }
}
