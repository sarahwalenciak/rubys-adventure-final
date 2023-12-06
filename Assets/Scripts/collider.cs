using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collider : MonoBehaviour
{

     public Color loadToColor = Color.black;
       void OnCollisionEnter2D(Collision2D other)
    {
    
        Initiate.Fade("MainScene", loadToColor, 1.0f);
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
