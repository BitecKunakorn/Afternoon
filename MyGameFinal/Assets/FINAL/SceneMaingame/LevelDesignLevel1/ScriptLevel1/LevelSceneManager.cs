using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSceneManager : MonoBehaviour
{
    public Text uiTextLightCount;
  

    /* public void GoToHome()
     {
         SceneManager.LoadScene("Home");
     }*/
    public void SetTextLightCount(int amount)
    {
        uiTextLightCount.text = amount.ToString();
    }

}
