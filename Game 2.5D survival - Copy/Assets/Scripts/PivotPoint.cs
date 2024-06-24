using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder;

public class PivotPoint : MonoBehaviour
{
    public GameObject hero;
    public int direction;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        direction = hero.GetComponent<PlayerMovement2>().direction;
    }
}
