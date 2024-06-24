using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    [Range(100f, 700f)]
    public float step;
    // Start is called before the first frame update
    public GameObject hero;
    private Rigidbody rb;
    private Vector3 positionX;
    private Vector3 positionY;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hero.transform.position.x > transform.position.x)
        {
            positionX = Vector3.right;
            transform.eulerAngles = new Vector3(0,90,0);
        }
        else
        {
            positionX = Vector3.left;
            transform.eulerAngles = new Vector3(0, -90, 0);
        }

        //if (hero.transform.position.z > transform.position.z)
        //{
        //    positionY = Vector3.forward;
        //}
        //else
        //{
        //    positionY = Vector3.back * step * Time.deltaTime;
        //}

        rb.velocity = (positionX + positionY) * step * Time.deltaTime;
    }


    
}
