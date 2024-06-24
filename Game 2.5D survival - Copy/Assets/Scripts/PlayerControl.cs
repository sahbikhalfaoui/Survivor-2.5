using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float step;

    public float force;
    public GameObject cam;
    private int score;
    private Rigidbody rb;
    private float diff;
    private Vector3 movement;
    public int direction;
    private bool jumpMobile; 


    // Start is called before the first frame update
    void Start()
    {
        direction = -1;
        rb = GetComponent<Rigidbody>();
        diff = transform.position.x - cam.transform.position.x;
        jumpMobile = false;
    }

    public void MobileMouvmentRight()
    {
        direction = -1;
        movement = new Vector3(0.5f, 0, 0);
    }

    public void MobileMouvmentLeft()
    {
        movement = new Vector3(-0.5f, 0, 0);
        direction = 1;
    }

    public void MobileMouvmentJump()
    {
        if (!jumpMobile && rb.velocity.y == 0)
        {
            movement = new Vector3(0, 3f, 0);
            jumpMobile = true;
        }
    }

    public void JumpMoblieDonw()
    {
        Debug.Log("In Jump donw");
        jumpMobile = true;
    }




    // Update is called once per frame
    void Update()
    {
        // Touch on screen
        //if (Input.touchCount < 1)
        //    return;

        //Debug.Log(Input.GetTouch(0).position);
        //if (Input.GetTouch(0).position.y < Screen.height / 2)
        //    Debug.Log("Bottom");
        //else
        //    Debug.Log("Top");
        // Accelerometer
        //rb.velocity = new Vector3(Input.acceleration.x, 0, Input.acceleration.y) * speed;
        // Gyroscope



#if UNITY_ANDROID
        //Debug.Log("We are on Mobile Android ");

        //if (Input.touchCount < 1)
        //{
        //    movement = new Vector3(0, 0, 0);
        //}

        //if (jumpMobile && rb.velocity.y == 0)
        //{
        //    Debug.Log("In Jump");
        //    movement += Vector3.up * force;
        //}
        if (Input.touchCount < 1)
            rb.velocity = step * Time.deltaTime * movement;

        if (rb.velocity.y == 0)
        {
            jumpMobile = false;
        }

        cam.transform.position = new Vector3(transform.position.x + diff, cam.transform.position.y, cam.transform.position.z);

        //if (rb.velocity.y > 0)
        //{
        //    down = down - 0.5f  ;
        //}

        Debug.Log(rb.velocity + " " + movement);

        //else if (Input.GetTouch(0).position.x < Screen.width / 2)
        //{

        //}
        //else if (Input.GetTouch(0).position.x > Screen.width / 2)
        //{
        //}
#endif

#if UNITY_EDITOR
        // Debug.Log("We are on editor");


        //        movement = new Vector3(Input.GetAxis("Horizontal"), down, Input.GetAxis("Vertical"));
        //        movement = new Vector3(Input.GetAxis("Horizontal"), down, 0);
        //        if (Input.GetButtonDown("Jump") && rb.velocity.y == 0)
        //        {
        //            movement += Vector3.up * force;
        //            down = movement.y;
        //        }


        //        if (rb.velocity.y > 0)
        //        {
        //            down = down - 0.5f;
        //        }

        //        rb.velocity = step * Time.deltaTime * movement;

        //        cam.transform.position = new Vector3(transform.position.x + diff, cam.transform.position.y, cam.transform.position.z);
#endif



        // Input Mobile 


    }





    private void OnCollisionStay(Collision c1)
    {
        //if(c1.gameObject.name.Equals("Terrain"))
        //{
        //    down = 0f;
        //}
        
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name.Equals("Wall2"))
            Debug.Log("OnCollisionExit");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.name.Contains("Key"))
        {
            Destroy(other.gameObject);
            score++;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        
    }
}
