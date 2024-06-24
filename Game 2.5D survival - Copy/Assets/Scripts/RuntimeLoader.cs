using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuntimeLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Texture2D texture2D = Resources.Load<Texture2D>("logo_gamix");
        GetComponent<MeshRenderer>().material.mainTexture = texture2D;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
