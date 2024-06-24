using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using TMPro;
using UnityEngine;

public class WeapenShop : MonoBehaviour
{
    private int nbrActioin;
    private bool tern;
    int i;
    private int indexOfWeapen;
    public GameObject ButtonBuy;
    public TextMeshProUGUI moneytoBuy;
    int index;



    // Start is called before the first frame update
    void Start()
    {
        nbrActioin = 0;
        tern = false;
        indexOfWeapen = 0;
        ButtonBuy.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {

        if (indexOfWeapen < 0)
        {
            index = indexOfWeapen * -1;
        }
        else
        {
            index = indexOfWeapen;
        }
        Debug.Log(index);
        if(index % 4 != 0 )
        {

            string techre = "w" + (index % 4).ToString();
            int b= PlayerPrefs.GetInt(techre);
            if (b == 0)
            {
                ButtonBuy.SetActive(true);
            }
            else
            {
                ButtonBuy.SetActive(false);
            }
        }
        else
        {
            ButtonBuy.SetActive(false);
        }

        moneytoBuy.text = (20 * ((index % 4))).ToString();  




        if (tern && nbrActioin < 10)
        {
            transform.Rotate(new Vector3(0, i*9f , 0));
            nbrActioin++;
        }
        else
        {
            tern = false;
            nbrActioin = 0;
        }
    }

    public void RotateLeftPlayerShop()
    {
        tern = true;
        i = 1;
        indexOfWeapen+=3;

    }

    public void RotateRigthPlayerShop()
    {
        tern = true;
        i = -1;
        indexOfWeapen++;

    }

    public void BuyEquip()
    {
        if (int.TryParse(moneytoBuy.text, out int moneyValue))
        {
            if (PlayerPrefs.GetInt("money") - moneyValue > 0)
            {
                PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") - moneyValue);

                int index1;

                if (indexOfWeapen < 0)
                    index1 = indexOfWeapen * -1;
                else
                    index1 = indexOfWeapen;

                PlayerPrefs.SetInt("NumberWeapen", index1 % 4);

                string techre = "w" + (index1 % 4).ToString();
                PlayerPrefs.SetInt(techre, 1);
            }
        }
    }

    public void EquipWeapen()
    {
        int index;

        if(indexOfWeapen < 0)
            index = indexOfWeapen * -1;
                else
            index = indexOfWeapen;
        
        PlayerPrefs.SetInt("NumberWeapen", index % 4);
    }

}
