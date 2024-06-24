using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveKartoucha : MonoBehaviour
{
    private float time;
    private Slider ScoreBar;

    // Start is called before the first frame update
    void Start()
    {
        ScoreBar = GameObject.Find("complete Lvl").GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime ;
        transform.Translate(Vector3.right * 10f * Time.deltaTime);
        if(time > 1.5f)
        Destroy(gameObject);
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
