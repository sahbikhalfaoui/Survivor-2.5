using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlShopUI : MonoBehaviour
{
    public GameObject UIPlayer;
    public GameObject UIWeapen;
    public GameObject UIHealth;

    public GameObject Gp;
    public GameObject Gw;
    public TextMeshProUGUI money; 


    public void OpenPersoShop()
    {
        UIPlayer.SetActive(true);
        UIWeapen.SetActive(false);
        UIHealth.SetActive(false);


        Gp.SetActive(true);
        Gw.SetActive(false);

    }

    public void OpenWeapenShop()
    {
        UIPlayer.SetActive(false);
        UIWeapen.SetActive(true);
        UIHealth.SetActive(false);


        Gp.SetActive(false);
        Gw.SetActive(true);
    }

    public void OpenHealthShop ()
    {
        UIPlayer.SetActive(false);
        UIWeapen.SetActive(false);
        UIHealth.SetActive(true);


        Gp.SetActive(false);
        Gw.SetActive(false);
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        money.text = PlayerPrefs.GetInt("money").ToString();
    }
}
