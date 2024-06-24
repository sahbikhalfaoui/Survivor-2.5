using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AddHealth : MonoBehaviour
{
    public int healthNumber;
    public GameObject buy;
    public TextMeshProUGUI money;
    public TextMeshProUGUI amount;
    // Start is called before the first frame update
    void Start()
    {
        amount.text = (30 * healthNumber).ToString();
        if(healthNumber > PlayerPrefs.GetInt("health") && (healthNumber - PlayerPrefs.GetInt("health") ==1) )
        {
            buy.SetActive(true);
        }
    }

    public void ButtonAddHealth()
    {
        //money = (int.Parse(money.text) - (10*healthNumber)).ToString();
        if (int.TryParse(money.text, out int moneyValue))
        {
            if (PlayerPrefs.GetInt("money") - (30 * healthNumber) > 0)
            {
                PlayerPrefs.SetInt("health", PlayerPrefs.GetInt("health") + 1);
                money.text = (moneyValue - 30 * healthNumber).ToString();
                PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") - (30 * healthNumber) );

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (healthNumber > PlayerPrefs.GetInt("health") && (healthNumber - PlayerPrefs.GetInt("health") == 1))
        {
            buy.SetActive(true);
        }
        else
        {
            buy.SetActive(false);
        }
    }
}
