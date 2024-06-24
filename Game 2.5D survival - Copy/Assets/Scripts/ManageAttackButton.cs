using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ManageAttackButton : MonoBehaviour
{
    private GameObject weapen; 
    private GameObject gun;
    // Start is called before the first frame update
    void Start()
    {
        weapen = GameObject.Find("Weapon");
        gun = GameObject.Find("Gun");
    }

    public void NormalizeAttack()
    {
        if (gun != null)
            gun.GetComponent<FireGun>().AttackKeartoucha();
        if (weapen != null)
        {

            weapen.GetComponent<SwordBehaviour>().attack();
        }
    }

    public void NormalizeAttackRaise()
    {
        Debug.Log("in raise");
        if (gun != null) { }
        if (weapen != null)
        {
                Debug.Log("attack raise");
            weapen.GetComponent<SwordBehaviour>().raise();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
