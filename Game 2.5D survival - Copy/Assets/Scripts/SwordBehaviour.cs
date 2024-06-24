using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwordBehaviour : MonoBehaviour
{
    public GameObject pivot_point;
    public Slider ScoreBar;

    // Start is called before the first frame update
    void Start()
    {
        
    }




    // Update is called once per frame
    void Update()
    {
        int i = pivot_point.GetComponent<PivotPoint>().direction;
        if (Input.GetButtonDown("Attack"))
            transform.RotateAround(pivot_point.transform.position, Vector3.forward, i * 90);
        if (Input.GetButtonUp("Attack"))
            transform.RotateAround(pivot_point.transform.position, Vector3.forward, -i * 90);

    }


    public void attack()
    {
        int i = pivot_point.GetComponent<PivotPoint>().direction;
        Debug.Log(i);
        transform.RotateAround(pivot_point.transform.position, Vector3.forward, -i * 90);
    }

    public void raise()
    {
        int i = pivot_point.GetComponent<PivotPoint>().direction;
        transform.RotateAround(pivot_point.transform.position, Vector3.forward, i * 90);
    }

    private void OnTriggerEnter(Collider other)
    {
    }

    private void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag.Equals("Enemy"))
            {
            Destroy(c.gameObject);
            ScoreBar.value = ScoreBar.value + 1;

        }
    }
}


