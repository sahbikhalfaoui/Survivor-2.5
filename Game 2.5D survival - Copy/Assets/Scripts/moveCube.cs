using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCube : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // rigth and left 
        Debug.Log((transform.position.z < 0.1f && transform.position.z > -0.1f) && transform.position.x < 2f) ;
        if ((transform.position.z < 0.1f && transform.position.z > -0.1f) && transform.position.x < 2f)
        {
            Debug.Log("1");
            transform.position = new Vector3(transform.position.x + 0.001f, 0, transform.position.z);
        }
        else if (transform.position.z < -2f && transform.position.x > 0f)
        {
            Debug.Log("3");
            transform.position = new Vector3(transform.position.x - 0.001f, 0, transform.position.z);
        }

        else
        {
            //  down up
            if (transform.position.x >= 2 && transform.position.z >= -2)
            {
                Debug.Log("cqwcw");
                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 0.001f);
            }
            else 
            {
                Debug.Log("sss");
                transform.position = new Vector3(0, transform.position.y, transform.position.z + 0.001f);
            }
        }

    }
}
