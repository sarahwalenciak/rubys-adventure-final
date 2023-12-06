using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scribble : MonoBehaviour
{
   
   public void scribbleend()
   {
    Destroy(gameObject);
   }
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

      if(Input.GetKeyDown(KeyCode.R))
        {
           Destroy(gameObject);
        }   
    }
}
