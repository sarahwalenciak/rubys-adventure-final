using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class FixedCounter : MonoBehaviour
{
    public Color loadToColor = Color.white;
    public static FixedCounter instance;

    public TMP_Text fixedText;
    public int fixedRobots = 0;

    void Awake()
    {
        instance = this;
    }
   
    // Start is called before the first frame update
    void Start()
    {
        fixedText.text = "Fixed robots: " + fixedRobots.ToString();
    }

    public void IncreaseFixed(int v)
    {
        fixedRobots += v;
        fixedText.text = "Fixed robots: " + fixedRobots.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        // Change this number to however many robots are in the scene!
        if (fixedRobots == 2)
        {
           Initiate.Fade("WinScene",loadToColor,1.0f); 
        }
        
    }
}
