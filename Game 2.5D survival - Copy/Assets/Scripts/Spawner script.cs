using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnerscript : MonoBehaviour
{
    public GameObject Enemy;
    public bool isSpawning;
    private int nSpawn=1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isSpawning && nSpawn > 0) { 
            Instantiate(Enemy,transform.position,Quaternion.identity);
            nSpawn--;
        }
    }


}
