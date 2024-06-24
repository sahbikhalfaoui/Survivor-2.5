using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour
{
    public GameObject shop;
    private bool tern;
    private int nbrActioin; 
    // Start is called before the first frame update
    void Start()
    {
        tern = false;
        nbrActioin = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (tern && nbrActioin < 100)
        {
            shop.transform.Rotate(new Vector3(0, 0.9f, 0));
            nbrActioin++;
        }
        else
        {
            tern = false;
            nbrActioin = 0;
        }
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Survivre");
    }

    public void GoToShop()
    {
        SceneManager.LoadScene("Shop");
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }


    public void RotateShop()
    {
        tern = true;
       /* if (shop.transform.rotation.y ==0)
            for (int i = 0; i < 10; i++)
                shop.transform.Rotate(new Vector3(0, 9, 0));
        else if(shop.transform.rotation.y ==90)
            for (int i = 0; i < 10; i++)
                    shop.transform.Rotate(new Vector3(0, 18, 0));
        else
            for (int i = 0; i < 10; i++)
                shop.transform.Rotate(new Vector3(0, 9, 0));*/
    }
}
