using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PressR : MonoBehaviour
{
  public Color loadToColor = Color.black;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
     if(Input.GetKeyDown(KeyCode.R))
        {
           Initiate.Fade("MainScene",loadToColor,1.0f);
        } 
    }
}
