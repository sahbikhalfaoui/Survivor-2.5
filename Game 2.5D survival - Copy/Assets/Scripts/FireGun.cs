using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FireGun : MonoBehaviour
{
    public SponKartoucha sk;
    private AudioSource shot;

    // Start is called before the first frame update
    void Start()
    {
        shot = GetComponent<AudioSource>();
        if (PlayerPrefs.GetInt("soundfx") == 0)
            shot.mute = false;
        else
            shot.mute = true;
    }


    public void AttackKeartoucha()
    {
        Debug.Log("attack");
        sk.InstantiateSponKartoucha();
        shot.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Attack"))
        {
            AttackKeartoucha();
        }

    }
}
