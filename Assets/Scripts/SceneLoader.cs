using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
  

  public Color loadToColor = Color.black;
    public void QuitGame()
    {
      Application.Quit();
      Debug.Log("Quit!");
    }

    public void Restart()
    {
      Initiate.Fade("MainScene", loadToColor, 1.0f);
    }

  

}
