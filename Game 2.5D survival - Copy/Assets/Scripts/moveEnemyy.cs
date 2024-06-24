using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveEnemyy : MonoBehaviour
{
    [Range(300f, 700f)]
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

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name.Equals("bomb"))
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(hero.transform.position.x > transform.position.x) 
        {
            Debug.Log("+++ X");
            positionX =  Vector3.right;
        }
        else
        {
            positionX  = Vector3.left;
            Debug.Log("---- X");
        }

        if (hero.transform.position.z > transform.position.z)
        {
            positionY = Vector3.forward ;
            Debug.Log("+++ Z");
        }
        else
        {
            positionY = Vector3.back * step * Time.deltaTime;
            Debug.Log("--- Z");
        }

        rb.velocity = (positionX + positionY) * step * Time.deltaTime;  
    }
}
